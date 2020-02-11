﻿using System;
using System.Data.Odbc;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
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
                    stringResult = (string)command.ExecuteScalar();
                }
                catch (OdbcException ex)
                {
                    logger.Error(ex, "GetPatientBool: Could not connect to ODBC data source. See error message. Data Source: {systemDsn}. Error: {errorMessage}", connectionString, ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "GetPatientBool: An unexpected error occurred. Error Type: {errorType}. Error: {errorMessage}", ex.GetType(), ex.Message);
                    throw;
                }
            }

            return SafeGetBool(stringResult);
        }
    }
}
