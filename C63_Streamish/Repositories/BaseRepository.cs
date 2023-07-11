using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace C63_Streamish.Repositories
{
    //abstract indicates this class can only be used by inheritance
    //cannot be directly instantiated
    public abstract class BaseRepository
    {
        private readonly string _connectionString;

        public BaseRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        //protected makes this property available to child classes,
        //but inaccessible to any other code.
        protected SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }
    }
}
