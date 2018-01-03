using Android.App;
using Android.OS;
using Android.Widget;

namespace eCademy.Xamarin_Layout
{
    [Activity(Label = "Grid View")]
    public class GridViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.GridView);

            var gridView = FindViewById<GridView>(Resource.Id.gridView);
            var adapter = new GridImageAdapter(this, gridView);
            gridView.Adapter = adapter;
            gridView.ViewTreeObserver.AddOnGlobalLayoutListener(adapter);

            gridView.ItemClick += ImageHelper.StartImageActivityFromClick(this);
        }
    }
}