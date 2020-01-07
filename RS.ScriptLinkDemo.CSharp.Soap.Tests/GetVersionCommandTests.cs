using Microsoft.VisualStudio.TestTools.UnitTesting;
using RS.ScriptLinkDemo.CSharp.Objects;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;

namespace RS.ScriptLinkDemo.CSharp.Soap.Tests
{
    [TestClass]
    public class GetVersionCommandTests
    {
        [TestMethod]
        public void Execute_OptionObject_ReturnsString()
        {
            // Arrange
            string expected = "";
            IGetVersionCommand command = new GetVersionCommand(typeof(OptionObject));

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void Execute_OptionObject2_ReturnsString()
        {
            // Arrange
            string expected = "";
            IGetVersionCommand command = new GetVersionCommand(typeof(OptionObject2));

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void Execute_OptionObject2015_ReturnsString()
        {
            // Arrange
            string expected = "";
            IGetVersionCommand command = new GetVersionCommand(typeof(OptionObject2015));

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void Execute_String_ReturnsString()
        {
            // Arrange
            string expected = "";
            IGetVersionCommand command = new GetVersionCommand(typeof(string));

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}
