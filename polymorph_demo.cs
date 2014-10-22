using System;

namespace StretchIt 
{
    abstract class Gesture {
        abstract public int do_gesture();
    }

    class Push : Gesture {
        public Push(): base()
        {}
        public override int do_gesture()
        {
            Console.WriteLine("Push Gesture");
            return 0; 
        }
    }

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