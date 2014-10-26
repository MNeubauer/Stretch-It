using System;
using System.Collections.Generic;

namespace Microsoft.Samples.Kinect.DepthBasics
{
    class Model {
        const string PULL_C = "Pull";
        const string PUSH_C = "Push";

        private Dictionary<string, Gesture> gestures;
        private Random random;
        private List<string> gesture_names;

        public Model()
        {
            // Initialize members.
            gestures = new Dictionary<string, Gesture>();
            random = new Random();

            // Add each gesture that was selected in the options screen
            // to the gestures List.
            gestures[PULL_C] = new Pull();
            gestures[PUSH_C] = new Push();

            // Create a list of the keys of all active gestures
            gesture_names = new List<string>();
            foreach (KeyValuePair<string, Gesture> entry in gestures)
            {
                if (entry.Value.is_active)
                    gesture_names.Add(entry.Key);
            }
        }

        // Will return 
        public Gesture get_gesture()
        {
            int rand = random.Next(gesture_names.Count);
            
            return gestures[gesture_names[rand]];
        }
    }
}