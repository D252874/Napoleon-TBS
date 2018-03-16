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

        

        Regiment regiment1 = new Regiment("1. infantry");
        Regiment regiment2 = new Regiment("2. infantry");
        Regiment regiment3 = new Regiment("3. infantry");
        Regiment regiment4 = new Regiment("4. infantry");
        Regiment regiment5 = new Regiment("5. infantry");
        Regiment regiment6 = new Regiment("6. infantry");
        Regiment regiment7 = new Regiment("7. infantry");
        Regiment regiment8 = new Regiment("8. infantry");
        Regiment regiment9 = new Regiment("9. infantry");
        Regiment regiment10 = new Regiment("10. infantry");

        Regiment ai_regiment1 = new Regiment("1. infantry");
        Regiment ai_regiment2 = new Regiment("1. infantry");
        Regiment ai_regiment3 = new Regiment("1. infantry");
        Regiment ai_regiment4 = new Regiment("1. infantry");
        Regiment ai_regiment5 = new Regiment("1. infantry");
        Regiment ai_regiment6 = new Regiment("1. infantry");
        Regiment ai_regiment7 = new Regiment("1. infantry");
        Regiment ai_regiment8 = new Regiment("1. infantry");
        Regiment ai_regiment9 = new Regiment("1. infantry");
        Regiment ai_regiment10 = new Regiment("1. infantry");

        


        public Form1()
        {
                
            InitializeComponent();
            LBL_unit1_mp.Text = Convert.ToString(regiment1.GetManpower());
            LBL_unit2_mp.Text = Convert.ToString(regiment2.GetManpower());
            LBL_unit3_mp.Text = Convert.ToString(regiment3.GetManpower());
            LBL_unit4_mp.Text = Convert.ToString(regiment4.GetManpower());
            LBL_unit5_mp.Text = Convert.ToString(regiment5.GetManpower());
            LBL_unit6_mp.Text = Convert.ToString(regiment6.GetManpower());
            LBL_unit7_mp.Text = Convert.ToString(regiment7.GetManpower());
            LBL_unit8_mp.Text = Convert.ToString(regiment8.GetManpower());
            LBL_unit9_mp.Text = Convert.ToString(regiment9.GetManpower());
            LBL_unit10_mp.Text = Convert.ToString(regiment10.GetManpower());

            LBL_unit1_mor.Text = Convert.ToString(regiment1.GetMorale());
            LBL_unit2_mor.Text = Convert.ToString(regiment2.GetMorale());
            LBL_unit3_mor.Text = Convert.ToString(regiment3.GetMorale());
            LBL_unit4_mor.Text = Convert.ToString(regiment4.GetMorale());
            LBL_unit5_mor.Text = Convert.ToString(regiment5.GetMorale());
            LBL_unit6_mor.Text = Convert.ToString(regiment6.GetMorale());
            LBL_unit7_mor.Text = Convert.ToString(regiment7.GetMorale());
            LBL_unit8_mor.Text = Convert.ToString(regiment8.GetMorale());
            LBL_unit9_mor.Text = Convert.ToString(regiment9.GetMorale());
            LBL_unit10_mor.Text = Convert.ToString(regiment10.GetMorale());

            LBL_unit1_name.Text = Convert.ToString(regiment1.GetName());
            LBL_unit2_name.Text = Convert.ToString(regiment2.GetName());
            LBL_unit3_name.Text = Convert.ToString(regiment3.GetName());
            LBL_unit4_name.Text = Convert.ToString(regiment4.GetName());
            LBL_unit5_name.Text = Convert.ToString(regiment5.GetName());
            LBL_unit6_name.Text = Convert.ToString(regiment6.GetName());
            LBL_unit7_name.Text = Convert.ToString(regiment7.GetName());
            LBL_unit8_name.Text = Convert.ToString(regiment8.GetName());
            LBL_unit9_name.Text = Convert.ToString(regiment9.GetName());
            LBL_unit10_name.Text = Convert.ToString(regiment10.GetName());

           
            PB_unit1_smoke.Visible = false;
            PB_unit2_smoke.Visible = false;
            PB_unit3_smoke.Visible = false;
            PB_unit4_smoke.Visible = false;
            PB_unit5_smoke.Visible = false;
            PB_unit6_smoke.Visible = false;
            PB_unit7_smoke.Visible = false;
            PB_unit8_smoke.Visible = false;
            PB_unit9_smoke.Visible = false;
            PB_unit10_smoke.Visible = false;

            PB_ai1_smoke.Visible = false;
            PB_ai2_smoke.Visible = false;
            PB_ai3_smoke.Visible = false;
            PB_ai4_smoke.Visible = false;
            PB_ai5_smoke.Visible = false;
            PB_ai6_smoke.Visible = false;
            PB_ai7_smoke.Visible = false;
            PB_ai8_smoke.Visible = false;
            PB_ai9_smoke.Visible = false;
            PB_ai10_smoke.Visible = false;

            PB_ai1_smoke.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            PB_ai2_smoke.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            PB_ai3_smoke.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            PB_ai4_smoke.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            PB_ai5_smoke.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            PB_ai6_smoke.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            PB_ai7_smoke.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            PB_ai8_smoke.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            PB_ai9_smoke.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            PB_ai10_smoke.Image.RotateFlip(RotateFlipType.Rotate180FlipX);

            BU_unit1_shoot.Enabled = false;
            BU_unit2_shoot.Enabled = false;
            BU_unit3_shoot.Enabled = false;
            BU_unit4_shoot.Enabled = false;
            BU_unit5_shoot.Enabled = false;
            BU_unit6_shoot.Enabled = false;
            BU_unit7_shoot.Enabled = false;
            BU_unit8_shoot.Enabled = false;
            BU_unit9_shoot.Enabled = false;
            BU_unit10_shoot.Enabled = false;


        }

        private void BU_unit1_move_Click(object sender, EventArgs e)
        {
            
            PB_unit1.Location = new Point(PB_unit1.Location.X, PB_unit1.Location.Y - move);
            PB_unit1_smoke.Location = new Point(PB_unit1_smoke.Location.X, PB_unit1_smoke.Location.Y - move);

            regiment1.SetRange(move);
            if (regiment1.CheckRange())
            {
                BU_unit1_shoot.Enabled = true;
            }
            regiment1.Shoot();
            
        }

        private void BU_unit2_move_Click(object sender, EventArgs e)
        {
            PB_unit2.Location = new Point(PB_unit2.Location.X, PB_unit2.Location.Y - move);
            PB_unit2_smoke.Location = new Point(PB_unit2_smoke.Location.X, PB_unit2_smoke.Location.Y - move);

            regiment2.SetRange(move);
            if (regiment2.CheckRange())
            {
                BU_unit2_shoot.Enabled = true;
            }
            regiment2.Shoot();

        }

        private void BU_unit3_move_Click(object sender, EventArgs e)
        {
            PB_unit3.Location = new Point(PB_unit3.Location.X, PB_unit3.Location.Y - move);
            PB_unit3_smoke.Location = new Point(PB_unit3_smoke.Location.X, PB_unit3_smoke.Location.Y - move);

            regiment3.SetRange(move);
            if (regiment3.CheckRange())
            {
                BU_unit3_shoot.Enabled = true;
            }
            regiment3.Shoot();

        }

        private void BU_unit4_move_Click(object sender, EventArgs e)
        {
            PB_unit4.Location = new Point(PB_unit4.Location.X, PB_unit4.Location.Y - move);
            PB_unit4_smoke.Location = new Point(PB_unit4_smoke.Location.X, PB_unit4_smoke.Location.Y - move);

            regiment4.SetRange(move);
            if (regiment4.CheckRange())
            {
                BU_unit4_shoot.Enabled = true;
            }
            regiment4.Shoot();


        }

        private void BU_unit5_move_Click(object sender, EventArgs e)
        {
            PB_unit5.Location = new Point(PB_unit5.Location.X, PB_unit5.Location.Y - move);
            PB_unit5_smoke.Location = new Point(PB_unit5_smoke.Location.X, PB_unit5_smoke.Location.Y - move);

            regiment5.SetRange(move);
            if (regiment5.CheckRange())
            {
                BU_unit5_shoot.Enabled = true;
            }
            regiment5.Shoot();

        }

        private void BU_unit6_move_Click(object sender, EventArgs e)
        {
            PB_unit6.Location = new Point(PB_unit6.Location.X, PB_unit6.Location.Y - move);
            PB_unit6_smoke.Location = new Point(PB_unit6_smoke.Location.X, PB_unit6_smoke.Location.Y - move);

            regiment6.SetRange(move);
            if (regiment6.CheckRange())
            {
                BU_unit6_shoot.Enabled = true;
            }
            regiment6.Shoot();

        }

        private void BU_unit7_move_Click(object sender, EventArgs e)
        {
            PB_unit7.Location = new Point(PB_unit7.Location.X, PB_unit7.Location.Y - move);
            PB_unit7_smoke.Location = new Point(PB_unit7_smoke.Location.X, PB_unit7_smoke.Location.Y - move);

            regiment7.SetRange(move);
            if (regiment7.CheckRange())
            {
                BU_unit7_shoot.Enabled = true;
            }
            regiment7.Shoot();

        }

        private void BU_unit8_move_Click(object sender, EventArgs e)
        {
            PB_unit8.Location = new Point(PB_unit8.Location.X, PB_unit8.Location.Y - move);
            PB_unit8_smoke.Location = new Point(PB_unit8_smoke.Location.X, PB_unit8_smoke.Location.Y - move);

            regiment8.SetRange(move);
            if (regiment8.CheckRange())
            {
                BU_unit8_shoot.Enabled = true;
            }
            regiment8.Shoot();

        }

        private void BU_unit9_move_Click(object sender, EventArgs e)
        {
            PB_unit9.Location = new Point(PB_unit9.Location.X, PB_unit9.Location.Y - move);
            PB_unit9_smoke.Location = new Point(PB_unit9_smoke.Location.X, PB_unit9_smoke.Location.Y - move);

            regiment9.SetRange(move);
            if (regiment9.CheckRange())
            {
                BU_unit9_shoot.Enabled = true;
            }
            regiment9.Shoot();

        }

        private void BU_unit10_move_Click(object sender, EventArgs e)
        {
            PB_unit10.Location = new Point(PB_unit10.Location.X, PB_unit10.Location.Y - move);
            PB_unit10_smoke.Location = new Point(PB_unit10_smoke.Location.X, PB_unit10_smoke.Location.Y - move);

            regiment10.SetRange(move);
            if (regiment10.CheckRange())
            {
                BU_unit10_shoot.Enabled = true;
            }
            regiment10.Shoot();

        }

        private void BU_unit1_shoot_Click(object sender, EventArgs e)
        {
            var t = Task.Delay(500);
            PB_unit1_smoke.Visible = true  ;
            t.Wait();
            PB_unit1_smoke.Visible = false;
        }

        private void BU_unit2_shoot_Click(object sender, EventArgs e)
        {
            var t = Task.Delay(500);
            PB_unit2_smoke.Visible = true;
            t.Wait();
            PB_unit2_smoke.Visible = false;

        }

        private void BU_unit3_shoot_Click(object sender, EventArgs e)
        {
            var t = Task.Delay(500);
            PB_unit3_smoke.Visible = true;
            t.Wait();
            PB_unit3_smoke.Visible = false;
        }

        private void BU_unit4_shoot_Click(object sender, EventArgs e)
        {
            var t = Task.Delay(500);
            PB_unit4_smoke.Visible = true;
            t.Wait();
            PB_unit4_smoke.Visible = false;
        }

        private void BU_unit5_shoot_Click(object sender, EventArgs e)
        {
            var t = Task.Delay(500);
            PB_unit5_smoke.Visible = true;
            t.Wait();
            PB_unit5_smoke.Visible = false;
        }

        private void BU_unit6_shoot_Click(object sender, EventArgs e)
        {
            var t = Task.Delay(500);
            PB_unit6_smoke.Visible = true;
            t.Wait();
            PB_unit6_smoke.Visible = false;
        }

        private void BU_unit7_shoot_Click(object sender, EventArgs e)
        {
            var t = Task.Delay(500);
            PB_unit7_smoke.Visible = true;
            t.Wait();
            PB_unit7_smoke.Visible = false;
        }

        private void BU_unit8_shoot_Click(object sender, EventArgs e)
        {
            var t = Task.Delay(500);
            PB_unit8_smoke.Visible = true;
            t.Wait();
            PB_unit8_smoke.Visible = false;
        }

        private void BU_unit9_shoot_Click(object sender, EventArgs e)
        {
            var t = Task.Delay(500);
            PB_unit9_smoke.Visible = true;
            t.Wait();
            PB_unit9_smoke.Visible = false;
        }

        private void BU_unit10_shoot_Click(object sender, EventArgs e)
        {
            var t = Task.Delay(500);
            PB_unit10_smoke.Visible = true;
            t.Wait();
            PB_unit10_smoke.Visible = false;
        }
    }
}
