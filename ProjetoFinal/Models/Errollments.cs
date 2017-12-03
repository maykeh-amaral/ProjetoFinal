using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Errollments
    {
        public int EnrollmentID { get; set; }
        public int ClienteID { get; set; }
        public int ProdutoID { get; set; }
        public int FornecedorID { get; set; }
        public string Tipo { get; set; }

        public Enderecos Endereco { get; set; }
        public Clientes Cliente { get; set; }
        public Produtos Produto { get; set; }
        public Fornecedores Fornecedor { get; set; }


    }
}
