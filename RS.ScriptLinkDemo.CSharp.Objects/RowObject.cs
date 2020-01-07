using System.Collections.Generic;

namespace RS.ScriptLinkDemo.CSharp.Objects
{
    public class RowObject
    {
        public List<FieldObject> Fields { get; set; }
        public string ParentRowId { get; set; }
        public string RowAction { get; set; }
        public string RowId { get; set; }
    }
}
