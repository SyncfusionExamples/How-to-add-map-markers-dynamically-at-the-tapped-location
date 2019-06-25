using MapMarker_Cooridnate;
using MapMarker_Cooridnate.UWP;
using Syncfusion.SfMaps.XForms;
using Syncfusion.SfMaps.XForms.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(SfMapExt), typeof(CustomRenderer))]
namespace MapMarker_Cooridnate.UWP
{
    public class CustomRenderer:SfMapsRenderer
    {
        SfMapExt sfMapExt;
        protected override void OnElementChanged(ElementChangedEventArgs<SfMaps> e)
        {
            sfMapExt = e.NewElement as SfMapExt;
            base.OnElementChanged(e);
            Control.PointerPressed += Control_PointerPressed;
        }

        private void Control_PointerPressed(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            var position = e.GetCurrentPoint(this).Position;
            sfMapExt.PointX = position.X;
            sfMapExt.PointY = position.Y;
            sfMapExt.AddMarker();
        }
    }
}
