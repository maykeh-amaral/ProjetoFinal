using ProjetoFinal.Dados;
using System;
using System.Linq;
using ProjetoFinal.Models;

namespace ContosoUniversity.Data
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
            new Clientes{Nome="Jose",Sobrenome="Silva",ErrollementDate=DateTime.Parse("2005-09-01"), Email="jose.sila@gmail.com",Celular="999999999",CPF="11111111111" },
            new Clientes{Nome="Marcos",Sobrenome="Silva",ErrollementDate=DateTime.Parse("2005-09-01"), Email="marcos.sila@gmail.com",Celular="999999999",CPF="22222222222" },
            new Clientes{Nome="Suzi",Sobrenome="Silva",ErrollementDate=DateTime.Parse("2005-09-01"), Email="suzi.sila@gmail.com",Celular="999999999",CPF="33333333333" },
            };
            foreach (Clientes c in Clientes)
            {
                context.Clientes.Add(s);
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

            var Errollments= new Errollments[]
            {
            new Errollments{ClienteID=1,Endereco="",Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}