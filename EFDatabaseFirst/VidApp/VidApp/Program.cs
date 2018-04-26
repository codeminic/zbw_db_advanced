using System;

namespace VidApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a video movie title and a genre to add it to the database. Example: 'Star Wars - The Force Awakens;Science Fiction'");

            do
            {
                var rawInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(rawInput)) break;
                var values = rawInput.Split(';');
                var movie = values[0];
                var genre = values[1];
                using (var context = new VidAppEntities())
                {
                    context.spAddVideo(movie, DateTime.Now, genre);
                    context.SaveChanges();
                }
            } while (true);
        }
    }
}
