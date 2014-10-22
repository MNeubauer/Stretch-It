using System;
    
namespace StretchIt
{
    class Push : Gesture {
        public Push(): base()
        {}
        public override int do_gesture()
        {
            Console.WriteLine("Push Gesture");
            return 0; 
        }
    }
}