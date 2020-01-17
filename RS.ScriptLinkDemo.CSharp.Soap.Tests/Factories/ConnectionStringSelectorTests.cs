using Microsoft.VisualStudio.TestTools.UnitTesting;
using RS.ScriptLinkDemo.CSharp.Soap.Factories;

namespace RS.ScriptLinkDemo.CSharp.Soap.Tests.Factories
{
    [TestClass]
    public class ConnectionStringSelectorTests
    {
        [TestMethod]
        public void GetConnectionStringName_ReturnsAVPM()
        {
            // Arrange
            string namespaceName = "AVPM";
            string expected = "ODBCAVPM";

            // Act
            string actual = ConnectionStringSelector.GetConnectionStringName(namespaceName);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetConnectionStringName_ReturnsAVCWS()
        {
            // Arrange
            string namespaceName = "AVCWS";
            string expected = "ODBCAVCWS";

            // Act
            string actual = ConnectionStringSelector.GetConnectionStringName(namespaceName);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetConnectionStringName_ReturnsAVMSO()
        {
            // Arrange
            string namespaceName = "AVMSO";
            string expected = "ODBCAVMSO";

            // Act
            string actual = ConnectionStringSelector.GetConnectionStringName(namespaceName);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
