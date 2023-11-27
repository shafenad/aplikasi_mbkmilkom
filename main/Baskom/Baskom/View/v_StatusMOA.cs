using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskom.View
{
    partial class v_StatusMOA : Form
    {
        c_Dashboard c_Dashboard;
        public v_StatusMOA(c_Dashboard c_Dashboard)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
        }
        private void btn_simpanstatus_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardMahasiswa();
        }
        private void statusmitra_Load(object sender, EventArgs e)
        {

        }
    }
}
