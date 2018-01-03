using Android.Content;
using Android.Views;
using Android.Widget;

namespace eCademy.Xamarin_Layout
{
    public class ListImageAdapter : BaseAdapter
    {
        private readonly Context context;

        public ListImageAdapter(Context context)
        {
            this.context = context;
        }

        public override int Count
        {
            get { return ImageHelper.StaticImages.Length; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return ImageHelper.StaticImages[position];
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;

            if (convertView == null)
            {  // if it's not recycled, initialize some attributes
                imageView = new ImageView(context);
                imageView.SetAdjustViewBounds(true);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            imageView.SetImageResource(ImageHelper.StaticImages[position]);
            return imageView;
        }
    }
}