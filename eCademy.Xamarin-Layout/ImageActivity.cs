
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Content.PM;

namespace eCademy.Xamarin_Layout
{
    [Activity(
        Theme = "@android:style/Theme.Material.Light.NoActionBar",
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize
    )]
    public class ImageActivity : Activity
    {
        private ImageView imageView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Image);

            imageView = FindViewById<ImageView>(Resource.Id.imageView);
            var id = Intent.GetIntExtra("image_resourceId", 0);
            imageView.SetImageResource(id);
        }
    }
}