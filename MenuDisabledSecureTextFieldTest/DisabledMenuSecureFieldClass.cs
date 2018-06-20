using System;
using AppKit;
using Foundation;
using CoreGraphics;

namespace MenuDisabledSecureTextFieldTest
{
    [Register(nameof(MenuDisabledSecureTextField))]
    public partial class MenuDisabledSecureTextField : NSSecureTextField
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
            if((Menu?.Count ?? 0 ) != 0 ){
                foreach (var menuItem in Menu.ItemArray())
                    Menu.RemoveItem(menuItem);
            }else{
                System.Diagnostics.Debug.WriteLine("Menu is empty");
            }
        }

        public override void RightMouseDown(NSEvent theEvent)
        {
            System.Diagnostics.Debug.WriteLine("right-clicked!!");
            //  NextResponder.RightMouseDown(theEvent);
        }
        //option 2 this method always call before menu will show 
        //in this case you always need to check - cut, copy, delete action of menu and enabling or disabling them
        [Action("validateMenuItem:")]
        public bool ValidateMenuItem(NSMenuItem sender)
        {
            var actionName = sender.Action.Name;
            switch (actionName)
            {

                //paste menu will be always disabled
                case "paste:":
                    return false;

                case "selectAll:":
                    return true;

                default:
                    return false;
            }
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
            if ((Menu?.Count ?? 0) != 0)
            {
                foreach (var menuItem in Menu.ItemArray())
                    Menu.RemoveItem(menuItem);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Menu is empty");
            }
        }
        public override void RightMouseDown(NSEvent theEvent)
        {
            base.RightMouseDown(theEvent);
        }

        //option 2 this method always call before menu will show 
        //in this case you always need to check - cut, copy, delete action of menu and enabling or disabling them
        [Action("validateMenuItem:")]
        public bool ValidateMenuItem(NSMenuItem sender)
        {
            var actionName = sender.Action.Name;
            switch (actionName)
            {

                //paste menu will be always disabled
                case "paste:":
                    return false;

                case "selectAll:":
                    return true;

                default:
                    return false;
            }
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
        //option 2 this method always call before menu will show 
        //in this case you always need to check - cut, copy, delete action of menu and enabling or disabling them
        [Action("validateMenuItem:")]
        public bool ValidateMenuItem(NSMenuItem sender)
        {
            var actionName = sender.Action.Name;
            switch (actionName)
            {

                //paste menu will be always disabled
                case "paste:":
                    return false;

                case "selectAll:":
                    return true;

                default:
                    return false;
            }
        }
    }
}
