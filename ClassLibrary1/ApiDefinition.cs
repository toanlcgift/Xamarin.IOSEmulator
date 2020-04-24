using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace NativeLibrary
{
    [BaseType(typeof(NSObject))]    interface AppDelegate : IUIApplicationDelegate    {

    }

    [BaseType(typeof(NSObject))]
    interface VMListViewController : UICollectionViewController
    {

    }
}

