using Pantec.E3Proxy;
using Pantec.E3Proxy.Extensions;
using Pantec.E3Wrapper.Core.Domain.Interfaces;
using System.Runtime.CompilerServices;

namespace Pantec.E3Wrapper.Core.Application.Entities.Extensions
{
    public static class E3JobExtensions
    {
        /// <summary>
        /// Get project's devices id (with sub-devices)
        /// </summary>
        /// <param name="job">E3.series IJobInterface COM object</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetAllDeviceIdsEnumerable(this E3JobProxy job)
        {
            if (job.GetDeviceCount() == 0)
                return new int[] { };

            object devIds = null;
            job.GetAllDeviceIds(ref devIds);

            return devIds.ToIEnumerable();
        }
        

        /// <summary>
        /// Get ids of selected net segments in current E3.series project
        /// </summary>
        /// <param name="proxy">E3.series IJobInterface COM proxy object</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetSelectedNetSegmentIdsEnumerable(this E3JobProxy proxy)
        {
            if (proxy.GetSelectedNetSegmentCount() == 0)
                return new int[] { };

            object nsIds = null;
            proxy.GetSelectedNetSegmentIds(ref nsIds);

            return nsIds.ToIEnumerable();
        }
    }
}