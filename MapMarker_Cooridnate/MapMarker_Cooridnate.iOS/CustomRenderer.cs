using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MapMarker_Cooridnate;
using MapMarker_Cooridnate.iOS;
using Syncfusion.SfMaps.XForms;
using Syncfusion.SfMaps.XForms.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SfMapExt), typeof(CustomRenderer))]
namespace MapMarker_Cooridnate.iOS
{
    public class CustomRenderer:SfMapsRenderer
    {
        SfMapExt sfMapExt;
        protected override void OnElementChanged(ElementChangedEventArgs<SfMaps> e)
        {
            sfMapExt = e.NewElement as SfMapExt;
            base.OnElementChanged(e);
        }
        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            var touch = touches.AnyObject as UITouch;
            sfMapExt.PointX = touch.LocationInView(this).X;
            sfMapExt.PointY = touch.LocationInView(this).Y;
            sfMapExt.AddMarker();
            base.TouchesBegan(touches, evt);
        }
    }
}