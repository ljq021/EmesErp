using System.Windows.Input;
using Microsoft.Xaml.Behaviors.Core;

namespace Emes.CodeGen.ExampleWindows
{
    public partial class VSDemo
    {
        public VSDemo()
        {
            InitializeComponent();
        }

        public ICommand QuickLaunchBarFocusCommand => new ActionCommand(FocusQuickLaunchBar);

        private void FocusQuickLaunchBar()
        {
            QuickLaunchBar.Focus();
        }
    }
}