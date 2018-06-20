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
            System.Diagnostics.Debug.WriteLine("right-clicked!!");
            //  NextResponder.RightMouseDown(theEvent);
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

        }
        public override NSMenu MenuForEvent(NSEvent theEvent, CGRect cellFrame, NSView view)
        {
            return base.MenuForEvent(theEvent, cellFrame, view);
        }

        public override void DidChangeValue(string forKey)
        {
            base.DidChangeValue(forKey);
        }
    }
}
