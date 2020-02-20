using NLog;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RS.ScriptLinkDemo.CSharp.Data.Repositories;
using System;
using System.Data.Odbc;

namespace RS.ScriptLinkDemo.CSharp.Soap.Commands
{
    public class GetOdbcDataCommand : IRunScriptCommand
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IOptionObjectDecorator _optionObject;
        private readonly IGetDataRepository _repository;

        public GetOdbcDataCommand(IOptionObjectDecorator optionObject, IGetDataRepository repository)
        {
            _optionObject = optionObject;
            _repository = repository;
        }

        public IOptionObject2015 Execute()
        {
            double errorCode = 0;
            string errorMesg;
            try
            {
                int episodeCount = _repository.GetPatientCountOfOpenEpisodesByPatientId(_optionObject.Facility, _optionObject.EntityID);
                logger.Debug("The ODBC call successfully retrieved this value {value}.", episodeCount);
                errorMesg = "The ODBC call was successful.";
            }
            catch (OdbcException ex)
            {
                logger.Error(ex, "Could not connect to the ODBC Data Source. See ODBC Data log for more detail.");
                errorCode = 3;
                errorMesg = "Could not connect to the ODBC Data Source. See the ODBC Data log on the web server for more detail.";
            }
            catch (Exception ex)
            {
                logger.Error(ex, "An unexpected error occurred when attempting to get the ODBC data. See ODBC Data log for more detail.");
                throw;
            }

            return _optionObject.ToReturnOptionObject(errorCode, errorMesg);
        }
    }
}