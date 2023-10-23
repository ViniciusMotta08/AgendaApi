using Agenda.Domain.Entities;

namespace Agenda.Aplication.Interfaces
{
    public interface IAgendaRepository
    {
        List<CadastroAgenda> FindAll();
        CadastroAgenda Get(int id);
        long Create(CadastroAgenda cadastroAgenda);
        void Update(CadastroAgenda agenda);
        void Delete(CadastroAgenda item);


        //Task<List<CadastroAgenda>> GetAllAsync();
        //Task<CadastroAgenda> GetIdAsync(int id);
        //Task<int> CreateAsync(CadastroAgenda agenda);
        //Task<int> UpdateAsync(CadastroAgenda agenda);
        //Task<int> DeleteAsync(int id);
    }
}