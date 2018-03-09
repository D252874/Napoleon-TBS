using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napoleon_TBS
{
    public partial class Form1 : Form
    {

        int move = 10;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void BU_unit1_move_Click(object sender, EventArgs e)
        {
            
            PB_unit1.Location = new Point(PB_unit1.Location.X, PB_unit1.Location.Y - move);
        }

        private void BU_unit2_move_Click(object sender, EventArgs e)
        {
            PB_unit2.Location = new Point(PB_unit2.Location.X, PB_unit2.Location.Y - move);
        }

        private void BU_unit3_move_Click(object sender, EventArgs e)
        {
            PB_unit3.Location = new Point(PB_unit3.Location.X, PB_unit3.Location.Y - move);
        }

        private void BU_unit4_move_Click(object sender, EventArgs e)
        {
            PB_unit4.Location = new Point(PB_unit4.Location.X, PB_unit4.Location.Y - move);

        }

        private void BU_unit5_move_Click(object sender, EventArgs e)
        {
            PB_unit5.Location = new Point(PB_unit5.Location.X, PB_unit5.Location.Y - move);

        }

        private void BU_unit6_move_Click(object sender, EventArgs e)
        {
            PB_unit6.Location = new Point(PB_unit6.Location.X, PB_unit6.Location.Y - move);

        }

        private void BU_unit7_move_Click(object sender, EventArgs e)
        {
            PB_unit7.Location = new Point(PB_unit7.Location.X, PB_unit7.Location.Y - move);

        }

        private void BU_unit8_move_Click(object sender, EventArgs e)
        {
            PB_unit8.Location = new Point(PB_unit8.Location.X, PB_unit8.Location.Y - move);
        }

        private void BU_unit9_move_Click(object sender, EventArgs e)
        {
            PB_unit9.Location = new Point(PB_unit9.Location.X, PB_unit9.Location.Y - move);

        }

        private void BU_unit10_move_Click(object sender, EventArgs e)
        {
            PB_unit10.Location = new Point(PB_unit10.Location.X, PB_unit10.Location.Y - move);

        }
    }
}
