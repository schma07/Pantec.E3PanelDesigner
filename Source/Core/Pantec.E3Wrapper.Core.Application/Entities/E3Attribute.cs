using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Application.Entities.Base;
using Pantec.E3Wrapper.Core.Application.Entities.Extensions;
using Pantec.E3Wrapper.Core.Domain.Interfaces;

namespace Pantec.E3Wrapper.Core.Application.Entities
{
    /// <inheritdoc cref="IAttribute" />
    /// <summary>
    /// Implementation of IAttribute interface
    /// </summary>
    public class E3Attribute : ProxyWrapperBase<E3AttributeProxy>, IAttribute
    {
        public E3Attribute(E3Job job)
            : base(job, () => new E3AttributeProxy(job.Proxy.CreateAttributeObject()))
        {
        }

        /// <inheritdoc />
        public string GetInternalName() => Proxy.GetInternalName();

        /// <inheritdoc />
        public bool CheckName(string name) =>
            name.EqualsIgnoreCase(GetInternalName()) || name.EqualsIgnoreCase(GetName());

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

        #region Implementation of IE3IdentificatedGlobal

        /// <inheritdoc />
        public string GlobalId => GetGlobalId();

        /// <inheritdoc />
        public string GetGlobalId() => ((IJob)Parent).GetGidOfId(Id);

        /// <inheritdoc />
        public int SetId(string globalId) => Proxy.SetId(((IJob)Parent).GetIdOfGid(globalId));

        #endregion
    }
}