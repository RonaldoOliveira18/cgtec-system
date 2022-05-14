using SQLite;
using System.ComponentModel.DataAnnotations;

namespace cgtec_system.Models
{
    public class Cliente
    {


        [PrimaryKey]
        public int Id { get; set; }
        [Display(Name = "Nome Cliente")]
        public string NomeCliente { get; set; }
        [Display(Name = "Endereço Cliente")]
        public string EnderecoCliente { get; set; }
        [Display(Name = "Contato Cliente")]
        public string ContatoCliente { get; set; }
        [Display(Name = "Contato Cliente 2")]
        public string Contato2Cliente { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
    }
}
