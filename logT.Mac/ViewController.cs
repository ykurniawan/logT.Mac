using System;

using AppKit;
using Foundation;

namespace logT.Mac
{
    public partial class ViewController : NSViewController
    {

        readonly NSColor MAIN_BG_COLOR = NSColor.FromRgba(.92f, .77f, .78f, .5f);

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override void ViewDidAppear()
        {
            base.ViewDidAppear();

            var presOptions = NSApplicationPresentationOptions.HideDock
                                                              | NSApplicationPresentationOptions.HideMenuBar
                                                              | NSApplicationPresentationOptions.DisableProcessSwitching
                                                              | NSApplicationPresentationOptions.DisableSessionTermination
                                                              | NSApplicationPresentationOptions.DisableHideApplication
                                                              | NSApplicationPresentationOptions.AutoHideToolbar;

            var presOptionsDict = new NSDictionary(NSView.NSFullScreenModeApplicationPresentationOptions, presOptions);
            this.View.EnterFullscreenModeWithOptions(NSScreen.MainScreen, presOptionsDict);
            this.View.WantsLayer = true;
            this.View.Window.IsOpaque = true;
            this.View.Window.BackgroundColor = MAIN_BG_COLOR;

        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
