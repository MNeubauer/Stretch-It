using System;

namespace Microsoft.Samples.Kinect.DepthBasics
{
    class Pull : Gesture {
        public Pull(): base()
        {}
        
        public override void outputGesture() 
        {
            Console.WriteLine("Pull Gesture");
        }

        public override bool getGestureInput()
        {
            return true;
        }

        public override void outputFeedback(bool correct)
        {
            if (correct)
                Console.WriteLine("Correct Pull Gesture!");
            else
                Console.WriteLine("Incorrect Pull Gesture!");
        }
    }
}