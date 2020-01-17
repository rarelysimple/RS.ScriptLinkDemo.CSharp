using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories
{
    public interface IGetDataRepository
    {
        DateTime GetPatientAdmissionDateByEpisodeNumber(string facility, string patientId, double episodeNumber);
        int GetPatientCountOfOpenEpisodesByPatientId(string facility, string patientId);
        DateTime GetPatientDateOfBirthByPatientId(string facility, string patientId);
        DateTime GetPatientDischargeDateByEpisodeNumber(string facility, string patientId, double episodeNumber);
        string GetPatientNameByPatientId(string facility, string patientId);
        string GetStaffNameByStaffId(string facility, string staffId);

        bool HasAdmissionDiagnosisByEpisodeNumber(string facility, string patientId, double episodeNumber);
        bool HasDischargeDiagnosisByEpisodeNumber(string facility, string patientId, double episodeNumber);
    }
}
