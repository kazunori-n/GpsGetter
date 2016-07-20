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
            string lat = e.Position.Location.Latitude.ToString();
            txbLat.Text = lat;
            string lon  = e.Position.Location.Longitude.ToString();
            txbLon.Text = lon;
            string stamp = e.Position.Timestamp.ToString();
            txbTimestamp.Text = stamp;
            string acc = e.Position.Location.HorizontalAccuracy.ToString();
            txbAccuracy.Text = acc;

            string msg = String.Format("{0}, lon:{1}, lat{2}, acc:{3}", stamp, lon, lat, acc);
            AddTextToTextBox(msg);
        }


        private void AddTextToTextBox(string message)
        {
            if(richTextBox1.Lines.Length > 100)
            {
                var idx = richTextBox1.GetFirstCharIndexFromLine(10);
                richTextBox1.Text = richTextBox1.Text.Remove(0, idx);
            }
            richTextBox1.AppendText(DateTime.Now + "\t" + message + Environment.NewLine);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            this.Activate();
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }
    }
}
