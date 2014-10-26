using System;

namespace Microsoft.Samples.Kinect.DepthBasics 
{
    abstract class Gesture {
        public bool is_active = true;
        
        public void do_gesture(){
            outputGesture();
            outputFeedback(getGestureInput());
        }

        abstract public void outputGesture();

        abstract public bool getGestureInput();

        abstract public void outputFeedback(bool correct);
    }
}