using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDREBOND
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void onClickImg1(object sender, EventArgs e)
        {

        }

        private void onClickImg2(object sender, EventArgs e)
        {

        }

        private void onClickImg3(object sender, EventArgs e)
        {

        }

        private void onClickImg4(object sender, EventArgs e)
        {

        }

        private void onClickImg5(object sender, EventArgs e)
        {

        }

        private void onClickNext(object sender, EventArgs e)
        {
            StatsForm page = new StatsForm();

            page.Show();
            this.Hide();
        }
    }
}
