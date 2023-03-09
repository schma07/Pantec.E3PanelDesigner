using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Slot COM object
    /// </summary>
    public interface ISlot : IProxyProvider<E3SlotProxy>,
        IE3Identificated, IE3NamedReadonly, IE3IdentificatedGlobal
    {
        /// <summary>
        /// MountType of device´s model
        /// </summary>
        string MountType { get; }

        /// <summary>
        /// Get device´s model mounting slot type
        /// </summary>
        /// <returns></returns>
        string GetMountType();
    }
}