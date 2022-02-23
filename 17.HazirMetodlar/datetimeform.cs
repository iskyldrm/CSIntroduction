using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17.HazirMetodlar
{
    public partial class datetimeform : Form
    {
        public datetimeform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lblsonuc.Text = DateTime.Now.ToString();
            //lblsonuc.Text = DateTime.Now.ToLongDateString();
            //lblsonuc.Text = DateTime.Now.ToShortDateString();
            //lblsonuc.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

            lblsonuc.Text = DateTime.Now.AddDays(-10).ToString();
        }
    }
}
