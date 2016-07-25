using Foundation;
using System;
using UIKit;

namespace iOSStackView
{
    public partial class HomeController : UIViewController
    {
		partial void BtnBack_TouchUpInside(UIButton sender)
		{
			ViewController firstscreen = this.Storyboard.InstantiateViewController("login") as ViewController;
			this.NavigationController.PushViewController(firstscreen, true);

		}

		public HomeController (IntPtr handle) : base (handle)
        {
        }

		public string UserName;
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			lblUser.Text = UserName;
		}
    }
}