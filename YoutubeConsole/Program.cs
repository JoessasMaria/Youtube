using System;
using System.Collections.Generic;

namespace YoutubeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoDAO dao = new VideoDAO();
            menu();

            while (true)
            {
                try
                {
                    int selection = Convert.ToInt32(Console.ReadLine());
                    string title;
                    string description;
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("alle anzeigen");
                            List<Video> videos = dao.getAllVideos();

                            foreach (Video video in videos)
                            {
                                Console.WriteLine(video.title + " - " + video.description);
                            }

                            break;
                        case 2:
                            Console.WriteLine("suchen");
                            title = Console.ReadLine();
                            List<Video> videos2 = dao.searchVideos(title);

                            foreach (Video video in videos2)
                            {
                                Console.WriteLine(video.title + " - " + video.description);
                            }

                            break;
                        case 3:
                            Console.WriteLine("einfügen");
                            title = Console.ReadLine();
                            description = Console.ReadLine();

                            dao.insertVideo(title, description);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("----- Fehler bei der Eingabe -----");
                    menu();
                }
               
            }

            void menu()
            {
                Console.WriteLine("------------------");
                Console.WriteLine("menu");
                Console.WriteLine("1 Alle anzeigen");
                Console.WriteLine("2 Suchen");
                Console.WriteLine("3 Einfügen");
                Console.WriteLine("------------------");
            }
        }
    }
}
