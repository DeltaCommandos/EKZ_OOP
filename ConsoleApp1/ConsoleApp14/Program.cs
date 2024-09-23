using System;
using System.Diagnostics;
using ConsoleApp14;
using Microsoft.EntityFrameworkCore;
using System.Linq;


public class DbInitializer
{
    public static void Initializer(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();

        if (context.Families.Any())
        {
            return;
        }
        var families = new[]
        {
            new Family {Name = "Indo-European"},
            new Family {Name = "Finno-Ugorean"},
            new Family {Name = "Semito-Hamith"}

        };

        var languages = new[]
        {
            new Language { Name = "Russian", Family = families[0] },
            new Language { Name = "English", Family = families[0] },
            new Language { Name = "Italian", Family = families[0] },
            new Language { Name = "Finnish", Family = families[1] },
            new Language { Name = "Mordovian", Family = families[1] },
            new Language { Name = "Arabic", Family = families[2] }
        };

        context.Families.AddRange(families);
        context.Languages.AddRange(languages);
        context.SaveChanges();

    }

}


public class Program
{

    public static void Main(string[] args)
    {
        using (var context = new ApplicationDbContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            DbInitializer.Initializer(context);


            foreach (var language in context.Languages)
            {
                Console.WriteLine("Languagee: {0}, Family: {1}",language.Name,language.Family.Name);
            }





            context.SaveChangesAsync();


        }
    }
}