using ProjetoFinal.Dados;
using System;
using System.Linq;
using ProjetoFinal.Models;

namespace ProjetoFinal.Dados
{
    public static class DbInitializer
    {
        public static void Initialize(ProjetoContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Clientes.Any())
            {
                return;   // DB has been seeded
            }

            var Clientes = new Clientes[]
            {
                new Clientes{Nome="Jose",Sobrenome="Silva",ErrollementDate=DateTime.Parse("2005-09-01"), Email="jose.sila@gmail.com",Celular=999999999, CPF="11" },
                new Clientes{Nome="Marcos",Sobrenome="Silva",ErrollementDate=DateTime.Parse("2005-09-01"), Email="marcos.sila@gmail.com",Celular=999999999,CPF="22222222222" },
                new Clientes{Nome="Suzi",Sobrenome="Silva",ErrollementDate=DateTime.Parse("2005-09-01"), Email="suzi.sila@gmail.com",Celular=999999999,CPF="33333333333"},
            };
            foreach (Clientes c in Clientes)
            {
                context.Clientes.Add(c);
            }
            context.SaveChanges();

            var Produtos = new Produtos[]
            {
                new Produtos{Descricao="pistache",PrecoCusto=2.5F,Quantidade=3, PrecoVenda=5, Tipo="Comida"},
                new Produtos{Descricao="Vinho",PrecoCusto=520,Quantidade=15, PrecoVenda=7, Tipo="Bebida"},
                new Produtos{Descricao="Chiclete",PrecoCusto=0.5F,Quantidade=50, PrecoVenda=1.5F, Tipo="Doce"},

            };
            foreach (Produtos p in Produtos)
            {
                context.Produtos.Add(p);
            }
            context.SaveChanges();

            var Enderecos = new Enderecos[]
            {
            };
            new Enderecos { Logradouro = "Rua das Antas", Numero = "123", Bairro = "Vila Domingos", Cidade = "Vilas Boas", Estado = "PR", Pais = "Brasil", CEP = "86380000" };
            new Enderecos { Logradouro = "Rua das Antas", Numero = "123", Bairro = "Vila Domingos", Cidade = "Vilas Boas", Estado = "PR", Pais = "Brasil", CEP = "86380000" };
            new Enderecos { Logradouro = "Rua das Antas", Numero = "123", Bairro = "Vila Domingos", Cidade = "Vilas Boas", Estado = "PR", Pais = "Brasil", CEP = "86380000" };
            new Enderecos { Logradouro = "Rua das Antas", Numero = "123", Bairro = "Vila Domingos", Cidade = "Vilas Boas", Estado = "PR", Pais = "Brasil", CEP = "86380000" };
            new Enderecos { Logradouro = "Rua das Antas", Numero = "123", Bairro = "Vila Domingos", Cidade = "Vilas Boas", Estado = "PR", Pais = "Brasil", CEP = "86380000" };



            var Fornecedores = new Fornecedores[]
            {
            new Fornecedores{CNPJ=11111111, RazaoSocial="Silva & Silva LTDA", Email="silva.sila@gmail.com",Telefone=999999999,NomeFantasia="Flocos Sorvetes", InscricaoEstadual=123456},
            new Fornecedores{CNPJ=11111111, RazaoSocial="Roger & Santos LTDA", Email="roger.santos@gmail.com",Telefone=999999999,NomeFantasia="Chicletes SA", InscricaoEstadual=123456 },
            new Fornecedores{CNPJ=11111111, RazaoSocial="Steve & Silva LTDA", Email="silva.sila@gmail.com",Telefone=999999999,NomeFantasia="Flocos Sorvetes", InscricaoEstadual=123456},
            };
            foreach (Fornecedores f in Fornecedores)
            {
                context.Fornecedores.Add(f);
            }
            context.SaveChanges();
        }
    }   
}