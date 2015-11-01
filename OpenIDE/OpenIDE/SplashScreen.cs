using OpenIDE.Core;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace OpenIDE
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        //Use timer class
        Timer tmr;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 3 sec
            tmr.Interval = 3000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            Workspace.PluginManager = new PluginManager();
            
            //after 3 sec stop the timer
            tmr.Stop();
            //display mainform

            if (Updater.IsUpdateAvailable())
            {
                Updater.Update();
            }

            LanguageManager.Init(CultureInfo.GetCultureInfo("en-US"));

            Form1 mf = new Form1();
            mf.Show();
            //hide this form
            Hide();
        }
    }
}