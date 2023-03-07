using Pantec.E3Wrapper.Core.Domain.Models;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy
{
    public interface IE3PanelLocation
    {
        /// <summary>
        /// Coordintates and rotation of device model on panel sheet
        /// </summary>
        PanelLocationStruct? PanelLocation { get; set; } // Todo: Set method for panel model coordinates               
        
        /// <summary>
        /// Check for model is placed on sheet
        /// </summary>
        /// <returns></returns>
        bool ModelIsPlaced();
        
        /// <summary>
        /// Get device location on panel sheet
        /// </summary>
        PanelLocationStruct? GetPanelLocationStruct();

        /// <summary>
        /// Set device location on panel sheet
        /// </summary>
        /// <param name="panelLocation">New location</param>
        /// <returns></returns>
        bool SetPanelLocationStruct(PanelLocationStruct panelLocation);
    }
}