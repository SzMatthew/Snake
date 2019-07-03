using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Input
    {
        //Load list of available Keyboard bottuns
        private static Hashtable keyTable = new Hashtable();

        //Perform a check to see if the specific keys are pressed
        public static bool KeyPressDetect(Keys key) {
            if (keyTable[key] == null) {
                return false;
            }

            return (bool)keyTable[key];
        }

        //Detect is a keyboard button is pressed
        public static void ChangeState(Keys key, bool state) {
            keyTable[key] = state;
        }
    }
}
