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
	public class Setup : MvxTouchSetup
	{
		public Setup (MvxApplicationDelegate deleg, IMvxTouchViewPresenter presenter)
			: base(deleg, presenter)
		{
		}

		protected override IMvxApplication CreateApp ()
		{
			return new App();
		}
	}	
}
