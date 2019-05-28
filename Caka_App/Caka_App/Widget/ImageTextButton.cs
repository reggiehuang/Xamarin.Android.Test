using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;
namespace Caka_App.Widget
{
    public class ImageTextButton : LinearLayout
    {
        private ImageView mImgView = null;
        private TextView mTextView = null;
        private Context mContext;

        public ImageTextButton(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            LayoutInflater.From(context).Inflate(Resource.Layout.navi_item_layout, this, true);
            mContext = context;
            mImgView = (ImageView)FindViewById(Resource.Id.img);
            mTextView = (TextView)FindViewById(Resource.Id.text);
        }

        /*设置图片接口*/
        public void SetImageResource(int resId)
        {
            mImgView.SetImageResource(resId);
        }

        /*设置文字接口*/
        public void SetText(string str)
        {
            mTextView.Text = str;// etText(str);
        }
        /*设置文字大小*/
        public void SetTextSize(float size)
        {
            mTextView.TextSize = size;//.setTextSize(size);
        }
    }
}