using System;
using System.Data.Odbc;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        private bool SafeGetBool(string boolString)
        {
            return SafeGetBool(boolString, false);
        }

        private bool SafeGetBool(string boolString, bool defaultValue)
        {
            switch (boolString.ToUpperInvariant())
            {
                case "0":
                case "FALSE":
                case "N":
                case "NO":
                    return false;
                case "1":
                case "TRUE":
                case "Y":
                case "YES":
                    return true;
                default:
                    return defaultValue;
            }
        }

        private bool SafeGetBool(OdbcDataReader reader, int column)
        {
            return SafeGetBool(reader, column, false);
        }

        private bool SafeGetBool(OdbcDataReader reader, int column, bool defaultValue)
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
                    return SafeGetBool(reader.GetString(column), defaultValue);
                }
            }
            catch (Exception ex)
            {
                logger.Error("An unexpected error occurred while processing reader column {column}. Error: {errorMessage}", column, ex.Message);
                throw;
            }
        }

        private bool SafeGetBool(OdbcDataReader reader, string column)
        {
            return SafeGetBool(reader, column, false);
        }

        private bool SafeGetBool(OdbcDataReader reader, string column, bool defaultValue)
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
                    return SafeGetBool(reader.GetString(reader.GetOrdinal(column)), defaultValue);
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
