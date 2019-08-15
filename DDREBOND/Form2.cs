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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

     

        private void OnClickRandom(object sender, EventArgs e)
        {
            //Changes a single stat
        }

        private void OnClickRandomAll(object sender, EventArgs e)
        {
            //Changes all stats
        }

        private void OnClickPrint(object sender, EventArgs e)
        {
            //Opens file explorer to save to a file
        }
        //back to previous form
        private void OnClickBack(object sender, EventArgs e)
        {
           
            HomePage page = new HomePage();
            page.Show();
            this.Hide();
         
        }

        private void OnClickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
