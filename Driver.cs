using System;

namespace StretchIt 
{
    class Driver {

        public static Model model;

        static void Main(string[] args)
        {
            model = new Model();
            run_game();
        }

        private static void run_game()
        {
            int reps = 10;
            for(int i = 0; i < reps; ++i) {
                model.get_gesture().do_gesture();
            }
        }
    }
}