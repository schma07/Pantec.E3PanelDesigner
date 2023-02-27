using Pantec.E3PanelDesigner.ViewModels;
using System.Windows;

namespace Pantec.E3PanelDesigner
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App 
    {  
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var entryPoint = new MainViewModel();
            entryPoint.View.Show();
        }
    }
}
