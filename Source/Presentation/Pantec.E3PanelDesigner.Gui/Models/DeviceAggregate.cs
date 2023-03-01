using Pantec.E3Wrapper.ApplicationSelection.Gui.Interop;
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

        /// <summary>
        /// E3.Series device´s model name
        /// </summary>
        public string ModelName { get; set; }

        /// <summary>
        /// Current panel model placement coordinates
        /// </summary>
        public PanelLocationStruct SourcePanelLocation { get; set; }

        /// <summary>
        /// Panel model placement coordinates for active option/variant visability
        /// </summary>
        public PanelLocationStruct TargetPanelLocation { get; set; }


        public DeviceAggregate(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
