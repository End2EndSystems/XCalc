using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Controller
{
    class CalculatorCtrl
    {
        private IView _view = null;

        public CalculatorCtrl(IView view)
        {
            _view = view;
        }
    }
}
