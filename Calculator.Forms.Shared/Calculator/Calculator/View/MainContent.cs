using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Calculator.View
{
	public class MainContent : ContentPage
	{
		public MainContent ()
		{
			Content = new StackLayout {
				Children = {
					new Xamarin.Forms.Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}
