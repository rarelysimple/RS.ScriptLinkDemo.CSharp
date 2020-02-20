using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
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
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject2015);
            IParameter parameter = new Parameter("SetFieldValue,123,New Field Value");
            string expected = "";
            var command = new SetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2015 optionObject = (OptionObject2015)command.Execute();
            string actual = optionObject.Forms[0].CurrentRow.Fields[0].Enabled;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
