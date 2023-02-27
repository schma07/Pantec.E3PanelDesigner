using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3AttributeDefinitionProxy : E3ProxyBase
	{
        
        public E3AttributeDefinitionProxy(object comObject) : base(comObject)
        {

        }

        public int Create(string name, ref object attributeDefinition)
        {
            return ComObject.Create(name, ref attributeDefinition);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int Get(out object attributeDefinition)
        {
            return ComObject.Get(out attributeDefinition);
        }

        public int GetFromDatabase(out object attributeDefinitions)
        {
            return ComObject.GetFromDatabase(out attributeDefinitions);
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetInternalName()
        {
            return ComObject.GetInternalName();
        }

        public string GetName(int languageId = 0)
        {
            return ComObject.GetName(languageId);
        }

        public int Search(string name)
        {
            return ComObject.Search(name);
        }

        public int @set(ref object attributeDefinition)
        {
            return ComObject.@set(ref attributeDefinition);
        }

        public string SetGID(string gid)
        {
            return ComObject.SetGID(gid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetName(int languageId, string newname)
        {
            return ComObject.SetName(languageId, newname);
        }

        public int Update(int flags)
        {
            return ComObject.Update(flags);
        }

    }
}