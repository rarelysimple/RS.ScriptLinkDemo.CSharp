using Microsoft.VisualStudio.TestTools.UnitTesting;
using RS.ScriptLinkDemo.CSharp.Soap.Factories;

namespace RS.ScriptLinkDemo.CSharp.Soap.Tests.Factories
{
    [TestClass]
    public class ConnectionStringSelectorTests
    {
        [TestMethod]
        public void GetConnectionStringName_Facility1_ReturnsAVPM()
        {
            // Arrange
            string namespaceName = "AVPM";
            string facility = "1";
            string expected = "ODBCAVPM";

            // Act
            string actual = ConnectionStringSelector.GetConnectionStringName(namespaceName, facility);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetConnectionStringName_Facility1_ReturnsAVCWS()
        {
            // Arrange
            string namespaceName = "AVCWS";
            string facility = "1";
            string expected = "ODBCAVCWS";

            // Act
            string actual = ConnectionStringSelector.GetConnectionStringName(namespaceName, facility);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetConnectionStringName_Facility1_ReturnsAVMSO()
        {
            // Arrange
            string namespaceName = "AVMSO";
            string facility = "1";
            string expected = "ODBCAVMSO";

            // Act
            string actual = ConnectionStringSelector.GetConnectionStringName(namespaceName, facility);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetConnectionStringName_Facility2_ReturnsAVPM()
        {
            // Arrange
            string namespaceName = "AVPM";
            string facility = "2";
            string expected = "ODBCAVPM2";

            // Act
            string actual = ConnectionStringSelector.GetConnectionStringName(namespaceName, facility);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetConnectionStringName_Facility2_ReturnsAVCWS()
        {
            // Arrange
            string namespaceName = "AVCWS";
            string facility = "2";
            string expected = "ODBCAVCWS2";

            // Act
            string actual = ConnectionStringSelector.GetConnectionStringName(namespaceName, facility);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetConnectionStringName_Facility2_ReturnsAVMSO()
        {
            // Arrange
            string namespaceName = "AVMSO";
            string facility = "2";
            string expected = "ODBCAVMSO2";

            // Act
            string actual = ConnectionStringSelector.GetConnectionStringName(namespaceName, facility);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
