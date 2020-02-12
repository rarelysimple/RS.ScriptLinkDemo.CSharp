using System;
using System.Data.Odbc;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        private DateTime SafeGetDateTime(string dateTimeString)
        {
            return SafeGetDateTime(dateTimeString, new DateTime());
        }

        private DateTime SafeGetDateTime(string dateTimeString, DateTime defaultValue)
        {
            if (DateTime.TryParse(dateTimeString, out DateTime dateTime))
                return dateTime;
            return defaultValue;
        }

        private DateTime SafeGetDateTime(OdbcDataReader reader, int column)
        {
            return SafeGetDateTime(reader, column, new DateTime());
        }

        private DateTime SafeGetDateTime(OdbcDataReader reader, int column, DateTime defaultValue)
        {
            try
            {
                if (reader.IsDBNull(column))
                {
                    logger.Debug("Reader column {column} is DbNull. Returning default value of {defaultValue}.", column, defaultValue);
                    return defaultValue;
                }
                else
                {
                    return SafeGetDateTime(reader.GetString(column), defaultValue);
                }
            }
            catch (Exception ex)
            {
                logger.Error("An unexpected error occurred while processing reader column {column}. Error: {errorMessage}", column, ex.Message);
                throw;
            }
        }

        private DateTime SafeGetDateTime(OdbcDataReader reader, string column)
        {
            return SafeGetDateTime(reader, column, new DateTime());
        }

        private DateTime SafeGetDateTime(OdbcDataReader reader, string column, DateTime defaultValue)
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
                    return SafeGetDateTime(reader.GetString(reader.GetOrdinal(column)), defaultValue);
                }
            }
            catch (Exception ex)
            {
                logger.Error("An unexpected error occurred while processing reader column {column}. Error: {errorMessage}", column, ex.Message);
                throw;
            }
        }
    }
}
