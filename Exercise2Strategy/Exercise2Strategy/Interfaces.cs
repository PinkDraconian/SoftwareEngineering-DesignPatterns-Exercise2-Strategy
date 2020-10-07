using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2Strategy
{
    public interface IButtonBehavior
    {
        void ButtonA_Click();
    }

    public interface IJoystickBehavior
    {
        void JoystickUp();
        void JoystickDown();
        void JoystickLeft();
        void JoystickRight();
    }
}
