using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RS.ScriptLinkDemo.CSharp.Data.Models;
using RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;
using RS.ScriptLinkDemo.CSharp.Soap.Factories;
using RS.ScriptLinkDemo.CSharp.Soap.Services.Smtp;

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
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject2015);
            IParameter parameter = new Parameter("");
            DefaultCommand expected = new DefaultCommand(optionObjectDecorator, parameter);

            // Act
            IRunScriptCommand actual = CommandSelector.GetCommand(optionObject2015, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_GetOdbcData_ReturnsGetOdbcDataCommand()
        {
            // Arrange
            OptionObject2015 optionObject2015 = new OptionObject2015();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject2015);
            IParameter parameter = new Parameter("GetOdbcData");
            ConnectionStringCollection connectionStringCollection = new ConnectionStringCollection("", "", "");
            var repository = new GetOdbcDataRepository(connectionStringCollection);
            GetOdbcDataCommand expected = new GetOdbcDataCommand(optionObjectDecorator, repository);

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
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject2015);
            IParameter parameter = new Parameter("HelloWorld");
            HelloWorldCommand expected = new HelloWorldCommand(optionObjectDecorator);

            // Act
            IRunScriptCommand actual = CommandSelector.GetCommand(optionObject2015, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_SendEmail_ReturnsSendEmailCommand()
        {
            // Arrange
            OptionObject2015 optionObject2015 = new OptionObject2015();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject2015);
            IParameter parameter = new Parameter("SendEmail");
            var smtpService = new SmtpService();
            SendEmailCommand expected = new SendEmailCommand(optionObjectDecorator, smtpService);

            // Act
            IRunScriptCommand actual = CommandSelector.GetCommand(optionObject2015, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_SetFieldValue_ReturnsSetFieldValueCommand()
        {
            // Arrange
            OptionObject2015 optionObject2015 = new OptionObject2015();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject2015);
            IParameter parameter = new Parameter("SetFieldValue");
            SetFieldValueCommand expected = new SetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            IRunScriptCommand actual = CommandSelector.GetCommand(optionObject2015, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}
