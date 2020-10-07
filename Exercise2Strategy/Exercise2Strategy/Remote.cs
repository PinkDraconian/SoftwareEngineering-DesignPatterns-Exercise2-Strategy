using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Exercise2Strategy
{
    public class Remote
    {
        private IJoystickBehavior joystickBehavior;
        private IButtonBehavior buttonBehavior;

        public IJoystickBehavior JoystickBehavior { get => joystickBehavior; set => joystickBehavior = value; }
        public IButtonBehavior ButtonBehavior { get => buttonBehavior; set => buttonBehavior = value; }

        public void PressButton() => ButtonBehavior.ButtonA_Click();
        public void PressUpButton() => JoystickBehavior.JoystickUp();
        public void PressDownButton() => JoystickBehavior.JoystickDown();
        public void PressLeftButton() => JoystickBehavior.JoystickLeft();
        public void PressRightButton() => JoystickBehavior.JoystickRight();

    }
}
