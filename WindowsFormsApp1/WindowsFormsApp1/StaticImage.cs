using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class StaticImage : System.Windows.Forms.PictureBox
    {
        public StaticImage()
        {
            this.Image = System.Drawing.Image.FromFile("D:\\_Stidy_RSATU\\2_Kurs\\red.jpg");
        }
    }
}
