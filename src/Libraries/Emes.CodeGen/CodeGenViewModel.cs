using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Emes.CodeGen.Core;
using Emes.CodeGen.Template.T4TemplateEngineHost;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.VisualStudio.TextTemplating;
using Newtonsoft.Json;
using NHotkey;
using NHotkey.Wpf;

namespace Emes.CodeGen
{
    public enum DataType
    {
        String,
        Int,
        DateTime,
        Long,
        Decimal,
        Boolean
    }

    public class EmesModalFields : ViewModelBase
    {
        private string _name;
        private string _code;
        private string _desc;
        private DataType _dataType;

        private bool _required;

        private bool _isDto = true;

        /// <summary>
        /// 字段名
        /// </summary>
        public string Name
        {
            get => this._name;
            set => this.Set(ref this._name, value);
        }
        /// <summary>
        /// 字段code
        /// </summary>
        public string Code
        {
            get => this._code;
            set => this.Set(ref this._code, value);
        }
        /// <summary>
        /// 字段描述
        /// </summary>
        public string Desc
        {
            get => this._desc;
            set => this.Set(ref this._desc, value);
        }

        //[DisplayName("DataType")]
        //public int DataTypeId
        //{
        //    get => this._dataTypeId;
        //    set => this.Set(ref this._dataTypeId, value);
        //}
        /// <summary>
        /// 字段数据类型
        /// </summary>
        public virtual DataType DataType
        {
            get => this._dataType;
            set => this.Set(ref this._dataType, value);
        }


        /// <summary>
        /// 是否必填
        /// </summary>

        public bool Required
        {
            get => this._required;
            set => this.Set(ref this._required, value);
        }

        /// <summary>
        /// 是否Dto字段
        /// </summary>
        public bool IsDto
        {
            get => this._isDto;
            set => this.Set(ref this._isDto, value);
        }

    }

    [Serializable]
    public class EmesModalDesigner
    {
        /// <summary>
        /// 模块
        /// </summary>
        public string Module { get; set; }
        /// <summary>
        /// 实体名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 实体名称code
        /// </summary>
        public string Code { get; set; }

        public string CamelCaseCode
        {
            get
            {
                return string.Concat(Code.Substring(0, 1).ToLower(), Code.Substring(1));
            }
        }
        /// <summary>
        /// 实体名称codes
        /// </summary>
        public string Codes { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; }

        public string DefaultPath { get; set; }
        /// <summary>
        /// 是否聚合根
        /// </summary>
        public bool AggregateRoot { get; set; }

        /// <summary>
        /// 字段
        /// </summary>
        public List<EmesModalDesignerFields> Fields { get; set; }

        /// <summary>
        /// Dto字段
        /// </summary>
        public List<EmesModalDesignerFields> DtoFields
        {
            get
            {
                return Fields.Where(x => x.IsDto).ToList();
            }
        }


    }

    [Serializable]
    public class EmesModalDesignerFields
    {
        /// <summary>
        /// 字段名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 字段code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 字段描述
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// 字段数据类型
        /// </summary>
        public DataType DataType { get; set; }

        public string DataTypeValue
        {
            get
            {
                switch (DataType)
                {
                    case DataType.String:
                        return "string";
                    case DataType.Int:
                        return "int";
                    case DataType.DateTime:
                        return "DateTimeOffset";
                    case DataType.Long:
                        return "long";
                    case DataType.Decimal:
                        return "decimal";
                    case DataType.Boolean:
                        return "bool";
                    default:
                        return "";
                }
                return "";
            }
        }
        /// <summary>
        /// 是否必填
        /// </summary>

        public bool Required { get; set; }

        public bool IsDto { get; set; }
    }

    public class CodeGenViewModel : ViewModelBase, IDataErrorInfo, IDisposable
    {
        private readonly IDialogCoordinator _dialogCoordinator;
        int? _integerGreater10Property;
        private bool _animateOnPositionChange = true;



        public CodeGenViewModel(IDialogCoordinator dialogCoordinator)
        {
            this.Title = "Flyout Binding Test";
            this._dialogCoordinator = dialogCoordinator;
            this.DataTypes = EnumToList<DataType>();
            this.CultureInfos = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures).OrderBy(c => c.DisplayName).ToList();

            this.DefaultPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).FullName, "Modules");
            #if DEBUG
            this.Fields.Add(new EmesModalFields()
            {
                Name = "姓名",
                Desc = "用户姓名",
                Code = "Name",
                DataType = DataType.String,
                Required = true
            });
            #endif
            for (int i = 0; i < 10; i++)
            {
                this.Fields.Add(new EmesModalFields());
            }

            try
            {
                HotkeyManager.Current.AddOrReplace("demo", this.HotKey.Key, this.HotKey.ModifierKeys, (sender, e) => this.OnHotKey(sender, e));
            }
            catch (HotkeyAlreadyRegisteredException exception)
            {
                System.Diagnostics.Trace.TraceWarning("Uups, the hotkey {0} is already registered!", exception.Name);
            }

            this.EndOfScrollReachedCmdWithParameter = new SimpleCommand(o => true, async x => { await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync("End of scroll reached!", $"Parameter: {x}"); });

            this.CloseCmd = new SimpleCommand(o => this.CanCloseFlyout, x => ((Flyout)x).IsOpen = false);

            this.AddCommand = new SimpleCommand(
                 o => true,
                  x =>
                 {
                     this.Fields.Add(new EmesModalFields());
                 }
             );
            this.GenCommand = new SimpleCommand(
                o => true,
                 x =>
                {
                    this.CodeGen();
                }
            );
        }

        private void CodeGen()
        {
            var paths = new string[]
            {
                "Template\\CreateDto.tt",
                "Template\\DeleteDto.tt",
                "Template\\NativeDto.tt",
                "Template\\QueryDto.tt",
                "Template\\UpdateDto.tt",
                "Template\\IService.tt",
                "Template\\Model.tt",
                "Template\\Service.tt",
                "Template\\Profile.tt",
            };

            for (int i = 0; i < paths.Length; i++)
            {
                var tempPath = Path.Combine(Environment.CurrentDirectory, paths[i]);
                if (File.Exists(tempPath) == false)
                {
                    this._dialogCoordinator.ShowMessageAsync(this, "提示", "模板文件不存在");
                    return;
                }
            }

            var ds = new EmesModalDesigner()
            {
                Module = this.Module,
                Name = this.Name,
                Code = this.Code,
                Codes = this.Codes,
                Desc = this.Desc,
                AggregateRoot = this.AggregateRoot,
                Fields = this.Fields.Where(f => !string.IsNullOrWhiteSpace(f.Name) && !string.IsNullOrWhiteSpace(f.Code)).Select(x => new EmesModalDesignerFields()
                {
                    Name = x.Name,
                    Code = x.Code,
                    Desc = x.Desc,
                    DataType = x.DataType,
                    Required = x.Required,
                    IsDto = x.IsDto
                }).ToList()
            };

            Engine engine = new Engine();
            // dto
            var dtoPaths = new List<string>()
            {
               "Template\\CreateDto.tt",
                "Template\\DeleteDto.tt",
                "Template\\NativeDto.tt",
                "Template\\QueryDto.tt",
                "Template\\UpdateDto.tt",
            };
            GenDto(ds, engine, dtoPaths);

            //Model
            GenModel(ds, engine, Path.Combine(Environment.CurrentDirectory, "Template\\Model.tt"));
            //Profile
            GenProfile(ds, engine, Path.Combine(Environment.CurrentDirectory, "Template\\Profile.tt"));
            if (this.AggregateRoot)
            {
                //Service
                GenSrv(ds, engine, Path.Combine(Environment.CurrentDirectory, "Template\\Service.tt"));
                //IService
                GenISrv(ds, engine, Path.Combine(Environment.CurrentDirectory, "Template\\IService.tt"));
            }

        }

        private void GenDto(EmesModalDesigner ds, Engine engine, List<string> tempPath)
        {
            tempPath.ForEach(x =>
            {
                DefaultHost host = new DefaultHost();
                host.Designer = ds;
                host.TemplateFile = Path.Combine(Environment.CurrentDirectory, x);


                string outputContent = engine.ProcessTemplate(File.ReadAllText(host.TemplateFile), host);
                string outputPath = Path.Combine(this.DefaultPath, this.Module, $"Emes.Erp.I{this.Module}", "Dtos", this.Codes);

                StringBuilder sb = new StringBuilder();

                string outputFile = Path.Combine(outputPath, string.Format("{0}{1}", this.GetDtoName(x, this.Code), host.FileExtention));
                if (host.ErrorCollection.HasErrors)
                {
                    foreach (CompilerError err in host.ErrorCollection)
                    {
                        sb.AppendLine(err.ToString());
                    }
                    outputContent = outputContent + Environment.NewLine + sb.ToString();
                    outputFile = outputFile + ".error";
                }
                if (Directory.Exists(outputPath) == false)
                    Directory.CreateDirectory(outputPath);
                File.WriteAllText(outputFile, outputContent, Encoding.UTF8);
            });

        }
        private string GetDtoName(string tempPath, string code)
        {
            if (tempPath.Contains("CreateDto"))
            {
                return $"Create{code}Dto";
            }
            else if (tempPath.Contains("DeleteDto"))
            {
                return $"Delete{code}Dto";
            }
            else if (tempPath.Contains("NativeDto"))
            {
                return $"{code}Dto";
            }
            else if (tempPath.Contains("QueryDto"))
            {
                return $"Query{code}Dto";
            }
            else if (tempPath.Contains("UpdateDto"))
            {
                return $"Update{code}Dto";
            }
            return "Error";
        }
        private void GenISrv(EmesModalDesigner ds, Engine engine, string tempPath)
        {
            DefaultHost host = new DefaultHost();
            host.Designer = ds;
            host.TemplateFile = tempPath;
            string outputContent = engine.ProcessTemplate(File.ReadAllText(tempPath), host);
            string outputPath = Path.Combine(this.DefaultPath, this.Module, $"Emes.Erp.I{this.Module}");
            string outputFile = Path.Combine(outputPath, string.Format("I{0}Service{1}", host.Designer.Code, host.FileExtention));
            StringBuilder sb = new StringBuilder();
            if (host.ErrorCollection.HasErrors)
            {
                foreach (CompilerError err in host.ErrorCollection)
                {
                    sb.AppendLine(err.ToString());
                }
                outputContent = outputContent + Environment.NewLine + sb.ToString();
                outputFile = outputFile + ".error";
            }

            if (Directory.Exists(outputPath) == false)
                Directory.CreateDirectory(outputPath);
            File.WriteAllText(outputFile, outputContent, Encoding.UTF8);
        }
        private void GenSrv(EmesModalDesigner ds, Engine engine, string tempPath)
        {
            DefaultHost host = new DefaultHost();
            host.Designer = ds;
            host.TemplateFile = tempPath;
            string outputContent = engine.ProcessTemplate(File.ReadAllText(tempPath), host);
            string outputPath = Path.Combine(this.DefaultPath, this.Module, $"Emes.Erp.{this.Module}", "Implementation");
            string outputFile = Path.Combine(outputPath, string.Format("{0}Service{1}", host.Designer.Code, host.FileExtention));
            StringBuilder sb = new StringBuilder();
            if (host.ErrorCollection.HasErrors)
            {
                foreach (CompilerError err in host.ErrorCollection)
                {
                    sb.AppendLine(err.ToString());
                }
                outputContent = outputContent + Environment.NewLine + sb.ToString();
                outputFile = outputFile + ".error";
            }

            if (Directory.Exists(outputPath) == false)
                Directory.CreateDirectory(outputPath);
            File.WriteAllText(outputFile, outputContent, Encoding.UTF8);
        }
        private void GenModel(EmesModalDesigner ds, Engine engine, string tempPath)
        {
            DefaultHost host = new DefaultHost();
            host.Designer = ds;
            host.TemplateFile = tempPath;
            string outputContent = engine.ProcessTemplate(File.ReadAllText(tempPath), host);
            string outputPath = Path.Combine(this.DefaultPath, this.Module, $"Emes.Erp.{this.Module}", "Models");
            string outputFile = Path.Combine(outputPath, string.Format("{0}{1}", host.Designer.Code, host.FileExtention));
            StringBuilder sb = new StringBuilder();
            if (host.ErrorCollection.HasErrors)
            {
                foreach (CompilerError err in host.ErrorCollection)
                {
                    sb.AppendLine(err.ToString());
                }
                outputContent = outputContent + Environment.NewLine + sb.ToString();
                outputFile = outputFile + ".error";
            }

            if (Directory.Exists(outputPath) == false)
                Directory.CreateDirectory(outputPath);
            File.WriteAllText(outputFile, outputContent, Encoding.UTF8);
        }

        private void GenProfile(EmesModalDesigner ds, Engine engine, string tempPath)
        {
            DefaultHost host = new DefaultHost();
            host.Designer = ds;
            host.TemplateFile = tempPath;
            string outputContent = engine.ProcessTemplate(File.ReadAllText(tempPath), host);
            string outputPath = Path.Combine(this.DefaultPath, this.Module, $"Emes.Erp.{this.Module}", "Implementation", "AutoMapper");
            string outputFile = Path.Combine(outputPath, string.Format("{0}Profile{1}", host.Designer.Code, host.FileExtention));
            StringBuilder sb = new StringBuilder();
            if (host.ErrorCollection.HasErrors)
            {
                foreach (CompilerError err in host.ErrorCollection)
                {
                    sb.AppendLine(err.ToString());
                }
                outputContent = outputContent + Environment.NewLine + sb.ToString();
                outputFile = outputFile + ".error";
            }

            if (Directory.Exists(outputPath) == false)
                Directory.CreateDirectory(outputPath);
            File.WriteAllText(outputFile, outputContent, Encoding.UTF8);
        }


        public void Dispose()
        {
            HotkeyManager.Current.Remove("demo");
        }

        public string Title { get; set; }

        public int SelectedIndex { get; set; }

        public List<CultureInfo> CultureInfos { get; set; }

        private CultureInfo currentCulture = CultureInfo.CurrentCulture;

        public CultureInfo CurrentCulture
        {
            get => this.currentCulture;
            set => this.Set(ref this.currentCulture, value);
        }


        #region prop
        //public List<> MyProperty { get; set; }
        public ObservableCollection<EmesModalFields> Fields { get; set; } = new ObservableCollection<EmesModalFields>();
        string _module = "System";
        string _name = "用户领域模型";
        string _code = "User";
        string _codes = "Users";
        string _desc = "用户";
        string _defaultPath = "";
        bool _aggregateRoot = true;
        public string Module
        {
            get => this._module;
            set => this.Set(ref this._module, value);
        }
        public string Name
        {
            get => this._name;
            set => this.Set(ref this._name, value);
        }
        public string Code
        {
            get => this._code;
            set => this.Set(ref this._code, value);
        }
        public string Codes
        {
            get => this._codes;
            set => this.Set(ref this._codes, value);
        }
        public string Desc
        {
            get => this._desc;
            set => this.Set(ref this._desc, value);
        }

        public string DefaultPath
        {
            get => this._defaultPath;
            set => this.Set(ref this._defaultPath, value);
        }
        public bool AggregateRoot
        {
            get => this._aggregateRoot;
            set => this.Set(ref this._aggregateRoot, value);
        }


        public List<EnumberEntity> DataTypes { get; set; }
        #endregion



        public ICommand EndOfScrollReachedCmdWithParameter { get; }

        public int? IntegerGreater10Property
        {
            get => this._integerGreater10Property;
            set => this.Set(ref this._integerGreater10Property, value);
        }

        private DateTime? _datePickerDate;

        [Display(Prompt = "Auto resolved Watermark")]
        public DateTime? DatePickerDate
        {
            get => this._datePickerDate;
            set => this.Set(ref this._datePickerDate, value);
        }

        private bool _quitConfirmationEnabled;

        public bool QuitConfirmationEnabled
        {
            get => this._quitConfirmationEnabled;
            set => this.Set(ref this._quitConfirmationEnabled, value);
        }

        private bool showMyTitleBar = true;

        public bool ShowMyTitleBar
        {
            get => this.showMyTitleBar;
            set => this.Set(ref this.showMyTitleBar, value);
        }

        private bool canCloseFlyout = true;

        public bool CanCloseFlyout
        {
            get => this.canCloseFlyout;
            set => this.Set(ref this.canCloseFlyout, value);
        }

        public ICommand CloseCmd { get; }


        [Description("Test-Property")]
        public string Error => string.Empty;

        private DateTime? _timePickerDate;

        [Display(Prompt = "Time needed...")]
        public DateTime? TimePickerDate
        {
            get => this._timePickerDate;
            set => this.Set(ref this._timePickerDate, value);
        }

        public ICommand AddCommand { get; }
        public ICommand GenCommand { get; }

        public ICommand ShowMessageDialogCommand { get; }

        private Action ShowMessage(string startingThread)
        {
            return () =>
            {
                var message = $"MVVM based messages!\n\nThis dialog was created by {startingThread} Thread with ID=\"{Thread.CurrentThread.ManagedThreadId}\"\n" +
                              $"The current DISPATCHER_THREAD Thread has the ID=\"{Application.Current.Dispatcher.Thread.ManagedThreadId}\"";
                this._dialogCoordinator.ShowMessageAsync(this, $"Message from VM created by {startingThread}", message).ContinueWith(t => Console.WriteLine(t.Result));
            };
        }

        public ICommand ShowProgressDialogCommand { get; }

        private async void RunProgressFromVm()
        {
            var controller = await this._dialogCoordinator.ShowProgressAsync(this, "Progress from VM", "Progressing all the things, wait 3 seconds");
            controller.SetIndeterminate();

            await Task.Delay(3000);

            await controller.CloseAsync();
        }

        private HotKey _hotKey = new HotKey(Key.Home, ModifierKeys.Control | ModifierKeys.Shift);

        public HotKey HotKey
        {
            get => this._hotKey;
            set
            {
                if (this.Set(ref this._hotKey, value))
                {
                    if (value != null && value.Key != Key.None)
                    {
                        HotkeyManager.Current.AddOrReplace("demo", value.Key, value.ModifierKeys, async (sender, e) => await this.OnHotKey(sender, e));
                    }
                    else
                    {
                        HotkeyManager.Current.Remove("demo");
                    }
                }
            }
        }


        private async Task OnHotKey(object sender, HotkeyEventArgs e)
        {
            await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync(
                "Hotkey pressed",
                "You pressed the hotkey '" + this.HotKey + "' registered with the name '" + e.Name + "'");
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(IntegerGreater10Property) && this.IntegerGreater10Property < 10)
                {
                    return "Number is not greater than 10!";
                }

                if (columnName == nameof(DatePickerDate) && this.DatePickerDate == null)
                {
                    return "No date given!";
                }

                if (columnName == nameof(HotKey) && this.HotKey != null && this.HotKey.Key == Key.D && this.HotKey.ModifierKeys == ModifierKeys.Shift)
                {
                    return "SHIFT-D is not allowed";
                }

                if (columnName == nameof(TimePickerDate) && this.TimePickerDate == null)
                {
                    return "No time given!";
                }


                return null;
            }
        }

        public static List<EnumberEntity> EnumToList<T>()
        {
            List<EnumberEntity> list = new List<EnumberEntity>();

            foreach (var e in Enum.GetValues(typeof(T)))
            {
                EnumberEntity m = new EnumberEntity();
                object[] objArr = e.GetType().GetField(e.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (objArr != null && objArr.Length > 0)
                {
                    DescriptionAttribute da = objArr[0] as DescriptionAttribute;
                    m.Desction = da.Description;
                }
                m.Value = Convert.ToInt32(e);
                m.Name = e.ToString();
                list.Add(m);
            }
            return list;
        }

    }

    public class EnumberEntity
    {
        /// <summary>  
        /// 枚举的描述  
        /// </summary>  
        public string Desction { set; get; }

        /// <summary>  
        /// 枚举名称  
        /// </summary>  
        public string Name { set; get; }

        /// <summary>  
        /// 枚举对象的值  
        /// </summary>  
        public int Value { set; get; }
    }

}
