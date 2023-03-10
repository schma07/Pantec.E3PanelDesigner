using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Application.Entities.Base;
using Pantec.E3Wrapper.Core.Application.Entities.Extensions;
using Pantec.E3Wrapper.Core.Domain.Interfaces;
using Pantec.E3Wrapper.Core.Domain.Models;

namespace Pantec.E3Wrapper.Core.Application.Entities
{
    /// <inheritdoc cref="IDevice" />
    /// <summary>
    /// Implementation of IDevice interface
    /// </summary>
    public class E3Device : ProxyWrapperBase<E3DeviceProxy>, IDevice
    {
        public E3Device(E3Job job)
            : base(job, () => new E3DeviceProxy(job.Proxy.CreateDeviceObject()))
        {
        }


        /// <inheritdoc />
        public IEnumerable<IDevice> GetDevices(IDevice iterator, bool expandAll = false)
            => iterator.GetEnumerable(Proxy.GetDeviceIdsEnumerable(expandAll));

        /// <inheritdoc/>
        public IEnumerable<int> GetMountedSlotIds()
            => Proxy.GetMountedSlotIdsEnumerable();



        // <inheritdoc/>
        //public IEnumerable<IDevice> GetMountedSlots(IDevice iterator)
        //    => iterator.GetEnumerable(()=> GetMountedSlotIds());


        /// <inheritdoc />
        public int GetSymbolCountByPins(
        IPin pinIterator,
        ISheet sheetIterator,
        SymbolModeEnum mode = SymbolModeEnum.AllSymbols)
        {
            if (((IJob)Parent).IsMultiuserProject())
            {
                foreach (var sheet in GetPins(pinIterator)
                                      .Select(pin => pin.GetSheet(sheetIterator))
                                      .Where(sheet => sheet != null && sheet.IsOffline()))
                {
                    sheet.CheckOut(CheckOutMode.ReadOnly);
                }
            }

            return GetSymbolCount(mode);
        }

        /// <inheritdoc />
        public IEnumerable<ISymbol> GetSymbols(ISymbol iterator, SymbolModeEnum mode = SymbolModeEnum.AllSymbols)
            => iterator.GetEnumerable(() => GetSymbolIds(mode));

        /// <inheritdoc />
        public IEnumerable<int> GetSymbolIds(SymbolModeEnum mode = SymbolModeEnum.AllSymbols)
            => Proxy.GetSymbolIdsEnumerable(mode);

        /// <inheritdoc />
        public int GetSymbolCount(SymbolModeEnum mode = SymbolModeEnum.AllSymbols)
            => Proxy.GetSymbolCount((int)mode);

        /// <inheritdoc />
        public IEnumerable<IPin> GetPins(IPin iterator)
            => iterator.GetEnumerable(Proxy.GetPinIdsEnumerable);



        #region Implementation of IE3NamedReadonly

        /// <inheritdoc />
        public string GetName() => Proxy.GetName();

        #endregion

        #region Implementation of IE3Identificated

        /// <inheritdoc />
        public int GetId() => Proxy.GetId();

        /// <inheritdoc />
        public int SetId(int id) => Proxy.SetId(id);

        /// <inheritdoc />
        public int Id
        {
            get => GetId();
            set => SetId(value);
        }

        #endregion

        #region Implementation of IE3Named

        /// <inheritdoc />
        public bool SetName(string name) => Proxy.SetName(name).CastToBool();

        /// <inheritdoc />
        public string Name
        {
            get => GetName();
            set => Proxy.SetName(value);
        }

        #endregion

        #region Implementation of IE3IdentificatedGlobal

        /// <inheritdoc />
        public string GlobalId => GetGlobalId();

        /// <inheritdoc />
        public string GetGlobalId() => ((IJob)Parent).GetGidOfId(Id);

        /// <inheritdoc />
        public int SetId(string globalId) => Proxy.SetId(((IJob)Parent).GetIdOfGid(globalId));

        #endregion

        #region Implementation of IE3Attributed

        /// <inheritdoc />
        public bool HasAttribute(string attributeName) => Proxy.HasAttribute(attributeName).CastToBool();

        /// <inheritdoc />
        public string GetAttributeValue(string attributeName) => Proxy.GetAttributeValue(attributeName);

        /// <inheritdoc />
        public int SetAttributeValue(string attributeName, string attributeValue) => Proxy.SetAttributeValue(attributeName, attributeValue);

        /// <inheritdoc />
        public IEnumerable<int> GetAttributeIds() => Proxy.GetAttributeIdsEnumerable();

        /// <inheritdoc />
        public IEnumerable<IAttribute> GetAttributes(IAttribute iterator) => iterator.GetEnumerable(GetAttributeIds);

        /// <inheritdoc />
        public IEnumerable<IAttribute> GetAttributes(IAttribute iterator, string attributeName) =>
            GetAttributes(iterator)
                .Where(a => a.CheckName(attributeName));

        /// <inheritdoc />
        public int DeleteAttribute(string attributeName) => Proxy.DeleteAttribute(attributeName);

        #endregion

        #region Implementration of IE3PanelLocation

        /// <inheritdoc/>
        public bool SetPanelLocationStruct(PanelLocationStruct panelLocation) => Proxy.SetPanelLocationStruct(panelLocation);

        /// <inheritdoc/>
        public PanelLocationStruct? PanelLocation
        {
            get => GetPanelLocationStruct();
            set => Proxy.SetPanelLocationStruct(value);
        }

        /// <inheritdoc/>
        public string? ModelName => Proxy.GetModelName();

        public IEnumerable<int> GetMountedSlotIdsEnumerable(IDevice iterator) => Proxy.GetMountedSlotIdsEnumerable();

        /// <inheritdoc />
        public PanelLocationStruct? GetPanelLocationStruct() => Proxy.GetPanelLocationStruct();

        /// <inheritdoc/>
        public bool IsModelPlaced() => Proxy.ModelIsPlaced();

        /// <inheritdoc/>
        public string GetModelName() => Proxy.GetModelName();


        #endregion

        #region Additional properties and methods for aggregates

        ///<inheritdoc/>
        public bool IsAssembly() => Proxy.IsAssembly().CastToBool();

        ///<inheritdoc/>
        public bool IsAssemblyPart() => Proxy.IsAssemblyPart().CastToBool();

        ///<inheritdoc/>
        public int GetParentAssemblyId() => Proxy.GetAssemblyId();

        ///<inheritdoc/>
        public string GetParentAssemblyName() => Proxy.GetParentAssemblyName();
        
        /// <inheritdoc/>
        public IEnumerable<int> GetDeviceIdsEnumerable(IDevice iterator, bool expandAll) => Proxy.GetDeviceIdsEnumerable(expandAll);  


        #endregion

    }
}