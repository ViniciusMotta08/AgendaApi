using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Agenda.Infra.Data
{
    public class DbSession : IDisposable
    {
        public IDbConnection Connection { get; set; }

        public DbSession(IConfiguration configuration)
        {
            string c = configuration.GetConnectionString("DevAgenda");
            Connection = new SqlConnection(c);
            //Connection.Open();
        }
        public void Dispose() => Connection?.Dispose();
    }
}