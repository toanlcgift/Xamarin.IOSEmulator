using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace NativeLibrary
{
    [BaseType(typeof(NSObject))]    interface AppDelegate : IUIApplicationDelegate    {

    }

    [BaseType(typeof(UIViewController))]
    interface VMDisplayViewController
    {
    }

    [BaseType(typeof(UICollectionViewController))]
    interface VMListViewController : IUICollectionViewDragDelegate, IUICollectionViewDropDelegate
    {

    }
}

