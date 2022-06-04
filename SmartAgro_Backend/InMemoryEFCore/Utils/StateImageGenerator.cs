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
                        id = 1000,
                        nome = "AC",
                        url = ""
                    }, 
                    new ImageModel()
                    {
                        id = 1001,
                        nome = "AL",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1002,
                        nome = "AP",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1003,
                        nome = "AM",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1004,
                        nome = "BA",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1005,
                        nome = "CE",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1006,
                        nome = "DF",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1007,
                        nome = "ES",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1008,
                        nome = "GO",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1009,
                        nome = "MA",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1010,
                        nome = "MT",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1011,
                        nome = "MS",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1012,
                        nome = "MG",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1013,
                        nome = "PA",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1014,
                        nome = "PB",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1015,
                        nome = "PR",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1016,
                        nome = "PE",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1017,
                        nome = "PI",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1018,
                        nome = "RJ",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1019,
                        nome = "RN",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1020,
                        nome = "RS",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1021,
                        nome = "RO",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1022,
                        nome = "RR",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1023,
                        nome = "SC",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1024,
                        nome = "SP",
                        url = "https://upload.wikimedia.org/wikipedia/commons/7/70/SP_Mock_1.png"
                    },
                    new ImageModel()
                    {
                        id = 1025,
                        nome = "SE",
                        url = ""
                    },
                    new ImageModel()
                    {
                        id = 1026,
                        nome = "TO",
                        url = ""
                    });

                context.CultivarsImage.AddRange(
                    new ImageModel()
                    {
                        id = 56,
                        nome = "Milho",
                        url = "https://www.infoescola.com/wp-content/uploads/2010/12/milho_616104491.jpg"
                    },
                    new ImageModel()
                    {
                        id = 60,
                        nome = "Soja",
                        url = "https://universo.agrogalaxy.com.br/wp-content/uploads/2021/09/conheca-o-ciclo-da-soja-em-dias-1-1300x1024.jpg"
                    },
                    new ImageModel()
                    {
                        id = 62,
                        nome = "Feijão",
                        url = "https://blog.aegro.com.br/wp-content/uploads/2020/04/plantio-de-feijao.jpg"
                    },
                    new ImageModel()
                    {
                        id = 32533,
                        nome = "Trigo",
                        url = "https://diarural.com.br/wp-content/uploads/2021/08/trigo-1.jpg"
                    });

                context.SaveChanges();
            }
        }
    }
}
