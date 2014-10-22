using system

namespace Stretch-It 
{
    class Driver {

        Public model;

        static void Main(string[] args)
        {
            model = new Model();
            run_game();
        }

        private static void run_game()
        {
            int reps = 10;
            for(int i = 0; i < reps; ++reps) {
                model.get_gesture().do_gesture();
            }
        }
    }
}