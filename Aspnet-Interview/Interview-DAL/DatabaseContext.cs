using System.Data.Entity;

namespace Interview_DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("InterviewContext")
        {
            
        }

    }
}
