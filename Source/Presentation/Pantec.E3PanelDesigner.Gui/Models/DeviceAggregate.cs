using Pantec.E3Wrapper.ApplicationSelection.Gui.Interop;
using Pantec.E3Wrapper.Core.Application.Entities.Extensions;
using Pantec.E3Wrapper.Core.Domain.Interfaces;
using Pantec.E3Wrapper.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantec.E3Wrapper.ApplicationSelection.Gui.Models
{
    /// <summary>
    /// Aggregate for working with devices
    /// </summary>
    public class DeviceAggregate
    {
        /// <summary>
        /// E3.Series device id
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// E3.Series device name
        /// </summary>
        public string Name { get; set; }
        // <summary>
        /// E3.Series device is assembly
        /// </summary>
        public bool IsAssembly { get; }

        /// <summary>
        /// E3.Series device is part of assembly
        /// </summary>
        public bool IsAssemblyPart { get; }
        /// <summary>
        /// E3.Series device id of parent assembly
        /// </summary>
        public int ParentAssemblyId { get; }
        /// <summary>
        /// E3.Series device name of parent assembly
        /// </summary>
        public string ParentAssemblyName { get; }

        /// <summary>
        /// Panel model placement coordinates for target option/variant configuration
        /// </summary>
        public PanelLocationStruct? TargetPanelLocation { get; }

        public List<KeyValuePair<int, string>> AssemblySubDevices { get; set; } = new();

        /// <inheritdoc/>
        public ModelAggregate Model { get; set; }

        public DeviceAggregate(IDevice device)
        {
            this.Id = device.Id;
            this.Name = device.Name;
            this.IsAssembly = device.IsAssembly();
            this.IsAssemblyPart = device.IsAssemblyPart();
            this.ParentAssemblyId = device.GetParentAssemblyId();
            this.ParentAssemblyName = device.GetParentAssemblyName();

            this.Model = new(device);

            
        }

        public DeviceAggregate(IDevice device, ISlot slot) : this(device)
        {
            this.Model = new(device, slot);
        }       
        
    }
}

