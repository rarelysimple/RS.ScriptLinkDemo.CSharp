using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;

namespace RS.ScriptLinkDemo.CSharp.Soap.Tests.Commands
{
    [TestClass]
    public class DefaultCommandTests
    {
        [TestMethod]
        public void Execute_DefaultCommand_ReturnsOptionObject2015()
        {
            // Arrange
            OptionObject2015 expected = new OptionObject2015();

            OptionObject2015 optionObject = new OptionObject2015();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("");
            var command = new DefaultCommand(optionObjectDecorator, parameter);

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void Execute_DefaultCommand_ErrorCodeEquals3()
        {
            // Arrange
            double expected = 3;

            OptionObject2015 optionObject = new OptionObject2015();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("");
            var command = new DefaultCommand(optionObjectDecorator, parameter);

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected, actual.ErrorCode);
        }
    }
}
