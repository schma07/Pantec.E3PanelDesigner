
using Pantec.E3Wrapper.ApplicationSelection.Gui.Commands;
using Pantec.E3Wrapper.ApplicationSelection.Gui.Models;
using Pantec.E3Wrapper.ApplicationSelection.Gui.ViewModels.Base;
using Pantec.E3Wrapper.ApplicationSelection.Gui.Views;
using Pantec.E3Wrapper.ApplicationSelection.Gui.Views.Interfaces;
using Pantec.E3Wrapper.Core.Application.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Pantec.E3Wrapper.ApplicationSelection.Gui.ViewModels
{
    internal class SelectionViewModel : ViewModelBase<SelectionWindow>, IConnectorSelectionDialog
    {
        /// <summary>
        /// Selected E3.series instance on form
        /// </summary>
        public RunningApplication SelectedProcess { get; set; }

        /// <summary>
        /// List of running E3.series instances
        /// </summary>
        public List<RunningApplication> Processes { get; }

        public ICommand OkCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }

        public SelectionViewModel()
            : base(new SelectionWindow())
        {
            Processes = new List<RunningApplication>();

            CreateCommands();
        }

        public bool ShowDialog(IDictionary<int, object> processes, out object selectedProcess)
        {
            Processes.AddRange(processes.Select(p => new RunningApplication(p)));

            var result = View.ShowDialog() == true;
            selectedProcess = SelectedProcess != null && result
                ? SelectedProcess.ComObject
                : null;

            return result;
        }

        private void CreateCommands()
        {
            OkCommand = new RelayCommand(
                () => { (View as IDialogView).DialogResult = true; },
                () => SelectedProcess != null);
            CancelCommand = new RelayCommand(
                () => { (View as IDialogView).DialogResult = false; });
        }
    }
}
