using Pantec.E3Proxy.Extensions;
using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Models;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy
{
    public interface IPanelLocation
    {
        /// <summary>
        /// Coordintates and rotation of device model on panel sheet
        /// </summary>
        PanelLocationStruct? PanelLocation { get; set; } // Todo: Set method for panel model coordinates               

        /// <summary>
        /// Id of device´s model
        /// </summary>
        //string? ModelId { get; }


        /// <summary>
        /// Name of device´s model
        /// </summary>
        string? ModelName { get; }

        /// <summary>
        /// Get device´s model name
        /// </summary>
        /// <returns></returns>
        string GetModelName();

        /// <summary>
        /// Get mounted slot ids for device
        /// </summary>
        /// <param name="device">E3.series IDeviceInterface COM object</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        IEnumerable<int> GetMountedSlotIdsEnumerable(IDevice device);        

        /// <summary>
        /// Check for model is placed on sheet
        /// </summary>
        /// <returns></returns>
        bool IsModelPlaced();
        
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