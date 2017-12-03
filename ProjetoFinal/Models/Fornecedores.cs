using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Fornecedores
    {
        public string RazaoSocial { get; set; }
        public int CNPJ { get; set; }
        public int InscricaoEstadual { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }

        public Enderecos Endereco { get; set; }

        public ICollection<Errollments> Errollements { get; set; }
}
}
