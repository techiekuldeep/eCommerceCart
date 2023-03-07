using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category smartWatches = new Category { Name = "SmartWatches", Slug = "smartWatches" };
                Category soccerJerseys = new Category { Name = "SoccerJerseys", Slug = "soccerJerseys" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "Apple Watch SE",
                            Slug = "apple watch se",
                            Description = "Apple Watch SE GPS 44mm Midnight Aluminium Case with Midnight Sport Band",
                            Price = 525.50M,
                            Category = smartWatches,
                            Image = "appleWatch.jpg"
                        },
                        new Product
                        {
                            Name = "Samsung Galaxy Watch",
                            Slug = "samsung galaxy watch",
                            Description = "Samsung Galaxy Watch5 44mm Blue",
                            Price = 390.95M,
                            Category = smartWatches,
                            Image = "samsungGalaxyWatch.jpg"
                        },
                        new Product
                        {
                            Name = "Fitbit Versa 4",
                            Slug = "fitbit versa 4",

                                Description = "Fitbit Versa 4 Black/Graphite",
                            Price = 379.50M,
                            Category = smartWatches,
                            Image = "fitBitVersa.jpg"
                        },
                        new Product
                        {
                            Name = "Huawei Band 7",
                            Slug = "huawei band 7",
                            Description = "Huawei Band 7 - Graphite Black",
                            Price = 130.50M,
                            Category = smartWatches,
                            Image = "huaweiBand7.jpg"
                        },
                        new Product
                        {
                            Name = "Garmin vivoactive 4",
                            Slug = "garmin vivoactive 4",
                            Description = "Garmin vivoactive 4 GPS Smartwatch Shadow Gray/Silver",
                            Price = 575.99M,
                            Category = smartWatches,
                            Image = "garminVivoactive.jpg"
                        },
                        new Product
                        {
                            Name = "FC Bayern Munich Jersey",
                            Slug = "fc bayern munich jersey",
                            Description = "FC Bayern Munich 22-23 Jersey",
                            Price = 180.99M,
                            Category = soccerJerseys,
                            Image = "BM.jpg"
                        },
                        new Product
                        {
                            Name = "FC PSG Jersey",
                            Slug = "fc psg jersey",
                            Description = "FC PSG 22-23 Jersey",
                            Price = 190.99M,
                            Category = soccerJerseys,
                            Image = "PSG.jpg"
                        },
                        new Product
                        {
                            Name = "FC Real Madrid Jersey",
                            Slug = "fc real madrid jersey",
                            Description = "FC Real Madrid 22-23 Jersey",
                            Price = 169.99M,
                            Category = soccerJerseys,
                            Image = "RM.jpg"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}
