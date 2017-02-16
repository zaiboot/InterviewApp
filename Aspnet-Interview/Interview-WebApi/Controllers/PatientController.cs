using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Interview_DAL.Repositories;
using Interview_WebApi.Models;
using AutoMapper;


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
        public PatientModel Get(int id)
        {
            var patientRepository = new PatientRepository();
           
            return Mapper.Map<PatientModel>(patientRepository.GetSinglePatient()) ;
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
