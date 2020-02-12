using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Objects;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;
using System.Collections.Generic;

namespace RS.ScriptLinkDemo.CSharp.Soap.Tests.Commands
{
    [TestClass]
    public class SetFieldValueCommandTests
    {
        [TestMethod]
        public void Execute_EnabledEmpty_ReturnsEnabledEmpty()
        {
            // Arrange
            FieldObject fieldObject = new FieldObject()
            { 
                Enabled = "",
                FieldNumber = "123",
                FieldValue = "",
                Lock = "",
                Required = ""
            };
            RowObject rowObject = new RowObject()
            {
                Fields = new List<FieldObject>()
                { 
                    fieldObject 
                },
                RowId = "1||1"
            };
            FormObject formObject = new FormObject()
            {
                CurrentRow = rowObject,
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject2015 = new OptionObject2015()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };
            string expected = "";
            var command = new SetFieldValueCommand(optionObject2015, "SetFieldValue,123,New Field Value");

            // Act
            OptionObject2015 optionObject = command.Execute();
            string actual = optionObject.Forms[0].CurrentRow.Fields[0].Enabled;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
