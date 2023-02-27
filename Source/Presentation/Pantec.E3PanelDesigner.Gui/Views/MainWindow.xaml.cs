using Pantec.E3Wrapper.ApplicationSelection.Gui.Views.Interfaces;
using System.Windows;

namespace Pantec.E3PanelDesigner.Views
{
    /// <inheritdoc cref="IDialogView" />
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IDialogView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
