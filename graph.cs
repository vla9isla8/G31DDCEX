using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G31DDCExample
{
    public partial class graph : Form
    {
        #region Members

        public float[] IQData;

        public MainForm MForm;

        #endregion

        public graph(MainForm form)
        {
            MForm = form;

            InitializeComponent();
        }

        private void graph_Load(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            IQData = MForm.BUFFER;

            Point[] apt = new Point[IQData.Length/2];

            for (int i = 0; i < IQData.Length; i++)
            {
                apt[i/2] = new Point((int)(200+IQData[i] * 400), (int)(200-IQData[++i] * 400));
            }
            e.Graphics.DrawCurve(System.Drawing.Pens.Black, apt);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
