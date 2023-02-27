using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantec.E3Wrapper.ApplicationSelection.Gui.Views.Interfaces
{
    /// <summary>
    /// Selection Dialog (ApplicationSelectionWindow) must implement this interface
    /// </summary>
    public interface IDialogView
    {
        /// <summary>
        /// DataContext of View (etc. concrete ViewModel)
        /// </summary>
        object DataContext { get; set; }

        /// <summary>
        /// Close Dialog
        /// </summary>
        void Close();

        /// <summary>
        /// Show dialog
        /// </summary>
        /// <returns></returns>
        bool? ShowDialog();

        /// <summary>
        /// Dialog result
        /// </summary>
        bool? DialogResult { get; set; }
    }
}
