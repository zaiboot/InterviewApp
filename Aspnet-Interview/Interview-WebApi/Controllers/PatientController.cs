using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Interview_WebApi.Models;
using AutoMapper;
using Interview_DAL;


namespace Interview_WebApi.Controllers
{
    public class PatientController : ApiController
    {
        // GET: api/Patient
        //public IEnumerable<PatientModel> Get()
        //{
        //    return new List<PatientModel>
        //    {
        //       CreatePatient(),
        //       CreatePatient()
        //       CreatePatient()

        //    };
        //}

      

        [HttpPut]
        // PUT: api/Patient/5
        public void Create([FromBody]PatientModel patient)
        {

        }

        // GET: api/Patient/5
        public async Task<PatientModel> Get(int id)
        {
            IPatientRepository patientRepository = new PatientRepository();
           
            return Mapper.Map<PatientModel>(await patientRepository.GetSinglePatient(id)) ;
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

        private PatientModel CreatePatient()
        {
            return  new PatientModel()
            {
                

            };
        }
    }
}
