using AppKit;
using Foundation;

namespace logT.Mac
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application

            var statusItem = NSStatusBar.SystemStatusBar.CreateStatusItem(NSStatusItemLength.Variable);

            statusItem.Image = NSImage.ImageNamed("StatusBarIcon");
            statusItem.Menu = new NSMenu("logT");
            var menuItem1 = new NSMenuItem("Settings");
            var menuItem2 = new NSMenuItem("Quit");

            statusItem.Menu.AddItem(menuItem1);
            statusItem.Menu.AddItem(menuItem2);

        } 

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
