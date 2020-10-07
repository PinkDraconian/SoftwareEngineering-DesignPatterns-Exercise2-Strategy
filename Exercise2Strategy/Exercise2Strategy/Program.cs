using System;

namespace Exercise2Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Remote remote = new Remote
            {
                JoystickBehavior = new LeftHandedJoyStickBehavior(),
                ButtonBehavior = new ButtonBehavior()
            };

            remote.PressButton();
            remote.PressUpButton();
        }
    }
}
