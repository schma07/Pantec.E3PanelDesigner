using Pantec.E3Proxy.Interfaces;
using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3FieldProxy : E3ProxyBase, IAttributed
    {

        public E3FieldProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int GetAllInsideFieldIds(ref object ids)
        {
            return ComObject.GetAllInsideFieldIds(ids);
        }

        public int GetArea(ref object xMin, ref object yMin, ref object xMax, ref object yMax)
        {
            return ComObject.GetArea(xMin, yMin, xMax, yMax);
        }

        public int GetAssignedOptionExpressions(ref object expressions, int Term = 0)
        {
            return ComObject.GetAssignedOptionExpressions(expressions, Term);
        }

        public int GetAssignedOptionExpressionsEx(ref object expressions, int Term = 0)
        {
            return ComObject.GetAssignedOptionExpressionsEx(expressions, Term);
        }

        public int GetAttributeCount()
        {
            return ComObject.GetAttributeCount();
        }

        public int GetAttributeIds(ref object ids, string attnam = default(string))
        {
            return ComObject.GetAttributeIds(ids, attnam);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetCrossingFieldIds(ref object ids)
        {
            return ComObject.GetCrossingFieldIds(ids);
        }

        public int GetCrossingNetSegmentIds(ref object ids)
        {
            return ComObject.GetCrossingNetSegmentIds(ids);
        }

        public int GetCrossingPanelConnectionIds(ref object ids)
        {
            return ComObject.GetCrossingPanelConnectionIds(ids);
        }

        public string GetDeviceAssignment()
        {
            return ComObject.GetDeviceAssignment();
        }

        public string GetDeviceLocation()
        {
            return ComObject.GetDeviceLocation();
        }

        public string GetDeviceName()
        {
            return ComObject.GetDeviceName();
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public int GetGraphId()
        {
            return ComObject.GetGraphId();
        }

        public string GetGUID()
        {
            return ComObject.GetGUID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetInsideFieldIds(ref object ids)
        {
            return ComObject.GetInsideFieldIds(ids);
        }

        public int GetInsideGraphIds(ref object ids)
        {
            return ComObject.GetInsideGraphIds(ids);
        }

        public int GetInsideNetSegmentIds(ref object ids)
        {
            return ComObject.GetInsideNetSegmentIds(ids);
        }

        public int GetInsidePanelConnectionIds(ref object ids)
        {
            return ComObject.GetInsidePanelConnectionIds(ids);
        }

        public int GetInsideSymbolIds(ref object ids)
        {
            return ComObject.GetInsideSymbolIds(ids);
        }

        public int GetInsideTextIds(ref object ids)
        {
            return ComObject.GetInsideTextIds(ids);
        }

        public int GetInterruptBorder()
        {
            return ComObject.GetInterruptBorder();
        }

        public double GetInterruptBorderGap()
        {
            return ComObject.GetInterruptBorderGap();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetParentFieldId()
        {
            return ComObject.GetParentFieldId();
        }

        public int GetSchemaLocation(ref object x, ref object y, ref object grid)
        {
            return ComObject.GetSchemaLocation(x, y, grid);
        }

        public int GetSchemaLocation(ref object x, ref object y, ref object grid, ref object column_value)
        {
            return ComObject.GetSchemaLocation(x, y, grid, column_value);
        }

        public int GetSchemaLocation(ref object x, ref object y, ref object grid, ref object column_value, ref object row_value)
        {
            return ComObject.GetSchemaLocation(x, y, grid, column_value, row_value);
        }

        public int GetSymbolCount()
        {
            return ComObject.GetSymbolCount();
        }

        public int GetSymbolIds(ref object ids)
        {
            return ComObject.GetSymbolIds(ids);
        }

        public int GetTextCount()
        {
            return ComObject.GetTextCount();
        }

        public int GetTextIds(ref object ids, int txttyp = default(int), string search_string = "")
        {
            return ComObject.GetTextIds(ids, txttyp, search_string);
        }

        public string GetType()
        {
            return ComObject.GetType();
        }

        public string GetTypeName()
        {
            return ComObject.GetTypeName();
        }

        public string GetVersion()
        {
            return ComObject.GetVersion();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int Jump()
        {
            return ComObject.Jump();
        }

        public int Place(int shti, double x1, double y1, double x2, double y2, int moveall = default(int))
        {
            return ComObject.Place(shti, x1, y1, x2, y2, moveall);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetCompleteName(string newdev, string newass, string newloc, int onlygiven = 0)
        {
            return ComObject.SetCompleteName(newdev, newass, newloc, onlygiven);
        }

        public int SetDeviceAssignment(string newass)
        {
            return ComObject.SetDeviceAssignment(newass);
        }

        public int SetDeviceLocation(string newloc)
        {
            return ComObject.SetDeviceLocation(newloc);
        }

        public int SetDeviceName(string newdev)
        {
            return ComObject.SetDeviceName(newdev);
        }

        public string SetGID(string gid)
        {
            return ComObject.SetGID(gid);
        }

        public string SetGUID(string guid)
        {
            return ComObject.SetGUID(guid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetInterruptBorder(int interrupt)
        {
            return ComObject.SetInterruptBorder(interrupt);
        }

        public double SetInterruptBorderGap(double gap)
        {
            return ComObject.SetInterruptBorderGap(gap);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }

        public int SetOptionExpressions(ref object expressions)
        {
            return ComObject.SetOptionExpressions(expressions);
        }
    }
}