using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandAQUS.Forms
{
    public partial class Glasses : Form
    {
        private TobiiPROGlasses3 tobiiPROGlasses;
        private PupilCoreForm pupilCore;

        public Glasses()
        {
            InitializeComponent();
            tobiiPROGlasses = new TobiiPROGlasses3();
            pupilCore = new PupilCoreForm();
        }

        private void btnTobbiGlasses_Click(object sender, EventArgs e)
        {
            if (this.tobiiPROGlasses.WindowState == FormWindowState.Minimized)
            {
                this.tobiiPROGlasses.WindowState = FormWindowState.Maximized;
            }
            this.tobiiPROGlasses.Show();
            this.tobiiPROGlasses.TopMost = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.pupilCore.WindowState == FormWindowState.Minimized)
            {
                this.pupilCore.WindowState = FormWindowState.Maximized;
            }
            this.pupilCore.Show();
          //  this.pupilCore.TopMost = true;
        }

        private void Glasses_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Method to control when form has to close, of maximize, minimize.
            this.Hide();
            e.Cancel = true;
        }
    }
}

