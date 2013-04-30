using System;
using System.Drawing;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.ViewModels;

namespace storyb
{
	public partial class RootViewController : MvxTableViewController
	{
		public RootViewController (IntPtr handle) : base (handle)
		{
			Title = NSBundle.MainBundle.LocalizedString ("Master", "Master");

			// Custom initialization
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			this.Request = new MvxViewModelRequest<RootViewModel>(null, null, new MvxRequestedBy());
			base.ViewDidLoad ();
			
			var source = new MvxStandardTableViewSource(TableView, UITableViewCellStyle.Default, new NSString("DataSourceCell"), "TitleText Name");
			TableView.Source = source;

			this.CreateBinding(source).To<RootViewModel>(vm => vm.Items).Apply();

			TableView.ReloadData();
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "showDetail") {
				var indexPath = TableView.IndexPathForSelectedRow;
				var menu = (ViewModel as RootViewModel).Items[indexPath.Row];
				DetailViewController.SetNextViewController(new DetailViewModel() { Menu = menu });
			}
		}
	}
}

