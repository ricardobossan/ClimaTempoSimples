using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Dominio.Enum;
using Dominio.Model;

namespace DAL.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Context context)
        {
            // TODO: Em produção, comentar o corpo deste método.
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            #region Estados
            context.Estados.AddOrUpdate(
               new Estado()
               {
                   Id = 1,
                   Nome = "Rio de Janeiro",
                   UF = "RJ"
               }
            );
            #endregion
            #region Cidades
            Cidade[] cidades = new Cidade[]
            {
               new Cidade()
               {
                   Id = 1,
                   Nome = "Niterói",
                   EstadoId = 1
               },
               new Cidade()
               {
                   Id = 2,
                   Nome = "Petrópolis",
                   EstadoId = 1
               },
               new Cidade()
               {
                   Id = 3,
                   Nome = "Rio de Janeiro",
                   EstadoId = 1
               },
               new Cidade()
               {
                   Id = 4,
                   Nome = "São Gonçalo",
                   EstadoId = 1
               }

            };
            context.Cidades.AddOrUpdate(cidades);
            #endregion
            #region PrevisaoClimas
            int p = 1;
            int qtDias = 7;
            foreach (var cidade in cidades)
            {
                for (int d = 1; d <= qtDias; d++)
                {
                    context.PrevisaoClimas.AddOrUpdate(new PrevisaoClima()
                    {
                        Id = p,
                        Clima = Enum.GetName(typeof(Clima), new Random().Next(1, 4)),
                        TemperaturaMaxima = new Random().Next(25, 36),
                        TemperaturaMinima = new Random().Next(13, 25),
                        DataPrevisao = DateTime.Now.AddDays(d - 1),
                        CidadeId = cidade.Id
                    });
                    p++;
                }
            }
            #endregion

            context.SaveChanges();
        }
    }
}
