using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Models;
using System.Runtime.CompilerServices;

namespace Pantec.E3Wrapper.Core.Application.Entities.Extensions
{
    public static class E3DeviceExtensions
    {
        public static string GetParentAssemblyName(this E3DeviceProxy device)
        {
            var oldId = device.GetId();
            device.SetId(device.GetAssemblyId());

            var parentAssemblyName = device.GetName();

            device.SetId(oldId);
            return parentAssemblyName;
        }


        /// <summary>
        /// Get assembly's child devices (with sub-devices)
        /// </summary>
        /// <param name="device">E3.series IDeviceInterface COM object</param>
        /// <param name="expandAll"><c>true</c> - with sub-devices, <c>false</c> - only top-level of child devices</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetDeviceIdsEnumerable(this E3DeviceProxy device, bool expandAll)
        {
            if (device.GetDeviceCount() == 0)
                return new int[] { };

            object devIds = null;
            device.GetDeviceIds(ref devIds);

            if (!expandAll)
                return devIds.ToIEnumerable();

            var ret = new List<int>();
            foreach (var id in devIds.ToIEnumerable())
            {
                device.SetId(id);

                if (device.IsAssembly() == 1)
                    ret.AddRange(device.GetDeviceIdsEnumerable(true));
                else
                    ret.Add(id);
            }

            return ret;
        }

        /// <summary>
        /// Get mounted slot ids for device
        /// </summary>
        /// <param name="device">E3.series IDeviceInterface COM object</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetMountedSlotIdsEnumerable(this E3DeviceProxy device)
        {
            object slotIds = null;
            device.GetMountedSlotIds(ref slotIds);
            return slotIds.ToIEnumerable();
        }

        /// <summary>
        /// Get pin ids for device
        /// </summary>
        /// <param name="device">E3.series IDeviceInterface COM object</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetPinIdsEnumerable(this E3DeviceProxy device)
        {
            if (device.GetPinCount() == 0)
                return new int[] { };

            object pinIds = null;
            device.GetPinIds(ref pinIds);

            return pinIds.ToIEnumerable();
        }

        /// <summary>
        /// Get symbol ids for device
        /// </summary>
        /// <param name="device">E3.series IDeviceInterface COM object</param>
        /// <param name="mode">Symbol type</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetSymbolIdsEnumerable(
            this E3DeviceProxy device,
            SymbolModeEnum mode = SymbolModeEnum.AllSymbols)
        {
            if (device.GetSymbolCount((int)mode) == 0)
                return new int[] { };

            object symIds = null;
            device.GetSymbolIds(ref symIds, (int)mode);

            return symIds.ToIEnumerable();
        }

        /// <summary>
        /// Get panel location for device
        /// </summary>
        /// <param name="device">E3.series IDeviceInterface COM object</param>
        /// <returns>Panel location struct or null if not placed</returns>
        public static PanelLocationStruct? GetPanelLocationStruct(this E3DeviceProxy device)
        {
            int shtid = device.GetPanelLocation(out var x, out var y, out var z, out var rot);
            if (shtid == 0)
                return null;

            return new PanelLocationStruct((double)x, (double)y, (double)z, rot as string); // rot as string
        }

        /// <summary>
        /// Check for model is placed on the sheet
        /// </summary>
        /// <param name="proxy">E3.series IInterface COM proxy object</param>
        /// <returns></returns>
        public static bool ModelIsPlaced(this E3DeviceProxy proxy) => proxy.GetPanelLocationStruct().HasValue;

        /// <summary>
        /// Set panel location for device
        /// </summary>
        /// <param name="device">E3.series IDeviceInterface COM object</param>
        /// <returns>1 if successful or 0 if not placed/Error</returns>
        public static bool SetPanelLocationStruct(this E3DeviceProxy device, PanelLocationStruct? panelLocation)
        {
            try
            {
                device.SetPanelLocation(1, 100, panelLocation.Value.X, panelLocation.Value.Y, panelLocation.Value.Z, panelLocation.Value.Rotation, 0, 0, 0).CastToBool();
                return true;
            }
            catch { return false; }
        }
    }
}