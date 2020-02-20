using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;
using RS.ScriptLinkDemo.CSharp.Soap.Services.Smtp;

namespace RS.ScriptLinkDemo.CSharp.Soap.Tests.Commands
{
    [TestClass]
    public class SendEmailCommandTests
    {
        [TestMethod]
        public void Execute_SendEmailCommand_ReturnsOptionObject2015()
        {
            // Arrange
            OptionObject2015 expected = new OptionObject2015();

            OptionObject2015 optionObject2015 = new OptionObject2015();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject2015);
            var messageService = new Mock<ISmtpService>();
            var command = new SendEmailCommand(optionObjectDecorator, messageService.Object);

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}
