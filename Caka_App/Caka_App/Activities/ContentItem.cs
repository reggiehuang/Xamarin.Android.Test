using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Caka_App.Widget;

namespace Caka_App.Activities
{
    [Activity(Label = "ContentItem")]
    public class ContentItem : Activity
    {
        private ImageViewPlus iv_roundRect;//圆角矩形图片
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.main_content_item);
            iv_roundRect = FindViewById<ImageViewPlus>(Resource.Id.roundRect);
            iv_roundRect.SetType(ImageViewPlus.TYPE_ROUND);
            iv_roundRect.SetRoundRadius(120);
        }
    }
}