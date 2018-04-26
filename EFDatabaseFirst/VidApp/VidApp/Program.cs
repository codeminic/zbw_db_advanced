using System;

namespace VidApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a video title to add it to the database");

            do
            {
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) break;
                using (var context = new VidAppEntities())
                {
                    context.Database.Log = Console.Write;
                    context.Videos.Add(new Video { Name = input, ReleaseDate = DateTime.Now });
                    context.SaveChanges();
                }
            } while (true);
        }
    }
}
