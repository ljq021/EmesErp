using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Emes.CodeGen.Core;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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
        private int _dataTypeId;

        private bool _required;

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

        [DisplayName("DataType")]
        public int DataTypeId
        {
            get => this._dataTypeId;
            set => this.Set(ref this._dataTypeId, value);
        }
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
    }

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
        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 字段
        /// </summary>
        public List<EmesModalFields> Fields { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
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

            this.CultureInfos = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures).OrderBy(c => c.DisplayName).ToList();
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
                 async x =>
                 {
                     this.Fields.Add(new EmesModalFields());
                 }
             );
            this.GenCommand = new SimpleCommand(
            o => true,
            async x =>
            {
                Console.WriteLine("1eeeeeeeeeeeeeeeee");
                await Task.FromResult(true);
            }
        );


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
        public List<EmesModalFields> Fields { get; set; } = new List<EmesModalFields>();
        string _module;
        string _name;
        string _code;
        string _desc;
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
        public string Desc
        {
            get => this._desc;
            set => this.Set(ref this._desc, value);
        }
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

    }

}
