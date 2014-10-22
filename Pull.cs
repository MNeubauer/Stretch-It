using System;
    
namespace StretchIt
{
    class Pull : Gesture {
        public Pull(): base()
        {}
        public override int do_gesture() 
        {
            Console.WriteLine("Pull Gesture");
            return 0; 
        }
    }
}