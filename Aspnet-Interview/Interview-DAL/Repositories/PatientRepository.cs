using System.Threading.Tasks;
using Interview_DAL.POCO;

namespace Interview_DAL
{
    public class PatientRepository : BaseRepository, IPatientRepository
    {
        
        public async Task<PatientModel> GetSinglePatient(int id)
        {
            var spName = "GetPatient";
            return await ExecuteStoreProcedure(spName, new { Id = id });
        }
    }
}