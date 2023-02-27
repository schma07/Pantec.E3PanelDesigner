using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Application.Entities.Base;
using Pantec.E3Wrapper.Core.Domain.Interfaces;

namespace Pantec.E3Wrapper.Core.Application.Entities
{
    /// <inheritdoc cref="IBinData" />
    /// <summary>
    /// Implementation of IBinData interface
    /// </summary>
    public class E3BinData : ProxyWrapperBase<E3BinDataProxy>, IBinData
    {
        public E3BinData(E3Job job)
            : base(job, () => new E3BinDataProxy(job.Proxy.CreateBinDataObject()))
        {
        }
    }
}