using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.Touch.Platform;

namespace storyb
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : MvxApplicationDelegate
	{
		// class-level declarations
		
		public override UIWindow Window {
			get;
			set;
		}
		
		//
		// This method is invoked when the application is about to move from active to inactive state.
		//
		// OpenGL applications should use this method to pause.
		//
		public override void OnResignActivation (UIApplication application)
		{
		}
		
		// This method should be used to release shared resources and it should store the application state.
		// If your application supports background exection this method is called instead of WillTerminate
		// when the user quits.
		public override void DidEnterBackground (UIApplication application)
		{
		}
		
		// This method is called as part of the transiton from background to active state.
		public override void WillEnterForeground (UIApplication application)
		{
		}

		public class Presenter : IMvxTouchViewPresenter
		{
			#region IMvxTouchModalHost implementation
			public bool PresentModalViewController (UIViewController controller, bool animated)
			{
				throw new NotImplementedException ();
			}
			public void NativeModalViewControllerDisappearedOnItsOwn ()
			{
				throw new NotImplementedException ();
			}
			#endregion
			#region IMvxViewPresenter implementation
			public void Show (Cirrious.MvvmCross.ViewModels.MvxViewModelRequest request)
			{
				throw new NotImplementedException ();
			}
			public void ChangePresentation (Cirrious.MvvmCross.ViewModels.MvxPresentationHint hint)
			{
				throw new NotImplementedException ();
			}
			#endregion
		}

		public override void FinishedLaunching (UIApplication application)
		{
			// NOTE: Don't call the base implementation on a Model class
			// see http://docs.xamarin.com/ios/tutorials/Events%2c_Protocols_and_Delegates 

			var setup = new Setup(this, new Presenter());
			setup.Initialize();
		}
		
		// This method is called when the application is about to terminate. Save data, if needed. 
		public override void WillTerminate (UIApplication application)
		{
		}
	}
}

