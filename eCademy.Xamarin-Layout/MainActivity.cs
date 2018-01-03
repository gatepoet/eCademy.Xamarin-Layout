using Android.App;
using Android.Widget;
using Android.OS;

namespace eCademy.Xamarin_Layout
{
    [Activity(Theme = "@android:style/Theme.Material.Light.NoActionBar", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            FindViewById<Button>(Resource.Id.declarative_gridLayout).Click +=
                (e, args) => StartActivity(typeof(DeclarativeGridLayoutActivity));
            FindViewById<Button>(Resource.Id.programmatic_gridLayout).Click +=
                (e, args) => StartActivity(typeof(ProgrammaticGridLayoutActivity));
            FindViewById<Button>(Resource.Id.gridView).Click +=
                (e, args) => StartActivity(typeof(GridViewActivity));
            FindViewById<Button>(Resource.Id.listView).Click +=
                (e, args) => StartActivity(typeof(ListViewActivity));
        }
    }
}

