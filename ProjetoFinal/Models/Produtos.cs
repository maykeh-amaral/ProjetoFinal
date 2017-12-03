﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Produtos
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public float PrecoCusto { get; set; }
        public float PrecoVenda { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; }
        public DateTime ErrollementDate { get; set; }
        


        public Fornecedores Fornecedor { get; set; }

        public ICollection<Errollement> Errollements { get; set; }
    }
}