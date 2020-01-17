using Microsoft.VisualStudio.TestTools.UnitTesting;
using RS.ScriptLinkDemo.CSharp.Objects;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;
using RS.ScriptLinkDemo.CSharp.Soap.Factories;

namespace RS.ScriptLinkDemo.CSharp.Soap.Tests.Factories
{
    [TestClass]
    public class CommandSelectorTests
    {
        [TestMethod]
        public void GetCommand_EmptyParameter_ReturnsDefaultCommand()
        {
            // Arrange
            OptionObject2015 optionObject2015 = new OptionObject2015();
            string parameter = "";
            DefaultCommand expected = new DefaultCommand(optionObject2015, parameter);

            // Act
            IRunScriptCommand actual = CommandSelector.GetCommand(optionObject2015, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_HelloWorld_ReturnsHelloWorldCommand()
        {
            // Arrange
            OptionObject2015 optionObject2015 = new OptionObject2015();
            string parameter = "HelloWorld";
            HelloWorldCommand expected = new HelloWorldCommand(optionObject2015);

            // Act
            IRunScriptCommand actual = CommandSelector.GetCommand(optionObject2015, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}
