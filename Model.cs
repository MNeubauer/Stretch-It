using System;
using System.Collections.Generic;

namespace StretchIt 
{
    class Model {
        private List<Gesture> gestures;
        private Random random;
        bool push = true;
        bool pull = true;

        public Model()
        {
            // Initialize members.
            gestures = new List<Gesture>();
            random = new Random();

            // Add each gesture that was selected in the options screen
            // to the gestures List.
            if(push) {
                gestures.Add(new Push());
            }
            if(pull) {
                gestures.Add(new Pull());
            }
        }

        // Will return 
        public Gesture get_gesture()
        {
            return gestures[random.Next(gestures.Count)];
        }
    }
}