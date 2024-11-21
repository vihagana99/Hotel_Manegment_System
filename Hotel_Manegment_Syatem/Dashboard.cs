using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Manegment_Syatem
{
    public partial class Dashboard : Form
    {
        public object MovingPanel3 { get; private set; }

        public Dashboard()
        {
            InitializeComponent();
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void registration_Click(object sender, EventArgs e)
        {
            panelM.Left = registration.Left + 28;
        }

        private void add_room_Click(object sender, EventArgs e)
        {
            panelM.Left = add_room.Left-6;

        }

        private void check_out_Click(object sender, EventArgs e)
        {
            panelM.Left = check_out.Left;
        }

        private void details_Click(object sender, EventArgs e)
        {
            panelM.Left = details.Left+19;
        }

        private void employee_Click(object sender, EventArgs e)
        {
            panelM.Left = employee.Left+10;
        }
    }
}
