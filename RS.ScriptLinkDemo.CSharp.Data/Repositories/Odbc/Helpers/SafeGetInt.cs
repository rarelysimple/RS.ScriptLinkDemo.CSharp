using System;
using System.Data.Odbc;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        private int SafeGetInt(string intString)
        {
            return SafeGetInt(intString, 0);
        }

        private int SafeGetInt(string intString, int defaultValue)
        {
            if (int.TryParse(intString, out int returnInt))
                return returnInt;
            return defaultValue;
        }

        private int SafeGetInt(OdbcDataReader reader, int column)
        {
            return SafeGetInt(reader, column, 0);
        }

        private int SafeGetInt(OdbcDataReader reader, int column, int defaultValue)
        {
            try
            {
                if (reader.IsDBNull(column))
                {
                    logger.Debug("GetClientCombinedAssessmentInfoByPatientId: Reader column {column} is DbNull. Returning default value of {defaultValue}.", column, defaultValue);
                    return defaultValue;
                }
                else
                {
                    return reader.GetInt32(column);
                }
            }
            catch (InvalidCastException ex)
            {
                string columnValue = reader.GetString(column);
                logger.Info(ex, "Could not cast column {column} value {value} as Int32. returning default value of {defaultValue}.", column, columnValue, defaultValue);
                return defaultValue;
            }
            catch (Exception ex)
            {
                logger.Error("An unexpected error occurred while processing reader column {column}. Error: {errorMessage}", column, ex.Message);
                throw;
            }
        }

        private int SafeGetInt(OdbcDataReader reader, string column)
        {
            return SafeGetInt(reader, column, 0);
        }

        private int SafeGetInt(OdbcDataReader reader, string column, int defaultValue)
        {
            try
            {
                if (reader.IsDBNull(reader.GetOrdinal(column)))
                {
                    logger.Debug("Reader column {column} is DbNull. Returning default value of {defaultValue}.", column, defaultValue);
                    return defaultValue;
                }
                else
                {
                    return reader.GetInt32(reader.GetOrdinal(column));
                }
            }
            catch (InvalidCastException ex)
            {
                string columnValue = reader.GetString(reader.GetOrdinal(column));
                logger.Info(ex, "Could not cast column {column} value {value} as Int32. returning default value of {defaultValue}.", column, columnValue, defaultValue);
                return defaultValue;
            }
            catch (Exception ex)
            {
                logger.Error("An unexpected error occurred while processing reader column {column}. Error: {errorMessage}", column, ex.Message);
                throw;
            }
        }
    }
}
