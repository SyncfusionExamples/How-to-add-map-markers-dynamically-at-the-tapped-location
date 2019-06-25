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
using MapMarker_Cooridnate;
using MapMarker_Cooridnate.Droid;
using Syncfusion.SfMaps.XForms;
using Syncfusion.SfMaps.XForms.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SfMapExt), typeof(CustomRenderer))]
namespace MapMarker_Cooridnate.Droid
{
    public class CustomRenderer:SfMapsRenderer, Android.Views.View.IOnTouchListener
    {
        SfMapExt sfMapExt;
        public bool OnTouch(Android.Views.View v, MotionEvent e)
        {
            sfMapExt.PointX = e.GetX();
            sfMapExt.PointY = e.GetY();
            sfMapExt.AddMarker();
            return true;
        }
        public override bool OnTouchEvent(MotionEvent e)
        {
            sfMapExt.PointX = e.GetX();
            sfMapExt.PointY = e.GetY();
            sfMapExt.AddMarker();
            return base.OnTouchEvent(e);
        }
        public override bool OnInterceptTouchEvent(MotionEvent ev)
        {
            return ev.ActionMasked == MotionEventActions.Down || ev.ActionMasked == MotionEventActions.Up;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<SfMaps> e)
        {
            sfMapExt = e.NewElement as SfMapExt;
            base.OnElementChanged(e);
            Control.GetChildAt(0).SetOnTouchListener(this);
        }
    }
}