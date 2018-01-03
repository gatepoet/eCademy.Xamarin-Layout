using Android.App;
using Android.OS;
using Android.Widget;

namespace eCademy.Xamarin_Layout
{
    [Activity(Label = "List View")]
    public class ListViewActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ListAdapter = new ListImageAdapter(this);

            ListView.ItemClick += ImageHelper.StartImageActivityFromClick(this);
        }
    }
}