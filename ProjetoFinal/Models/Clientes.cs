using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Clientes
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public int InscricaoEstadual { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        public DateTime ErrollementDate { get; set; }

        public Enderecos Endereco { get; set; }
        

        public ICollection<Enrollments> Enrollments { get; set; }
    }
}   