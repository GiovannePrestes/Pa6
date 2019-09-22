using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ControlePatrimonios.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ControlePatrimoniosContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ControlePatrimoniosContext>>()))
            {
                // Look for any movies.
                if (context.TbSetor.Any())
                {
                    return;   // DB has been seeded
                }

                context.TbSetor.AddRange(
                    new TbSetor
                    {
                        IdSetor = 1,
                        NomeSetor = "LG",
                        IdBloco = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}