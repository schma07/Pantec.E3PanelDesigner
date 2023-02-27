using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantec.E3PanelDesigner.Extensions
{
    /// <summary>
    /// Extension methods for IEnumerable
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Applies the specified changes to the collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection">Collection.</param>
        /// <param name="predicate">The predicate.</param>
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> predicate)
        {
            foreach (var item in collection)
                predicate(item);
        }
    }
}
