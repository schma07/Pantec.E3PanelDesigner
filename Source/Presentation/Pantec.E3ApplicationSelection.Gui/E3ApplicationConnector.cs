using Pantec.E3Wrapper.ApplicationSelection.Gui.ViewModels;
using Pantec.E3Wrapper.Core.Application;
using Pantec.E3Wrapper.Core.Domain.Interfaces;

namespace Pantec.E3Wrapper.ApplicationSelection.Gui
{
    /// <inheritdoc />
    /// <summary>
    /// Connector use GUI for Application selection by default
    /// </summary>
    public class E3ApplicationConnector : ConnectorBase
    {
        public override IApplication Connect()
        {
            return Connect(new SelectionViewModel());
        }
    }
}
