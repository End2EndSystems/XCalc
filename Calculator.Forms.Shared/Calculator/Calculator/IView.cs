using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    interface IView
    {
        void Input(string value);
        string Output(string value);
    }
}
