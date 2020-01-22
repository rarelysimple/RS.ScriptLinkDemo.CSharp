using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RS.ScriptLinkDemo.CSharp.Data.Repositories;
using RS.ScriptLinkDemo.CSharp.Objects;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;

namespace RS.ScriptLinkDemo.CSharp.Soap.Tests.Commands
{
    [TestClass]
    public class GetOdbcDataCommandTests
    {
        [TestMethod]
        public void Execute_GetOdbcDataCommand_ReturnsOptionObject2015()
        {
            // Arrange
            OptionObject2015 expected = new OptionObject2015();

            OptionObject2015 optionObject2015 = new OptionObject2015()
            {
                EntityID = "12345",
                Facility = "1"
            };
            var repository = new Mock<IGetDataRepository>();
            repository.Setup(p => p.GetPatientCountOfOpenEpisodesByPatientId(optionObject2015.Facility, optionObject2015.EntityID)).Returns(3);
            var command = new GetOdbcDataCommand(optionObject2015, repository.Object);

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}
