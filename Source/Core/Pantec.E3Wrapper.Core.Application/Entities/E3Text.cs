using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Application.Entities.Base;
using Pantec.E3Wrapper.Core.Application.Entities.Extensions;
using Pantec.E3Wrapper.Core.Domain.Interfaces;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;
using Pantec.E3Wrapper.Core.Domain.Models;

namespace Pantec.E3Wrapper.Core.Application.Entities
{
    /// <inheritdoc cref="IText" />
    /// <summary>
    /// Implementation of IText interface
    /// </summary>
    public class E3Text : ProxyWrapperBase<E3TextProxy>, IText
    {
        public E3Text(E3Job job)
            : base(job, () => new E3TextProxy(job.Proxy.CreateTextObject()))
        {
        }

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

        #region Implementation of IE3IdentificatedGlobal

        /// <inheritdoc />
        public string GlobalId => GetGlobalId();

        E3NetProxy IProxyProvider<E3NetProxy>.Proxy => throw new NotImplementedException();

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

        #region Implementation of IE3SchemaLocation

        /// <inheritdoc />
        public bool IsPlaced() => Proxy.IsPlaced();

        /// <inheritdoc />
        public SchemaLocationStruct? GetSchemaLocationStruct() => Proxy.GetSchemaLocationStruct();

        #endregion
    }
}