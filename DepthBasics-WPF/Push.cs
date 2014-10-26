using System;

namespace Microsoft.Samples.Kinect.DepthBasics
{
    class Push : Gesture {
        public Push(): base()
        {}

        public override void outputGesture()
        {
            Console.WriteLine("Push Gesture");
        }

        public override bool getGestureInput()
        {
            return true;
        }

        public override void outputFeedback(bool correct)
        {
            if (correct)
                Console.WriteLine("Correct Push Gesture!");
            else
                Console.WriteLine("Incorrect Push Gesture!");
        }
    }
}