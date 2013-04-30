using System;
using System.Drawing;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.ViewModels;

namespace storyb
{
	public partial class DetailViewController : MvxViewController
	{
		public DetailViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.CreateBinding(detailDescriptionLabel).To<DetailViewModel>(vm => vm.Menu.Name).Apply();
		}
	}
}

