using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Fornecedores
    {
        public int ID { get; set; }
        public string RazaoSocial { get; set; }
        public int CNPJ { get; set; }
        public int InscricaoEstadual { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }

        public ICollection<Enrollments> Enrollments { get; set; }

    }
}
