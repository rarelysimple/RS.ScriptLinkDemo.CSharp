using System.Collections.Generic;

namespace RS.ScriptLinkDemo.CSharp.Objects
{
    public class FormObject
    {
        public RowObject CurrentRow { get; set; }
        public string FormId { get; set; }
        public bool MultipleIteration { get; set; }
        public List<RowObject> OtherRows { get; set; }
    }
}
