namespace Pantec.E3Proxy.Extensions
{
    public static class E3ArraysExtensions
    {
        /// <summary>
        /// Cast E3.series arrays packed in object to IEnumerable
        /// </summary>
        /// <param name="obj">E3.series array packed in object</param>
        /// <returns>IEnumerable</returns>
        public static IEnumerable<T> ToIEnumerable<T>(this object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (!(obj is object[] array))
                throw new InvalidCastException("Object is not an array object[]");

            return array.Where(o => o != null).Cast<T>();
        }

        /// <summary>
        /// Cast E3.series integer arrays packed in object to IEnumerable
        /// </summary>
        /// <param name="obj">E3.series array packed in object</param>
        /// <returns>IEnumerable of int</returns>
        public static IEnumerable<int> ToIEnumerable(this object obj)
        {
            return obj.ToIEnumerable<int>();
        }
    }
}