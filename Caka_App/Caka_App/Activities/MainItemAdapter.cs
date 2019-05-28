using System;

using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using Caka_App.Widget;

namespace Caka_App.Activities
{
    public class MainItemAdapter : RecyclerView.Adapter
    {
        public event EventHandler<MainItemAdapterClickEventArgs> ItemClick;
        public event EventHandler<MainItemAdapterClickEventArgs> ItemLongClick;
        //string[] items;
        public List<string> items = new List<string>();
        public MainItemAdapter(List<string> data)
        {
            items = data;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            #region Old
            ////Setup your layout here
            //View itemView = null;
            ////var id = Resource.Layout.__YOUR_ITEM_HERE;
            ////itemView = LayoutInflater.From(parent.Context).
            ////       Inflate(id, parent, false);
            //var vh = new MainItemAdapterViewHolder(itemView, OnClick, OnLongClick);
            //return vh;
            #endregion

            #region Create Layout
            LayoutInflater inflater = LayoutInflater.From(parent.Context);
            View itemView = null;
            itemView = inflater.Inflate(Resource.Layout.main_content_item, parent, false); //layout_item
            var vh = new MainItemAdapterViewHolder(itemView, OnClick, OnLongClick);
            return vh;
            #endregion
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            #region Old
            //var item = items[position];
            //// Replace the contents of the view with that element
            //var holder = viewHolder as MainItemAdapterViewHolder;
            ////holder.TextView.Text = items[position];
            #endregion
            
            var holder = viewHolder as MainItemAdapterViewHolder;
            holder._v_title.Text = "【国 创】 人气推荐上";
            holder.ItemView.Click += delegate
            {
                //Toast.MakeText(holder.ItemView.Context, "item" + title + " 被点击了", ToastLength.Short).Show();
                holder._v_title.Text += "G";

                NotifyItemChanged(position);
                
            };
        }

        public override int ItemCount => items.Count;

        void OnClick(MainItemAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(MainItemAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class MainItemAdapterViewHolder : RecyclerView.ViewHolder
    {
        public TextView _v_time { get; set; }
        public TextView _v_comment { get; set; }
        public TextView _v_collect { get; set; }
        public TextView _v_title { get; set; }
        public ImageViewPlus imagePlus { get; set; }
        public MainItemAdapterViewHolder(View itemView, Action<MainItemAdapterClickEventArgs> clickListener,
                            Action<MainItemAdapterClickEventArgs> longClickListener) : base(itemView)
        {
            _v_title = (TextView)itemView.FindViewById(Resource.Id.v_title);
            _v_time = itemView.FindViewById<TextView>(Resource.Id.v_time);
            _v_comment = itemView.FindViewById<TextView>(Resource.Id.v_commont);
            _v_collect = itemView.FindViewById<TextView>(Resource.Id.v_collect);
            imagePlus = itemView.FindViewById<ImageViewPlus>(Resource.Id.roundRect);
            imagePlus.SetType(ImageViewPlus.TYPE_ROUND);
            imagePlus.SetRoundRadius(120);

            itemView.Click += (sender, e) => clickListener(new MainItemAdapterClickEventArgs
            {
                View = itemView,
                Position = AdapterPosition
            });
            itemView.LongClick += (sender, e) => longClickListener(new MainItemAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
        }
    }

    public class MainItemAdapterClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}