using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ConsoleApp12;

public class Program
{
    
    public static void Main(string[] args)
    {
        using (var context = new ApplicationDbContext())
        {
            context.Database.Migrate();

            if (!context.Persons.Any())
            {
                context.Persons.Add(new Persons { Name = "googa" });
                context.SaveChanges();
            }

            var entry = context.Persons.First();
            Console.WriteLine("Id: {0}, Name: {1}", entry.ID, entry.Name);

        }

    }
}