using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemoryEFCore.DataContext;
using InMemoryEFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InMemoryEFCore.Utils
{
    public class UserGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UserLoginDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<UserLoginDBContext>>()))
            {
                // Look for any points of interest already in database
                if (context.UserLogin.Any())
                {
                    return; // Database has been seeded
                }

                context.UserLogin.AddRange(
                    new UserLoginModel()
                    {
                        id = 1,
                        name = "fecorba",
                        senha = "corbahomi"
                    },
                    new UserLoginModel()
                    {
                        id = 2,
                        name = "hyanvin",
                        senha = "hyangay"
                    });

                context.UserDef.AddRange(
                    new UserDefModel()
                    {
                        id = 1,
                        nome = "Felipe Corbanezi",
                        email = "felipecorbanezi@alunos.fho.edu.br",
                        visibilidade = true,
                        login = false
                    },
                    new UserDefModel()
                    {
                        id = 2,
                        nome = "hyanvin",
                        email = "hyan@alunos.fho.edu.br",
                        visibilidade = false,
                        login = false
                    });

                context.FarmUser.AddRange(
                    new FarmModel()
                    {
                        id = 1,
                        userId = 1,
                        hectares = 10,
                        localizacao = "41.40338, 2.17403",
                        tipoSolo = "Arenoso"
                    },
                    new FarmModel()
                    {
                        id = 2,
                        userId = 2,
                        hectares = 15,
                        localizacao = "44.032338, 12.17403",
                        tipoSolo = "Úmido"
                    });

                context.SaveChanges();
            }
        }
    }
}
