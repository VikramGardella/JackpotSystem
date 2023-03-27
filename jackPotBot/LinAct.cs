using System;
namespace jackPotBot
{
    public class LinAct
    {
        //Member Variables
        int position;
        int id;

        //Constructor
        public LinAct(int index)
        {
            position = 0;
            id = index;
        }

        //Accessors
        public int getPosition() { return position; }
        public int getID() { return id; }

        //Mutators
        public void changePosition(int delta) { position += delta; }
        public void changeID(int newIndex) { id = newIndex; }

        //Misc. Functions
        public void extend()
        {
            while (position < 100)
            {
                position++;
                //time.sleep(0.05);
            }
        }

        public void retract()
        {
            while (position > 0)
            {
                position--;
                //time.sleep(0.05);
            }
        }
    }
}

