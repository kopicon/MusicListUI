using System;
using static System.Console;
using MusicListDAL;
using MusicListBLL;
using MusicListEntities;

namespace MusicListUI
{
    class Program
    {
        static BLLFacade bllFacade = new BLLFacade();
        public static void Showmenu()
        {
            string[] menuItems = {
                "List of all musics",
                "Add music",
                "Delete music",
                "Edit music",
                "Exit"
            };

            var MenuOptions = ShowMenu(menuItems);
            while (MenuOptions != 5)
            {
                switch (MenuOptions)
                {
                    case 1:
                        bllFacade.
                        break;
                    case 2:
                        .AddMusic();
                        break;
                    case 3:
                        .DeleteMusic();
                        break;
                    case 4:
                        .EditVideo();
                        break;
                    default:
                        break;
                }
            }
            WriteLine("Bye bye!!");
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {

        }
        private static void EditVideo()
        {
            var Music = FindMusicById();
            if (Music != null)
            {
                WriteLine("Enter the new name of the music:\n");
                Music.Name = ReadLine();
                WriteLine("Enter the new style of the music:\n");
                Music.Style = ReadLine();
                WriteLine("You successfully changed the music");
            }
            else
            {
                WriteLine("Music not found!");
            }
        }
        public static void ShowAllMusics()
        {
            WriteLine("Here you can see all the stored musics:\n");

            foreach (var item in bllFacade.GetMusicService().GetAllMusic()) 
            {
                WriteLine($"Id: { item.Id}\n" +
                          $"Name: {item.Name }\n" +
                          $"Style: {item.Style }\n");
            }
            WriteLine("\n");
        }
            private static void AddMusic()
        {
            WriteLine("The name of the music: \n");
            var name = ReadLine();

            WriteLine("The Style of the music: \n");
            var style = ReadLine();

            bllFacade.GetMusicService().Add(new Music()
            {
                Name = name,
                Style = style
            });
            WriteLine("You successfully added " + name + " to the list");
        }
           
        private static Music FindMusicById()
        {
        WriteLine("Insert Music Id: \n");
        int id;
            while (!int.TryParse(ReadLine(), out id))
            {
                WriteLine("Please insert a number");
            }
            return bllFacade.GetMusicService().GetMusic(id);
        }

        private static void DeletMusic()
        {
            var musicFound = FindMusicById();
            if (musicFound != null)
            {
                bllFacade.GetMusicService().Delete(musicFound.Id);
 
            }
            var response = musicFound == null ? "Music not Found!" : "Music was Deleted";
            WriteLine(response);
        }




    }


}

