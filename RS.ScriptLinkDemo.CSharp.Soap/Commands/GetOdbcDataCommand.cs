using NLog;
using RS.ScriptLinkDemo.CSharp.Data.Repositories;
using RS.ScriptLinkDemo.CSharp.Objects;
using System;
using System.Data.Odbc;

namespace RS.ScriptLinkDemo.CSharp.Soap.Commands
{
    public class GetOdbcDataCommand : IRunScriptCommand
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly OptionObject2015 _optionObject2015;
        private readonly IGetDataRepository _repository;

        public GetOdbcDataCommand(OptionObject2015 optionObject2015, IGetDataRepository repository)
        {
            _optionObject2015 = optionObject2015;
            _repository = repository;
        }

        public OptionObject2015 Execute()
        {
            double errorCode = 0;
            string errorMesg;
            try
            {
                int episodeCount = _repository.GetPatientCountOfOpenEpisodesByPatientId(_optionObject2015.Facility, _optionObject2015.EntityID);
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

            return new OptionObject2015()
            {
                EntityID = _optionObject2015.EntityID,
                EpisodeNumber = _optionObject2015.EpisodeNumber,
                ErrorCode = errorCode,
                ErrorMesg = errorMesg,
                Facility = _optionObject2015.Facility,
                NamespaceName = _optionObject2015.NamespaceName,
                OptionId = _optionObject2015.OptionId,
                OptionStaffId = _optionObject2015.OptionStaffId,
                OptionUserId = _optionObject2015.OptionUserId,
                ParentNamespace = _optionObject2015.ParentNamespace,
                ServerName = _optionObject2015.ServerName,
                SystemCode = _optionObject2015.SystemCode,
                SessionToken = _optionObject2015.SessionToken
            };
        }
    }
}