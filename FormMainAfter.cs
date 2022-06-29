using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DangKyTinChi
{
    public partial class frmMainAfter : Form
    {
        public frmMainAfter()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.logoNEU;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kếtQuảĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngKýHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void hướngDẫnĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDKHP f = new frmDKHP();
            f.Show();
        }

        private void kếtQuảĐăngKýToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmKQDK f = new frmKQDK();
            f.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainAfter f = new frmMainAfter();
            f.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTTCB f = new frmTTCB();
            f.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
        }
    }
}
