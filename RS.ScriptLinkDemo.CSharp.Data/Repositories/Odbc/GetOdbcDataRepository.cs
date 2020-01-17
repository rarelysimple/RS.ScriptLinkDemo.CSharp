using NLog;
using RS.ScriptLinkDemo.CSharp.Data.Models;
using System;
using System.Data.Odbc;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository : IGetDataRepository
    {
        #region Private Properties

        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly ConnectionStringCollection _connectionStringCollection;

        #endregion

        #region Constructors

        public GetOdbcDataRepository(ConnectionStringCollection connectionStringCollection)
        {
            _connectionStringCollection = connectionStringCollection;
        }

        #endregion

        #region Private Methods

        private bool GetPatientBool(string connectionString, string commandString, string facility, string patientId, double episodeNumber)
        {
            string stringResult = "";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcCommand command = new OdbcCommand(commandString, connection);
                command.Parameters.Add(new OdbcParameter("FACILITY", facility));
                command.Parameters.Add(new OdbcParameter("PATID", patientId));
                command.Parameters.Add(new OdbcParameter("EPISODENUMBER", episodeNumber));

                try
                {
                    connection.Open();
                    stringResult = command.ExecuteScalarAsync().ToString();
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "GetPatientBool failed.");
                }
            }

            return SafeGetBool(stringResult);
        }
        private DateTime GetPatientDateTime(string connectionString, string commandString, string facility, string patientId)
        {
            string stringResult = "";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcCommand command = new OdbcCommand(commandString, connection);
                command.Parameters.Add(new OdbcParameter("FACILITY", facility));
                command.Parameters.Add(new OdbcParameter("PATID", patientId));

                try
                {
                    connection.Open();
                    stringResult = command.ExecuteScalarAsync().ToString();
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "GetPatientDateTime failed.");
                }
            }

            return SafeGetDateTime(stringResult);
        }
        private DateTime GetPatientDateTime(string connectionString, string commandString, string facility, string patientId, double episodeNumber)
        {
            string stringResult = "";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcCommand command = new OdbcCommand(commandString, connection);
                command.Parameters.Add(new OdbcParameter("FACILITY", facility));
                command.Parameters.Add(new OdbcParameter("PATID", patientId));
                command.Parameters.Add(new OdbcParameter("EPISODENUMBER", episodeNumber));

                try
                {
                    connection.Open();
                    stringResult = command.ExecuteScalarAsync().ToString();
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "GetPatientDateTime failed.");
                }
            }

            return SafeGetDateTime(stringResult);
        }
        private int GetPatientInt(string connectionString, string commandString, string facility, string patientId)
        {
            string stringResult = "";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcCommand command = new OdbcCommand(commandString, connection);
                command.Parameters.Add(new OdbcParameter("FACILITY", facility));
                command.Parameters.Add(new OdbcParameter("PATID", patientId));

                try
                {
                    connection.Open();
                    stringResult = command.ExecuteScalarAsync().ToString();
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "GetPatientInt failed.");
                }
            }

            return SafeGetInt(stringResult);
        }
        private int GetPatientInt(string connectionString, string commandString, string facility, string patientId, double episodeNumber)
        {
            string stringResult = "";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcCommand command = new OdbcCommand(commandString, connection);
                command.Parameters.Add(new OdbcParameter("FACILITY", facility));
                command.Parameters.Add(new OdbcParameter("PATID", patientId));
                command.Parameters.Add(new OdbcParameter("EPISODENUMBER", episodeNumber));

                try
                {
                    connection.Open();
                    stringResult = command.ExecuteScalarAsync().ToString();
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "GetPatientInt failed.");
                }
            }

            return SafeGetInt(stringResult);
        }

        private string GetPatientString(string connectionString, string commandString, string facility, string patientId)
        {
            string stringResult = "";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcCommand command = new OdbcCommand(commandString, connection);
                command.Parameters.Add(new OdbcParameter("FACILITY", facility));
                command.Parameters.Add(new OdbcParameter("PATID", patientId));

                try
                {
                    connection.Open();
                    stringResult = command.ExecuteScalarAsync().ToString();
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "GetPatientString failed.");
                }
            }

            return stringResult;
        }
        private string GetPatientString(string connectionString, string commandString, string facility, string patientId, double episodeNumber)
        {
            string stringResult = "";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcCommand command = new OdbcCommand(commandString, connection);
                command.Parameters.Add(new OdbcParameter("FACILITY", facility));
                command.Parameters.Add(new OdbcParameter("PATID", patientId));
                command.Parameters.Add(new OdbcParameter("EPISODENUMBER", episodeNumber));

                try
                {
                    connection.Open();
                    stringResult = command.ExecuteScalarAsync().ToString();
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "GetPatientString failed.");
                }
            }

            return stringResult;
        }

        private string GetStaffString(string connectionString, string commandString, string facility, string staffId)
        {
            string stringResult = "";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcCommand command = new OdbcCommand(commandString, connection);
                command.Parameters.Add(new OdbcParameter("FACILITY", facility));
                command.Parameters.Add(new OdbcParameter("STAFFID", staffId));

                try
                {
                    connection.Open();
                    stringResult = command.ExecuteScalarAsync().ToString();
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "GetPatientBool failed.");
                }
            }

            return stringResult;
        }
        private bool SafeGetBool(string boolString)
        {
            switch (boolString)
            {
                case "1":
                case "Y":
                case "true":
                    return true;
                default:
                    return false;
            }

        }

        private DateTime SafeGetDateTime(string dateTimeString)
        {
            if (DateTime.TryParse(dateTimeString, out DateTime dateTime))
                return dateTime;
            return new DateTime();

        }

        private int SafeGetInt(string intString)
        {
            if (int.TryParse(intString, out int returnInt))
                return returnInt;
            return 0;
        }

        #endregion
    }
}
