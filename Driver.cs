using System;

namespace StretchIt 
{
    class Driver {

        public static Model model;

        enum Menu {
            Home,
            Settings,
            Progress,
            StartGame
        };

        static void Main(string[] args)
        {
            model = new Model();
            run_game();
        }

        private static void run_game()
        {
            while(true) {
                // Start menu
                Menu option = Menu.Home;
                while(option != Menu.StartGame) {
                    switch(option)
                    {
                        case Menu.Home:
                            break;
                        case Menu.Settings:
                            break;
                        case Menu.Progress:
                            break;
                    }
                }

                int reps = 10;
                for(int i = 0; i < reps; ++i) {
                    model.get_gesture().do_gesture();
                }
            }
        }
    }
}