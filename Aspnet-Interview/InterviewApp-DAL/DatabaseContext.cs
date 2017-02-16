using System.Data.Entity;

namespace InterviewApp_DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("InterviewContext")
        {
            
        }

    }
}
