using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Zhy.View.Flowlayout;
using Java.Lang;
using static Com.Zhy.View.Flowlayout.TagAdapter;
using static Com.Zhy.View.Flowlayout.TagFlowLayout;

namespace Caka_App.Activities
{
    public class SingleChooseFragment : Android.Support.V4.App.Fragment, IOnTagClickListener, IOnSelectListener
    {
        private  string[] mVals = new string[]
            {"Hello", "Android", "Weclome Hi ", "Button", "TextView", "Hello",
                    "Android", "Weclome", "Button ImageView", "TextView", "Helloworld",
                    "Android", "Weclome Hello", "Button Text", "TextView"};

        private TagFlowLayout mFlowLayout;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //LayoutInflater mInflater = LayoutInflater.From(Activity);

            //mFlowLayout = mInflate(TagFlowLayout)findViewById(R.id.id_flowlayout);
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            return inflater.Inflate(Resource.Layout.fragment_single_choose, container, false);
            //return base.OnCreateView(inflater, container, savedInstanceState);
        }

     
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            LayoutInflater mInflater = LayoutInflater.From(Activity);
            mFlowLayout = (TagFlowLayout)view.FindViewById(Resource.Id. id_flowlayout);

            mFlowLayout.Adapter = new ItemTagModel(mInflater, mFlowLayout, mVals);
            mFlowLayout.SetOnTagClickListener(this);
            mFlowLayout.SetOnSelectListener(this);
            
        }

        public bool OnTagClick(View view, int position, FlowLayout parent)
        {
            Toast.MakeText(Activity, mVals[position], ToastLength.Short).Show();
            
            return true;
            // throw new NotImplementedException();
        }

        public void OnSelected(ICollection<Integer> p0)
        {
            //throw new NotImplementedException();
            var position = Convert.ToInt32(p0.FirstOrDefault());
            Toast.MakeText(Activity, "Selected"+mVals[position], ToastLength.Short).Show();
        }
    }

    public class ItemTagModel : TagAdapter, IOnDataChangedListener
    {
        public LayoutInflater _mInflater { get; set; }
        private string[] _list { get; set; }

        private ViewGroup _view { get; set; }
        public ItemTagModel(LayoutInflater inflater, ViewGroup v, string[] p0):base(p0)
        {
            _mInflater = inflater;
            _list = p0;
            _view = v;
            
        }
        public override View GetView(FlowLayout parent, int position, Java.Lang.Object s)
        {
            //throw new NotImplementedException();
            TextView tv = (TextView)_mInflater.Inflate(Resource.Layout.tag_item,
                       _view, false);
            tv.Text = s.ToString();// .setText(s);
            return tv;
        }

        public void OnChanged()
        {
            return;
            //throw new NotImplementedException();
        }
    }
}