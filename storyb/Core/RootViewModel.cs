using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;

namespace storyb
{
	public class RootViewModel
		: MvxViewModel
	{

		public List<Menu> Items {get;set;}

		public RootViewModel ()
		{
			Items = new List<Menu>()
			{
				new Menu() { Name = "Hi 1" },
				new Menu() { Name = "Hi 2" },
				new Menu() { Name = "Hi 3" },
				new Menu() { Name = "Hi 4" },
				new Menu() { Name = "Hi 5" },
			};
		}
	}
	
}
