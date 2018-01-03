using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Util;

namespace eCademy.Xamarin_Layout
{
    [Activity(Label = "Programmatic Static Grid Layout")]
    public class ProgrammaticGridLayoutActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var container = new LinearLayout(this);
            container.SetGravity(GravityFlags.Center);
            SetContentView(container);

            var layout = CreateLayout();
            var size = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, 150, Resources.DisplayMetrics);

            layout.AddView(CreateView(Resource.Drawable.Monument), size, size);
            layout.AddView(CreateView(Resource.Drawable.darth_vlad), size, size);
            layout.AddView(CreateView(Resource.Drawable.web_designer), size, size);
            layout.AddView(CreateView(Resource.Drawable.national_gallery), size, size);

            container.AddView(layout);
        }

        private ViewGroup CreateLayout()
        {
            var layout = new GridLayout(this);
            layout.ColumnCount = 2;
            layout.RowCount = 2;
            var layoutParams = new ViewGroup.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent
            );
            layout.LayoutParameters = layoutParams;

            return layout;
        }

        private View CreateView(int imageResourceId)
        {
            var view = new ImageView(this);
            view.SetScaleType(ImageView.ScaleType.CenterCrop);
            view.SetImageResource(imageResourceId);

            return view;
        }
    }
}