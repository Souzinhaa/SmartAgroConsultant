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
    public class StateImageGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ImageDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<ImageDBContext>>()))
            {
                // Look for any points of interest already in database
                if (context.StateImage.Any())
                {
                    return; // Database has been seeded
                }

                context.StateImage.AddRange(
                    new ImageModel()
                    {
                        id = 1,
                        nome = "São Paulo",
                        url = "https://upload.wikimedia.org/wikipedia/commons/7/70/SP_Mock_1.png"
                    },
                    new ImageModel()
                    {
                        id = 2,
                        nome = "Minas Gerais",
                        url = "https://m.media-amazon.com/images/I/A1R-XuGlgdL._AC_SL1500_.jpg"
                    });

                context.CultivarsImage.AddRange(
                    new ImageModel()
                    {
                        id = 101,
                        nome = "Milho",
                        url = "https://www.infoescola.com/wp-content/uploads/2010/12/milho_616104491.jpg"
                    },
                    new ImageModel()
                    {
                        id = 102,
                        nome = "Soja",
                        url = "https://universo.agrogalaxy.com.br/wp-content/uploads/2021/09/conheca-o-ciclo-da-soja-em-dias-1-1300x1024.jpg"
                    },
                    new ImageModel()
                    {
                        id = 103,
                        nome = "Feijão",
                        url = "https://blog.aegro.com.br/wp-content/uploads/2020/04/plantio-de-feijao.jpg"
                    });

                context.SaveChanges();
            }
        }
    }
}
