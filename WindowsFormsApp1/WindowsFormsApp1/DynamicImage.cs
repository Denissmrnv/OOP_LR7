using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DynamicImage : StaticImage
    {
        public string[] srcPic = new string[] { "D:\\_Stidy_RSATU\\2_Kurs\\blue.jpg", "D:\\_Stidy_RSATU\\2_Kurs\\red.jpg" };
        private Timer timer;
        int i = 0;

        public DynamicImage(System.Windows.Forms.Timer timer)
        {
            this.timer = timer;
            this.timer.Tick += new System.EventHandler(this.change);
        }

        void change(object myobj, System.EventArgs args)
        {
            this.Image = System.Drawing.Image.FromFile(srcPic[i]);
            Invalidate();
            i++;
            if (i > 1)
            {
                i = 0;
            }
        }
    }
}
