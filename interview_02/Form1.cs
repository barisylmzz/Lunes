using IFilter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interview_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            ImageFilter imgF = new ImageFilter();
            if (comboBox1.SelectedIndex == 0)
            {
                
                pictureBox2.Image = imgF.FilteredImage_Red(img);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
              
                pictureBox2.Image = imgF.FilteredImage_Gray(img);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
               
                pictureBox2.Image = imgF.MovingAverageFilter(img);
            }
        }
        
        
    }
}
