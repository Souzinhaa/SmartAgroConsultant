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
            using (var context = new StateImageDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<StateImageDBContext>>()))
            {
                // Look for any points of interest already in database
                if (context.StateImage.Any())
                {
                    return; // Database has been seeded
                }

                context.StateImage.AddRange(
                    new StateImageModel()
                    {
                        id = 1,
                        nome = "São Paulo",
                        url = "https://upload.wikimedia.org/wikipedia/commons/7/70/SP_Mock_1.png"
                    },
                    new StateImageModel()
                    {
                        id = 2,
                        nome = "Minas Gerais",
                        url = "https://m.media-amazon.com/images/I/A1R-XuGlgdL._AC_SL1500_.jpg"
                    });

                context.SaveChanges();
            }
        }
    }
}
