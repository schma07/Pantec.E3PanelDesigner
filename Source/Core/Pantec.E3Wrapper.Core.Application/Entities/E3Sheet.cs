using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Application.Entities.Base;
using Pantec.E3Wrapper.Core.Application.Entities.Extensions;
using Pantec.E3Wrapper.Core.Domain.Interfaces;
using Pantec.E3Wrapper.Core.Domain.Models;

namespace Pantec.E3Wrapper.Core.Application.Entities
{
    /// <inheritdoc cref="ISheet" />
    /// <summary>
    /// Implementation of ISheet interface
    /// </summary>
    public class E3Sheet : ProxyWrapperBase<E3SheetProxy>, ISheet
    {
        public E3Sheet(E3Job job)
            : base(job, () => new E3SheetProxy(job.Proxy.CreateSheetObject()))
        {
        }

        /// <inheritdoc />
        public bool IsOffline()
            => Proxy.IsOffline() == 1;

        /// <inheritdoc />
        public CheckOutResult CheckOut(CheckOutMode mode = CheckOutMode.ReadAndWrite)
            => (CheckOutResult)Proxy.CheckOut((int)mode);

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

        #region Implementation of IE3NamedReadonly

        /// <inheritdoc />
        public string GetName() => Proxy.GetName();

        #endregion

        #region Implementation of IE3Named

        /// <inheritdoc />
        public bool SetName(string name) => Proxy.SetName(name) == GetName();

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
    }
}