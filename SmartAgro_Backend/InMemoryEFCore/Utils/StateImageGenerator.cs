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
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Acre_in_Brazil.svg/300px-Acre_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1001,
                        nome = "AL",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Alagoas_in_Brazil.svg/300px-Alagoas_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1002,
                        nome = "AP",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Amapa_in_Brazil.svg/300px-Amapa_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1003,
                        nome = "AM",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Amazonas_in_Brazil.svg/300px-Amazonas_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1004,
                        nome = "BA",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Bahia_in_Brazil.svg/300px-Bahia_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1005,
                        nome = "CE",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Ceara_in_Brazil.svg/300px-Ceara_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1006,
                        nome = "DF",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9d/Distrito_Federal_in_Brazil.svg/300px-Distrito_Federal_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1007,
                        nome = "ES",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Espirito_Santo_in_Brazil.svg/300px-Espirito_Santo_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1008,
                        nome = "GO",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Goias_in_Brazil.svg/300px-Goias_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1009,
                        nome = "MA",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Maranhao_in_Brazil.svg/300px-Maranhao_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1010,
                        nome = "MT",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Mato_Grosso_in_Brazil.svg/300px-Mato_Grosso_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1011,
                        nome = "MS",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Mato_Grosso_do_Sul_in_Brazil.svg/300px-Mato_Grosso_do_Sul_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1012,
                        nome = "MG",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Minas_Gerais_in_Brazil.svg/300px-Minas_Gerais_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1013,
                        nome = "PA",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c0/Para_in_Brazil.svg/300px-Para_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1014,
                        nome = "PB",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Paraiba_in_Brazil.svg/300px-Paraiba_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1015,
                        nome = "PR",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/Parana_in_Brazil.svg/300px-Parana_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1016,
                        nome = "PE",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Pernambuco_in_Brazil.svg/300px-Pernambuco_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1017,
                        nome = "PI",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/Piaui_in_Brazil.svg/300px-Piaui_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1018,
                        nome = "RJ",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Rio_de_Janeiro_in_Brazil.svg/300px-Rio_de_Janeiro_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1019,
                        nome = "RN",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Rio_Grande_do_Norte_in_Brazil.svg/300px-Rio_Grande_do_Norte_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1020,
                        nome = "RS",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/Rio_Grande_do_Sul_in_Brazil.svg/300px-Rio_Grande_do_Sul_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1021,
                        nome = "RO",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/Rondonia_in_Brazil.svg/300px-Rondonia_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1022,
                        nome = "RR",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/be/Roraima_in_Brazil.svg/300px-Roraima_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1023,
                        nome = "SC",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a1/Santa_Catarina_in_Brazil.svg/300px-Santa_Catarina_in_Brazil.svg.png "
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
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Sergipe_in_Brazil.svg/300px-Sergipe_in_Brazil.svg.png"
                    },
                    new ImageModel()
                    {
                        id = 1026,
                        nome = "TO",
                        url = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Tocantins_in_Brazil.svg/300px-Tocantins_in_Brazil.svg.png"
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
                        id = 61,
                        nome = "Arroz",
                        url = "https://cdn.noticiasagricolas.com.br/dbimagens/6a676f00802645a8d39187ad991c8af8.JPG"
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
