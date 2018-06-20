// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MenuDisabledSecureTextFieldTest
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        MenuDisabledSecureTextFieldTest.MenuDisabledSecureTextField secTf2 { get; set; }

        [Outlet]
        MenuDisabledSecureTextFieldTest.MenuDisabledSecureTextFieldCell secTfCell { get; set; }

        [Outlet]
        AppKit.NSTextField TF { get; set; }
        
        void ReleaseDesignerOutlets ()
        {
            if (TF != null) {
                TF.Dispose ();
                TF = null;
            }

            if (secTf2 != null) {
                secTf2.Dispose ();
                secTf2 = null;
            }

            if (secTfCell != null) {
                secTfCell.Dispose ();
                secTfCell = null;
            }
        }
    }
}
