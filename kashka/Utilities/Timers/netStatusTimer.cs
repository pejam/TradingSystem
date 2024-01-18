using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;
using System.Net.NetworkInformation;

namespace Tax.Timers
{
    static internal class netStatusTimer
    {
       public static void SetUp(ToolStripStatusLabel toolStripStatusLabel, int milisecond)
        {
            _toolStripStatusLabel = toolStripStatusLabel;
            _timer.Interval = milisecond; // 1000 milisecond = 1 seconds
            _timer.Tick += IsInternetAvailable;
        }
     
        private static void IsInternetAvailable(object sender, EventArgs e)
        {
            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send("www.google.com", 2000); // Ping google.com with a 2 second timeout

                    if (reply.Status == IPStatus.Success)
                    {
                        _toolStripStatusLabel.Text = "وضعیت شبکه : متصل";
                        _toolStripStatusLabel.ForeColor = Color.Black;
                        return;
                    }
                }
            }
            catch
            {
                // Ignore exceptions, just return false
            }

            _toolStripStatusLabel.Text = "وضعیت شبکه : قطع";
            _toolStripStatusLabel.ForeColor = Color.Red;

        }
        public static void start()
        {
            _timer.Start();
        }

        private static readonly Timer _timer = new Timer();
        private static ToolStripStatusLabel _toolStripStatusLabel;
    }

}
