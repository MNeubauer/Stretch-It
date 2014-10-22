using system

namespace Stretch-It 
{
    private List<Gesture> gestures;
    private Random random;
    bool push = true;
    bool pull = true;

    class Model {
        public Model()
        {
            // Initialize members.
            gestures = new List<Gestures>();
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
            return random.Next(gestures.Count);
        }
    }
}