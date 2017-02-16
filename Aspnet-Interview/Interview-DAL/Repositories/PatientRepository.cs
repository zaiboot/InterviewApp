using System.Collections.Generic;
using System.Threading.Tasks;
using Interview_DAL.POCO;

namespace Interview_DAL
{
    public class PatientRepository : BaseRepository, IPatientRepository
    {
        
        
        public async Task<PatientModel> GetSinglePatient(int id)
        {
            var spName = "GetPatient";
            return await GetFirstOrDefault(spName, new { Id = id });
        }

        public async Task<IEnumerable<PatientModel>> GetByPage(int pageNumber)
        {
            var spName = "GetAllPatients";
            return await Query(spName, new { pageNumber = pageNumber });
        }
    }
}