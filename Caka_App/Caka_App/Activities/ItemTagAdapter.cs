using System;

using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using Com.Zhy.View.Flowlayout;
using Java.Lang;

namespace Caka_App.Activities
{
    public class ItemTagAdapter
    {
        //    public event EventHandler<ItemTagAdapterClickEventArgs> ItemClick;
        //    public event EventHandler<ItemTagAdapterClickEventArgs> ItemLongClick;
        //    string[] items;

        //    public ItemTagAdapter(string[] data)
        //    {
        //        items = data;
        //    }

        //    // Create new views (invoked by the layout manager)
        //    public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        //    {

        //        //Setup your layout here
        //        View itemView = null;
        //        //var id = Resource.Layout.__YOUR_ITEM_HERE;
        //        //itemView = LayoutInflater.From(parent.Context).
        //        //       Inflate(id, parent, false);

        //        var vh = new ItemTagAdapterViewHolder(itemView, OnClick, OnLongClick);
        //        return vh;
        //    }

        //    // Replace the contents of a view (invoked by the layout manager)
        //    public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        //    {
        //        var item = items[position];

        //        // Replace the contents of the view with that element
        //        var holder = viewHolder as ItemTagAdapterViewHolder;
        //        //holder.TextView.Text = items[position];
        //    }

        //    public override int Count => items.Length;

        //    void OnClick(ItemTagAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        //    void OnLongClick(ItemTagAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

        //    public override View GetView(FlowLayout p0, int p1, Java.Lang.Object p2)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //public class ItemTagAdapterViewHolder : RecyclerView.ViewHolder
        //{
        //    //public TextView TextView { get; set; }


        //    public ItemTagAdapterViewHolder(View itemView, Action<ItemTagAdapterClickEventArgs> clickListener,
        //                        Action<ItemTagAdapterClickEventArgs> longClickListener) : base(itemView)
        //    {
        //        //TextView = v;
        //        itemView.Click += (sender, e) => clickListener(new ItemTagAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
        //        itemView.LongClick += (sender, e) => longClickListener(new ItemTagAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
        //    }
        //}

        //public class ItemTagAdapterClickEventArgs : EventArgs
        //{
        //    public View View { get; set; }
        //    public int Position { get; set; }
        //}
    }
}