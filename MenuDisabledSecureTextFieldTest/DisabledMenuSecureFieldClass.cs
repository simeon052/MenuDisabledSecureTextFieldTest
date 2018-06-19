using System;
using AppKit;
using Foundation;
using CoreGraphics;

namespace MenuDisabledSecureTextFieldTest
{
    [Register("MenuDisabledSecureTextField")]
    public class MenuDisabledSecureTextField : NSSecureTextField
    {
        public MenuDisabledSecureTextField(IntPtr handle) : base(handle)
        {
            initialize();
        }

        public MenuDisabledSecureTextField(NSCoder coder) : base(coder)
        {
            initialize();
        }

        private void initialize()
        {

        }

        public override void RightMouseDown(NSEvent theEvent)
        {
            NextResponder.RightMouseDown(theEvent);
        }

        public override NSMenu MenuForEvent(NSEvent theEvent)
        {
            return null;
        }

        public override void WillOpenMenu(NSMenu menu, NSEvent theEvent)
        {
            base.WillOpenMenu(menu, theEvent);
        }


    }

    [Register("MenuDisabledTextField")]
    public class MenuDisabledTextField : NSTextField
    {
        public MenuDisabledTextField(IntPtr handle) : base(handle)
        {
            initialize();
        }

        public MenuDisabledTextField(NSCoder coder) : base(coder)
        {
            initialize();
        }

        private void initialize()
        {

        }
        public override void RightMouseDown(NSEvent theEvent)
        {
            base.RightMouseDown(theEvent);
        }
    }

    [Register("MenuDisabledSecureTextFieldCell")]
    public class MenuDisabledSecureTextFieldCell : NSSecureTextFieldCell
    {

        public MenuDisabledSecureTextFieldCell(IntPtr handle) : base(handle)
        {
            initialize();
        }

        public MenuDisabledSecureTextFieldCell(NSCoder coder) : base(coder)
        {
            initialize();
        }
        private void initialize()
        {
            this.Menu = new NSMenu();

        }
        public override NSMenu MenuForEvent(NSEvent theEvent, CGRect cellFrame, NSView view)
        {
            System.Diagnostics.Debug.WriteLine(this.Menu.ToString());
            return null;//base.MenuForEvent(theEvent, cellFrame, view);
        }
        public override bool TrackMouse(NSEvent theEvent, CGRect cellFrame, NSView controlView, bool untilMouseUp)
        {
            System.Diagnostics.Debug.WriteLine("In TrackMouse");

            return base.TrackMouse(theEvent, cellFrame, controlView, untilMouseUp);
        }

        public override NSObject AccessibilityShownMenu
        {
            get => null;
            set => base.AccessibilityShownMenu = value;
        }
    }
}
