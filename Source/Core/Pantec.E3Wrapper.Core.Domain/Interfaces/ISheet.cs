using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;
using Pantec.E3Wrapper.Core.Domain.Models;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Sheet COM object
    /// </summary>
    public interface ISheet : IProxyProvider<E3SheetProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal, IE3Attributed
    {
        /// <summary>
        /// Check if sheet is offline (for multiuser project)
        /// </summary>
        /// <returns></returns>
        bool IsOffline();

        /// <summary>
        /// Checkout sheet in multiuser project
        /// </summary>
        /// <param name="mode">Checkout mode</param>
        /// <returns></returns>
        CheckOutResult CheckOut(CheckOutMode mode = CheckOutMode.ReadAndWrite);
    }
}