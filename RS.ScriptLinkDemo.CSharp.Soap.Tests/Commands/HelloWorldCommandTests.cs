using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Objects;
//using RS.ScriptLinkDemo.CSharp.Objects;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;

namespace RS.ScriptLinkDemo.CSharp.Soap.Tests.Commands
{
    [TestClass]
    public class HelloWorldCommandTests
    {
        [TestMethod]
        public void Execute_HelloWorldCommand_ReturnsOptionObject2015()
        {
            // Arrange
            OptionObject2015 expected = new OptionObject2015();

            OptionObject2015 optionObject2015 = new OptionObject2015();
            var command = new HelloWorldCommand(optionObject2015);

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void Execute_HelloWorldCommand_ErrorCodeEquals3()
        {
            // Arrange
            double expected = 3;

            OptionObject2015 optionObject2015 = new OptionObject2015();
            var command = new HelloWorldCommand(optionObject2015);

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected, actual.ErrorCode);
        }
    }
}
