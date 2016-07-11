using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;


namespace GpsGetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WatcherStart();
        }

        private void WatcherStart()
        {

            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(GeoPositionChanged);
            watcher.Start();
        }

        private void GeoPositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            txbLat.Text = e.Position.Location.Latitude.ToString();
            txbLon.Text = e.Position.Location.Longitude.ToString();
            txbAccuracy.Text = e.Position.Location.HorizontalAccuracy.ToString();
        }
    }
}
