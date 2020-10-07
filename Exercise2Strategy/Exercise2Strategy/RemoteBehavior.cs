using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2Strategy
{
    public class ButtonBehavior : IButtonBehavior
    {
        public void ButtonA_Click()
        {
            Console.WriteLine("Button press");
        }
    }

    public class RightHandedJoyStickBehavior : IJoystickBehavior
    {
        public void JoystickDown()
        {
            Console.WriteLine("Button Down");
        }

        public void JoystickLeft()
        {
            Console.WriteLine("Button Left");
        }

        public void JoystickRight()
        {
            Console.WriteLine("Button Right");
        }

        public void JoystickUp()
        {
            Console.WriteLine("Button Up");
        }
    }

    public class LeftHandedJoyStickBehavior : IJoystickBehavior
    {
        public void JoystickDown()
        {
            Console.WriteLine("Button Up");
        }

        public void JoystickLeft()
        {
            Console.WriteLine("Button Right");
        }

        public void JoystickRight()
        {
            Console.WriteLine("Button Left");
        }

        public void JoystickUp()
        {
            Console.WriteLine("Button Down");
        }
    }
}
