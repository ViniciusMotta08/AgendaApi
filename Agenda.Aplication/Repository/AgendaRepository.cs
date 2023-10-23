using Agenda.Aplication.Interfaces;
using Agenda.Domain.Entities;
using Agenda.Infra.Data;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;

namespace Agenda.Aplication.Repository
{
    public class AgendaRepository : IAgendaRepository
    {
        private IDbConnection conn;

        public AgendaRepository(IDbConnection conn)
        {
            this.conn = conn;
        }


        //DapperContrib
        public List<CadastroAgenda> FindAll()
        {
            return conn.GetAll<CadastroAgenda>().ToList();
        }

        //Read
        public CadastroAgenda Get(int id)
        {
            return conn.Get<CadastroAgenda>(id);
        }

        //Insert
        public long Create(CadastroAgenda cadastroAgenda)
        {
            return conn.Insert(cadastroAgenda);
        }

        //Update
        public void Update(CadastroAgenda cadastroAgenda)
        {
            conn.Update(cadastroAgenda);
        }

        //Delete
        public void Delete(CadastroAgenda item)
        {
            conn.Delete(item);
        }
    }
}

//public async Task<List<CadastroAgenda>> GetAllAsync()
//{
//    using (var conn = _db.Connection)
//    {
//        string query = "SELECT * FROM CadastroAgenda";
//        List<CadastroAgenda> agenda = (await conn.QueryAsync<CadastroAgenda>(sql: query)).ToList();
//        return agenda;
//    }
//}
//
//Dapper
//public async Task<CadastroAgenda> GetIdAsync(int id)
//{
//    using (var conn = _db.Connection)
//    {
//        string query = "SELECT * FROM CadastroAgenda WHERE Id = @id";                 
//        var result = await conn.QueryFirstOrDefaultAsync<CadastroAgenda>
//            (sql: query, param: new { id });
//        return result;
//    }
//}

//public async Task<int> CreateAsync(CadastroAgenda agenda)
//{
//    using (var conn = _db.Connection)
//    {
//        string query = @"INSERT INTO CadastroAgenda(Id, Name, Email, Telefone)
//                         VALUES(@Id, @Name, @Email, @Telefone)";

//        var result = await conn.ExecuteAsync(sql: query, param: agenda);
//        return result;
//    }
//}

//public async Task<int> UpdateAsync(CadastroAgenda agenda)
//{
//    using (var conn = _db.Connection)
//    {
//        string query = @"UPDATE CadastroAgenda SET Name = @Name, Email = @Email, Telefone = @Telefone
//                         WHERE Id = @Id";

//        var result = await conn.ExecuteAsync(sql: query, param: agenda);
//        return result;
//    }
//}

//public async Task<int> DeleteAsync(int id)
//{
//    using (var conn = _db.Connection)
//    {
//        string query = @"DELETE FROM CadastroAgenda WHERE Id = @id";
//        var result = await conn.ExecuteAsync(sql: query, param: new { id });
//        return result;
//    }
//}