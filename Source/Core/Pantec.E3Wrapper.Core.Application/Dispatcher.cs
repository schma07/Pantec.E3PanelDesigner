using Pantec.E3Proxy.Interop;
using System.Runtime.InteropServices.ComTypes;

namespace Pantec.E3Wrapper.Core.Application
{
    /// <summary>
    /// Class-dispatcher of running E3.series COM objects
    /// </summary>
    public static class Dispatcher
    {
        /// <summary>
        /// Get IEnumerable
        /// </summary>
        /// <returns></returns>
        [STAThread]
        public static IDictionary<int, object> GetRunningE3SeriesApplications()
        {
            var dict = new Dictionary<int, object>();
            var monikers = new IMoniker[1];

            WindowsApi.CreateBindCtx(0, out var ctx);

            ctx.GetRunningObjectTable(out var runningObjectTable);
            runningObjectTable.EnumRunning(out var monikerEnumerator);
            monikerEnumerator.Reset();

            while (monikerEnumerator.Next(1, monikers, IntPtr.Zero) == 0)
            {
                monikers[0].GetDisplayName(ctx, null, out var runningObjectName);

                if (!runningObjectName.StartsWith("!E3Application", StringComparison.InvariantCultureIgnoreCase))
                    continue;

                int index = runningObjectName.IndexOf(':');
                if (index == -1) continue;

                runningObjectTable.GetObject(monikers[0], out var runningObjectVal);

                dict.Add(int.Parse(runningObjectName.Substring(index + 1)), runningObjectVal);
            }

            return dict;
        }
    }
}
