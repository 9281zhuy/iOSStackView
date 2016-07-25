// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSStackView
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnlogin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtUser { get; set; }

        [Action ("Btnlogin_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Btnlogin_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnlogin != null) {
                btnlogin.Dispose ();
                btnlogin = null;
            }

            if (txtUser != null) {
                txtUser.Dispose ();
                txtUser = null;
            }
        }
    }
}