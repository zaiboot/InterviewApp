using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Interview_WebApi.Models;
using AutoMapper;
using Interview_DAL;


namespace Interview_WebApi.Controllers
{
    [RoutePrefix("api/patient")]
    public class PatientController : ApiController
    {
        private readonly IPatientRepository _patientRepository;


        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpPut]
        // PUT: api/Patient/5
        public void Create([FromBody]PatientModel patient)
        {

        }

        // GET: api/Patient/5
        [HttpGet]
        [Route("{id:int}")]
        public async Task<PatientModel> Get(int id)
        {

            return Mapper.Map<PatientModel>(await _patientRepository.GetSinglePatient(id));
        }

        // GET: api/Patient/
        [HttpGet]
        [Route("getall/{pageNumber:int}")]

        public async Task<IEnumerable<PatientModel>> GetAll(int pageNumber)
        {

            return Mapper.Map<IEnumerable<PatientModel>>(await _patientRepository.GetByPage(pageNumber));
        }



        // POST: api/Patient
        [HttpPost]
        public void Update([FromBody]PatientModel patient)
        {
        }




        // DELETE: api/Patient/5
        public void Delete(int id)
        {
        }

    }
}
