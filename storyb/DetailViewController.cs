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
		private static DetailViewModel _nextVMToPickup = null;

		public static void SetNextViewController(DetailViewModel viewModel)
		{
			_nextVMToPickup = viewModel;
		}

		public DetailViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			ViewModel = _nextVMToPickup;

			base.ViewDidLoad ();
		
			// Perform any additional setup after loading the view, typically from a nib.
			if (detailDescriptionLabel != null)
				this.CreateBinding(detailDescriptionLabel).To<DetailViewModel>(vm => vm.Menu.Name).Apply();
		}
	}
}

