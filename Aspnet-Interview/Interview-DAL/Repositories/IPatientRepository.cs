using System.Collections.Generic;
using System.Threading.Tasks;
using Interview_DAL.POCO;

namespace Interview_DAL
{
    public interface IPatientRepository
    {
        Task<PatientModel> GetSinglePatient(int id);
        Task<IEnumerable<PatientModel>> GetByPage(int pageNumber);
    }
}