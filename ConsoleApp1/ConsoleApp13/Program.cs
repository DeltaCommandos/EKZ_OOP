using System;
using System.Diagnostics;
using ConsoleApp13;
using Microsoft.EntityFrameworkCore;

public class Program
{
    
    public static void Main(string[] args)
    {
        using (var context = new ApplicationDbContext())
        {
            context.Database.Migrate();

            if(context.Persons.Count()<1000000)
            {
                AddMillion(context);
            }

            Search(context);

        }
    }


    public static void AddMillion(ApplicationDbContext context)
    {
        Console.WriteLine("Начинаю запись...");
        for (int i = 0;i<1000000 ; i++)
        {
            context.Persons.Add(new Person{Name = $"Pelmen {i}" });

            if(i%10000 == 0)
            {
                context.SaveChanges();
                Console.WriteLine($"{i} записей добавлено...");
            }
        }
        context.SaveChanges();
        Console.WriteLine("Запись завершена!");

    }

    public static void Search(ApplicationDbContext context)
    {
        Stopwatch sw = Stopwatch.StartNew();
        Random random = new Random();

        Console.WriteLine("Начинаю поиск по id...");
        long IdSearchTime = 0;
        for(int i = 0;i<1000 ; i++)
        {
            int RandomId = random.Next(1,1000001);
            sw.Restart();
            var result = context.Persons.FirstOrDefault(x => x.ID == RandomId);
            sw.Stop();
            Console.WriteLine($"{i} Нашел...");
            IdSearchTime += sw.ElapsedTicks;
        }

        Console.WriteLine($"Поиск по id завершен! Среднее время: {IdSearchTime / 1000} тиков");



        Console.WriteLine("Начинаю поиск по имени...");
        long NameSearchTime = 0;
        for (int i = 0; i < 1000; i++)
        {
            int RandomName = random.Next(1, 1000001);
            string SearchName = $"Pelmen {RandomName}";
            sw.Restart();
            var result = context.Persons.FirstOrDefault(x => x.Name == SearchName);
            sw.Stop();
            Console.WriteLine($"{i} Нашел...");
            NameSearchTime += sw.ElapsedTicks;


        }

        Console.WriteLine($"Поиск по имени завершен! Среднее время: {NameSearchTime / 1000} тиков");

    }



}