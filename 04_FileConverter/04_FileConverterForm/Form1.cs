using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_FileConverterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxPath.Text = openFileDialog.FileName;
                cmbBoxSource.Text = Path.GetExtension(openFileDialog.FileName);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cmbBoxDest.SelectedIndex >= 0)
            {
                FileConversionManager.Convert(openFileDialog.FileName, Path.GetExtension(openFileDialog.FileName), cmbBoxDest.Text);
                MessageBox.Show("Uzantı değiştirme işlemi tamamlandı", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR!");
            }
        }
    }
}
