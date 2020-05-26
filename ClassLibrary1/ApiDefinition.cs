using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace NativeLibrary
{
    [BaseType(typeof(NSObject))]    interface AppDelegate : IUIApplicationDelegate    {

    }

    // @interface VMListViewController : UICollectionViewController <UICollectionViewDragDelegate, UICollectionViewDropDelegate>
    [BaseType(typeof(UICollectionViewController))]
    interface VMListViewController : IUICollectionViewDragDelegate, IUICollectionViewDropDelegate
    {
        // -(void)unwindToMainFromConfiguration:(UIStoryboardSegue * _Nonnull)sender __attribute__((ibaction));
        [Export("unwindToMainFromConfiguration:")]
        void UnwindToMainFromConfiguration(UIStoryboardSegue sender);

        // -(void)exitUTM:(UIBarButtonItem * _Nonnull)sender __attribute__((ibaction));
        [Export("exitUTM:")]
        void ExitUTM(UIBarButtonItem sender);
    }

    [BaseType(typeof(NSObject))]
    interface UTMQemuManagerDelegate
    { 
    }

        [BaseType(typeof(NSObject))]
    interface UTMVirtualMachine : UTMQemuManagerDelegate
    {
    }

    // @interface VMDisplayViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface VMDisplayViewController
    {
        // @property (nonatomic, weak) UIView * _Nullable displayView __attribute__((iboutlet));
        [NullAllowed, Export("displayView", ArgumentSemantic.Weak)]
        UIView DisplayView { get; set; }

        // @property (nonatomic, strong) UIInputView * _Nonnull inputAccessoryView __attribute__((iboutlet));
        [Export("inputAccessoryView", ArgumentSemantic.Strong)]
        UIInputView InputAccessoryView { get; set; }

        // @property (nonatomic, weak) UIView * _Nullable toolbarAccessoryView __attribute__((iboutlet));
        [NullAllowed, Export("toolbarAccessoryView", ArgumentSemantic.Weak)]
        UIView ToolbarAccessoryView { get; set; }

        // @property (nonatomic, weak) UIButton * _Nullable powerExitButton __attribute__((iboutlet));
        [NullAllowed, Export("powerExitButton", ArgumentSemantic.Weak)]
        UIButton PowerExitButton { get; set; }

        // @property (nonatomic, weak) UIButton * _Nullable pauseResumeButton __attribute__((iboutlet));
        [NullAllowed, Export("pauseResumeButton", ArgumentSemantic.Weak)]
        UIButton PauseResumeButton { get; set; }

        // @property (nonatomic, weak) UIButton * _Nullable restartButton __attribute__((iboutlet));
        [NullAllowed, Export("restartButton", ArgumentSemantic.Weak)]
        UIButton RestartButton { get; set; }

        // @property (nonatomic, weak) UIButton * _Nullable zoomButton __attribute__((iboutlet));
        [NullAllowed, Export("zoomButton", ArgumentSemantic.Weak)]
        UIButton ZoomButton { get; set; }

        // @property (nonatomic, weak) UIVisualEffectView * _Nullable placeholderView __attribute__((iboutlet));
        [NullAllowed, Export("placeholderView", ArgumentSemantic.Weak)]
        UIVisualEffectView PlaceholderView { get; set; }

        // @property (nonatomic, weak) UIActivityIndicatorView * _Nullable placeholderIndicator __attribute__((iboutlet));
        [NullAllowed, Export("placeholderIndicator", ArgumentSemantic.Weak)]
        UIActivityIndicatorView PlaceholderIndicator { get; set; }

        // @property (nonatomic, weak) UIButton * _Nullable resumeBigButton __attribute__((iboutlet));
        [NullAllowed, Export("resumeBigButton", ArgumentSemantic.Weak)]
        UIButton ResumeBigButton { get; set; }

        // @property (nonatomic, strong) NSArray * _Nonnull customKeyModifierButtons __attribute__((iboutletcollection(VMKeyboardButton)));
        [Export("customKeyModifierButtons", ArgumentSemantic.Strong)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] CustomKeyModifierButtons { get; set; }

        // @property (readonly, nonatomic) BOOL largeScreen;
        [Export("largeScreen")]
        bool LargeScreen { get; }

        // @property (readwrite, nonatomic) BOOL prefersStatusBarHidden;
        [Export("prefersStatusBarHidden")]
        bool PrefersStatusBarHidden { get; set; }

        // @property (readonly, nonatomic) BOOL autosaveBackground;
        [Export("autosaveBackground")]
        bool AutosaveBackground { get; }

        // @property (readonly, nonatomic) BOOL autosaveLowMemory;
        [Export("autosaveLowMemory")]
        bool AutosaveLowMemory { get; }

        // @property (readonly, nonatomic) BOOL runInBackground;
        [Export("runInBackground")]
        bool RunInBackground { get; }

        // @property (nonatomic, strong) UTMVirtualMachine * _Nonnull vm;
        [Export("vm", ArgumentSemantic.Strong)]
        UTMVirtualMachine Vm { get; set; }

        // -(void)changeDisplayZoom:(UIButton * _Nonnull)sender __attribute__((ibaction));
        [Export("changeDisplayZoom:")]
        void ChangeDisplayZoom(UIButton sender);

        // -(void)pauseResumePressed:(UIButton * _Nonnull)sender __attribute__((ibaction));
        [Export("pauseResumePressed:")]
        void PauseResumePressed(UIButton sender);

        // -(void)powerPressed:(UIButton * _Nonnull)sender __attribute__((ibaction));
        [Export("powerPressed:")]
        void PowerPressed(UIButton sender);

        // -(void)restartPressed:(UIButton * _Nonnull)sender __attribute__((ibaction));
        [Export("restartPressed:")]
        void RestartPressed(UIButton sender);

        // -(void)showKeyboardButton:(UIButton * _Nonnull)sender __attribute__((ibaction));
        [Export("showKeyboardButton:")]
        void ShowKeyboardButton(UIButton sender);

        // -(void)hideToolbarButton:(UIButton * _Nonnull)sender __attribute__((ibaction));
        [Export("hideToolbarButton:")]
        void HideToolbarButton(UIButton sender);
    }

}

