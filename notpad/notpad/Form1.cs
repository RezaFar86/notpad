using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notpad
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void بازکردنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ذخیرهکردنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ذخیرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void بازکردنToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            txtmain.Text = System.IO.File.ReadAllText(o.FileName);
        }

        private void تنظیماترنگبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            txtmain.BackColor = c.Color;
        }

        private void تنظیماترنگفونتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            txtmain.ForeColor = c.Color;
        }

        private void تنظیماتخودفونتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.ShowDialog();
            txtmain.Font = f.Font;
        }

        private void txtmain_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.ShowDialog();
            System.IO.File.WriteAllText(s.FileName, txtmain.Text);
        }

        private void جدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
