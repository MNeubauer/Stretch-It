using System;
using System.Collections.Generic;

namespace StretchIt 
{
    class Model {
        const string PULL_C = "Pull";
        const string PUSH_C = "Push";

        private Dictionary<string, Gesture> gestures;
        private Random random;
        private Dictionary<string, bool> active_gestures;

        public Model()
        {
            // Initialize members.
            gestures = new Dictionary<string, Gesture>();
            random = new Random();
            active_gestures = new Dictionary<string, bool>();

            // Set each gesture to active (true)
            active_gestures[PULL_C] = true;
            active_gestures[PUSH_C] = true;

            // Add each gesture that was selected in the options screen
            // to the gestures List.
            gestures[PULL_C] = new Pull();
            gestures[PUSH_C] = new Push();
        }

        // Will return 
        public Gesture get_gesture()
        {
            List<string> keys = new List<string>();

            foreach (KeyValuePair<string, bool> entry in active_gestures)
            {
                if (entry.Value)
                    keys.Add(entry.Key);
            }

            return gestures[keys[random.Next(keys.Count)]];
        }
    }
}