using System;

using Android;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace sampleDisplay.Droid {
    //Theme = "@android:style/Theme.Holo.Light.DarkActionBar",
    //Theme = "@style/MainTheme",
    [Activity (Label = "sampleDisplay", Icon = "@mipmap/icon", Theme = "@android:style/Theme.Holo.Light.DarkActionBar",
        MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : FormsApplicationActivity {
        protected override void OnCreate (Bundle savedInstanceState) {
            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate (savedInstanceState);
            Xamarin.Forms.Forms.Init (this, savedInstanceState);
            Xamarin.FormsMaps.Init (this, savedInstanceState);
            Xamarin.Essentials.Platform.Init (this, savedInstanceState);

            ActivityCompat.RequestPermissions (this, new string[] { Manifest.Permission.AccessFineLocation }, 0);
            ActivityCompat.RequestPermissions (this, new string[] { Manifest.Permission.AccessCoarseLocation }, 0);
            LoadApplication (new App ());
        }
    }
}