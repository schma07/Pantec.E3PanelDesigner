using Pantec.E3Proxy.Extensions;
using Pantec.E3Wrapper.Core.Domain.Interfaces;
using Pantec.E3Wrapper.Core.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pantec.E3Wrapper.ApplicationSelection.Gui.Models
{
    /// <summary>
    /// Aggregate for working with panel models
    /// </summary>
    public class ModelAggregate
    {
        /// <summary>
        /// Constructor creates object with device properties
        /// </summary>
        /// <param name="device"></param>
        public ModelAggregate(IDevice device)
        {
            this.ModelName = device.GetModelName();
            this.SlotsOnModel = device.GetMountedSlotIdsEnumerable(device).ToList();
            this.PanelLocation = device.GetPanelLocationStruct();            
        }
        
        /// <summary>
        /// Constructor for object including device and slot properties 
        /// </summary>
        /// <param name="device"></param>
        /// <param name="slot"></param>
        public ModelAggregate(IDevice device, ISlot slot) : this(device)
        {            
            this.MountType = slot.GetMountType();
            this.SlotName = slot.GetName();
        }

        /// <summary>
        /// E3.Series device´s model id
        /// </summary>
        public int? ModelId { get; }

        /// <summary>
        /// E3.Series device´s model name
        /// </summary>
        public string? ModelName { get; }

        /// <summary>
        /// Current panel model placement coordinates
        /// </summary>
        public PanelLocationStruct? PanelLocation { get; set; }

        /// <summary>
        /// E3.Series model mount type
        /// </summary>
        public string? MountType { get; }

        /// <summary>
        /// E3.Series slot name
        /// </summary>
        /// <remarks>String value comprises slot id and name separated by :</remarks>
        public string SlotName { get; }

        /// <summary>
        /// E3.Series device´s mounting slots 
        /// </summary>
        public List<int>? SlotsOnModel { get;  } = new();
    }
}