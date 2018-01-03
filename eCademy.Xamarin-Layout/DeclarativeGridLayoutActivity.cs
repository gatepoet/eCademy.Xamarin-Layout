using Android.App;
using Android.OS;

namespace eCademy.Xamarin_Layout
{
    [Activity(Label = "Declarative Static Grid Layout")]
    public class DeclarativeGridLayoutActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.GridLayout);
        }
    }
}