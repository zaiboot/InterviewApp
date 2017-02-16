using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using Interview_DAL.POCO;

namespace Interview_DAL
{
    public abstract class BaseRepository
    {
        //private const string CONNECTION_STRING =
        //    @"Initial Catalog=Aspnet-Interview-Database;Data Source=(localdb)\ProjectsV13;Integrated Security=True;Persist Security Info=False;Pooling=False;Asynchronous Processing=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";

        public string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;}
        }

        protected async Task<PatientModel> GetFirstOrDefault(string spName, object parameters)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                await conn.OpenAsync();

                return await conn.QueryFirstOrDefaultAsync<PatientModel>(spName, parameters, null, null,
                    CommandType.StoredProcedure);
            }
        }


        protected async Task<IEnumerable<PatientModel>> Query(string spName, object parameters)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                await conn.OpenAsync();

                return await conn.QueryAsync<PatientModel>(spName, parameters, null, null,
                    CommandType.StoredProcedure);
            }
        }
    }
}