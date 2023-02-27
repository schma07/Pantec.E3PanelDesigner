using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
	public sealed class E3FunctionalPortProxy : E3ProxyBase
    {
        public E3FunctionalPortProxy(object comObject) : base(comObject)
        {
        }

        public int Create(int fuId, string name)
        {
            return ComObject.Create(fuId, name);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int GetConnectedPorts(ref object ids)
        {
            return ComObject.GetConnectedPorts(ids);
        }

        public string GetConnectorName()
        {
            return ComObject.GetConnectorName();
        }

        public int GetConnectorPinID()
        {
            return ComObject.GetConnectorPinID();
        }

        public int GetFunctionalUnitId()
        {
            return ComObject.GetFunctionalUnitId();
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetNodeID()
        {
            return ComObject.GetNodeID();
        }

        public int GetPinID()
        {
            return ComObject.GetPinID();
        }

        public string GetPinName()
        {
            return ComObject.GetPinName();
        }

        public int GetPortType()
        {
            return ComObject.GetPortType();
        }

        public int GetSignalEquiv()
        {
            return ComObject.GetSignalEquiv();
        }

        public int GetSignalEqvPorts(ref object ids)
        {
            return ComObject.GetSignalEqvPorts(ids);
        }

        public string GetSignalName()
        {
            return ComObject.GetSignalName();
        }

        public string GetTranslatedSignalName()
        {
            return ComObject.GetTranslatedSignalName();
        }

        public int GetUserDefined()
        {
            return ComObject.GetUserDefined();
        }

        public string SetConnectorName(string name)
        {
            return ComObject.SetConnectorName(name);
        }

        public int SetConnectorPinID(int id)
        {
            return ComObject.SetConnectorPinID(id);
        }

        public string SetGID(string gid)
        {
            return ComObject.SetGID(gid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }

        public int SetNodeId(int id)
        {
            return ComObject.SetNodeId(id);
        }

        public int SetPinID(int id)
        {
            return ComObject.SetPinID(id);
        }

        public string SetPinName(string name)
        {
            return ComObject.SetPinName(name);
        }

        public int SetPortType(int type)
        {
            return ComObject.SetPortType(type);
        }

        public int SetSignalEquiv(int signalequiv)
        {
            return ComObject.SetSignalEquiv(signalequiv);
        }

        public int SetSignalName(string name)
        {
            return ComObject.SetSignalName(name);
        }

        public int SetUserDefined(int type = 1)
        {
            return ComObject.SetUserDefined(type);
        }
    }
}