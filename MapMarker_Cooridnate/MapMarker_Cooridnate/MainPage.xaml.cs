using Syncfusion.SfMaps.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MapMarker_Cooridnate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class CustomMarker:MapMarker
    {
        public ImageSource Image { get; set; }
        public CustomMarker()
        {
            Image = ImageSource.FromResource("MapMarker_Cooridnate.pin.png");
        }
    }
    public class SfMapExt : SfMaps
    {
        public double PointX { get; set; }
        public double PointY { get; set; }

        public SfMapExt()
        {
            
        }

        public void AddMarker()
        {
            var layer = this.Layers[0];
            Point longitudeLatitude = layer.GetLatLonFromPoint(new Point(PointX,PointY));
            layer.Markers.Add(new CustomMarker()
            {
                Latitude = longitudeLatitude.Y.ToString(),
                Longitude = longitudeLatitude.X.ToString()
            });
        }
    }
}
