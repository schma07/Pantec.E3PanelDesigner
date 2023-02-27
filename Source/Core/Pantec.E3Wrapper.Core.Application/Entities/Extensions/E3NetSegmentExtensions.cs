using Pantec.E3Proxy;

namespace Pantec.E3Wrapper.Core.Application.Entities.Extensions
{
    public static class E3NetSegmentExtensions
    {
        /// <summary>
        /// Get nodes of net segment
        /// </summary>
        /// <param name="proxy">E3.series INetSegmentInterface COM proxy object</param>
        /// <returns>IEnumerable of ids or empty collection</returns>
        public static IEnumerable<int> GetNodeIdsEnumerable(this E3NetSegmentProxy proxy)
        {
            object nodeIds = null;
            proxy.GetNodeIds(ref nodeIds);

            return nodeIds.ToIEnumerable();
        }
    }
}