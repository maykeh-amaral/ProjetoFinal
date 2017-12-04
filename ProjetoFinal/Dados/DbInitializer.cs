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

        }
    }
}