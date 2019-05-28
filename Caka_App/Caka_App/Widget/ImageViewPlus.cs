using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Util;
using Android.Widget;
using System;
using static Android.Graphics.Shader;

namespace Caka_App.Widget
{
    public class ImageViewPlus : ImageView
    {
        private Paint mPaint;

        private int mWidth;

        //private int mHeight;

        private int mRadius;//圆半径

        private RectF mRect;//矩形凹行大小

        private int mRoundRadius;// 圆角大小

        private BitmapShader mBitmapShader;//图形渲染

        private Matrix mMatrix;

        private int mType;// 记录是圆形还是圆角矩形

        public static int TYPE_CIRCLE = 0;// 圆形
        public static int TYPE_ROUND = 1;// 圆角矩形
        public static int TYPE_OVAL = 2;//椭圆形
        public static int DEFAUT_ROUND_RADIUS = 10;//默认圆角大小

        public ImageViewPlus(Context context) : base(context)
        {
            // TODO Auto-generated constructor stub
            InitView();
        }

        public ImageViewPlus(Context context, IAttributeSet attrs) : base(context, attrs)
        {

            // TODO Auto-generated constructor stub
            InitView();
        }

        public ImageViewPlus(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {
            InitView();
        }

        private void InitView()
        {
            mPaint = new Paint();
            mPaint.AntiAlias = true;

            mMatrix = new Matrix();
            mRoundRadius = DEFAUT_ROUND_RADIUS;
        }


        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            // TODO Auto-generated method stub
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            // 如果是绘制圆形，则强制宽高大小一致
            if (mType == TYPE_CIRCLE)
            {
                mWidth = Math.Min(MeasuredWidth, MeasuredHeight);
                mRadius = mWidth / 2;
                SetMeasuredDimension(mWidth, mWidth);
            }

        }
        protected override void OnDraw(Canvas canvas)
        {

            if (null == Drawable)
            {
                return;
            }
            SetBitmapShader();
            if (mType == TYPE_CIRCLE)
            {
                canvas.DrawCircle(mRadius, mRadius, mRadius, mPaint);
            }
            else if (mType == TYPE_ROUND)
            {
                mPaint.Color = Color.White;//  SetColor(Color.RED);
                canvas.DrawRoundRect(mRect, mRoundRadius, mRoundRadius, mPaint);
            }
            else if (mType == TYPE_OVAL)
            {
                canvas.DrawOval(mRect, mPaint);
            }
        }

        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            // TODO Auto-generated method stub
            base.OnSizeChanged(w, h, oldw, oldh);
            mRect = new RectF(0, 0, Width, Height);
        }

        /**
         * 设置BitmapShader
         */
        private void SetBitmapShader()
        {
            Drawable drawable = Drawable;
            if (null == drawable)
            {
                return;
            }
            Bitmap bitmap = DrawableToBitmap(drawable);
            // 将bitmap作为着色器来创建一个BitmapShader
            mBitmapShader = new BitmapShader(bitmap, TileMode.Clamp, TileMode.Clamp);
            float scale = 1.0f;
            if (mType == TYPE_CIRCLE)
            {
                // 拿到bitmap宽或高的小值
                int bSize = Math.Min(bitmap.Width, bitmap.Height);
                scale = mWidth * 1.0f / bSize;

            }
            else if (mType == TYPE_ROUND || mType == TYPE_OVAL)
            {
                // 如果图片的宽或者高与view的宽高不匹配，计算出需要缩放的比例；缩放后的图片的宽高，一定要大于我们view的宽高；所以我们这里取大值；
                scale = Math.Max(Width * 1.0f / bitmap.Width, Height * 1.0f / bitmap.Height);
            }
            // shader的变换矩阵，我们这里主要用于放大或者缩小
            mMatrix.SetScale(scale, scale);
            // 设置变换矩阵
            mBitmapShader.SetLocalMatrix(mMatrix);
            mPaint.SetShader(mBitmapShader);

        }

        /**
         * drawable转bitmap
         * 
         * @param drawable
         * @return
         */
        [Obsolete]
        private Bitmap DrawableToBitmap(Drawable drawable)
        {
            if (drawable is BitmapDrawable)
            {
                BitmapDrawable bitmapDrawable = (BitmapDrawable)drawable;
                return bitmapDrawable.Bitmap;//.GetBitmap();
            }
            int w = drawable.IntrinsicWidth;// GetIntrinsicWidth();
            int h = drawable.IntrinsicHeight;//.getIntrinsicHeight();
            Bitmap bitmap = Bitmap.CreateBitmap(w, h, Bitmap.Config.Argb8888);
            Canvas canvas = new Canvas(bitmap);
            drawable.SetBounds(0, 0, w, h);
            drawable.Draw(canvas);
            return bitmap;
        }
        /**
         * 单位dp转单位px
         */
        //public int DpTodx(int dp)
        //{

        //    return (int)TypedValue.ApplyDimension(TypedValue.c.COMPLEX_UNIT_DIP,
        //            dp, Resources().getDisplayMetrics());
        //}

        //public int GetType()
        //{
        //    return mType;
        //}
        /**
         * 设置图片类型：圆形、圆角矩形、椭圆形
         * @param mType
         */
        public void SetType(int mType)
        {
            if (this.mType != mType)
            {
                this.mType = mType;
                Invalidate();
            }

        }
        public int GetRoundRadius()
        {
            return mRoundRadius;
        }
        /**
         * 设置圆角大小
         * @param mRoundRadius
         */
        public void SetRoundRadius(int mRoundRadius)
        {
            if (this.mRoundRadius != mRoundRadius)
            {
                this.mRoundRadius = mRoundRadius;
                Invalidate();
            }

        }
    }
}