using Pantec.E3Wrapper.Core.Domain.Models;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy
{
    public interface IE3SchemaLocation
    {
        /// <summary>
        /// Check for object is placed on the sheet
        /// </summary>
        /// <returns></returns>
        bool IsPlaced();

        /// <summary>
        /// Get coordinates of object on the sheet. Null if not placed
        /// </summary>
        /// <returns></returns>
        SchemaLocationStruct? GetSchemaLocationStruct();
    }
}