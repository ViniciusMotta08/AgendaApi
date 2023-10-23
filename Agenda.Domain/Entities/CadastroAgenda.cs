using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Domain.Entities
{
    [Table("[CadastroAgenda].[dbo].[Agenda]")]
    public class CadastroAgenda
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
    }
}