using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Samples.Kinect.DepthBasics
{
    class Driver {

        public static Model model;
        private MainWindow window;

        enum Menu {
            Home,
            Settings,
            Progress,
            StartGame
        };

        public void startGame()
        {
            model = new Model();

            run_game();
        }

        private void run_game()
        {
            while(true) {
                // Start menu
                Menu option = Menu.Home;
                while(option != Menu.StartGame) {
                    window = new MainWindow();
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

                //start kinect here

                int reps = 10;
                for(int i = 0; i < reps; ++i) {
                    model.get_gesture().do_gesture();
                }
            }
        }
    }
}