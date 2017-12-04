using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Enrollments
    {
        public int ID { get; set; }
        public int CLienteID { get; set; }
        public int FornecedorID { get; set; }
        public int UsuarioID { get; set; }

        public Clientes Clientes { get; set; }
        public Fornecedores Fornecedores { get; set; }
        public Produtos Produtos { get; set; }
    }
}
