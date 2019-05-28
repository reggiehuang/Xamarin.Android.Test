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
    [Activity(Label = "NaviActivity")]
    public class NaviActivity : Activity
    {
        //private ImageTextButton itbTest;

        private RelativeLayout hot_navi;
        private RelativeLayout all_navi;
        private RelativeLayout remark_navi;
        private RelativeLayout setting_navi;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.navi_layout);
            //itbTest = FindViewById<ImageTextButton>(Resource.Id.itbTest);
            //itbTest.SetImageResource(Resource.Drawable.navi_hot_b);
            //itbTest.SetText(GetString(Resource.String.navi_hot));
            //itbTest.Click += delegate
            //{
            //};

            hot_navi = FindViewById<RelativeLayout>(Resource.Id.rl_hot);
            all_navi = FindViewById<RelativeLayout>(Resource.Id.rl_all);
            remark_navi = FindViewById<RelativeLayout>(Resource.Id.rl_remark);
            setting_navi = FindViewById<RelativeLayout>(Resource.Id.rl_setting);

            hot_navi.Click += delegate {
                Toast.MakeText(this, "热门推荐", ToastLength.Short).Show();
            };
            all_navi.Click += delegate {
                Toast.MakeText(this, "全部分类", ToastLength.Short).Show();
            };
            remark_navi.Click += delegate {
                Toast.MakeText(this, "我的收藏", ToastLength.Short).Show();
            };
            setting_navi.Click += delegate {
                Toast.MakeText(this, "用户设定", ToastLength.Short).Show();
            };
        }
    }
}