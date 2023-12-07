using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fruit_Machine
{
    public partial class Form1 : Form
    {
        static Image Apple = Fruit_Machine.Properties.Resources.S_M_APPLE;
        static Image Cherry = Fruit_Machine.Properties.Resources.S_M_CHERRY;
        static Image Lemon = Fruit_Machine.Properties.Resources.S_M_LEMON;
        static Image Orange = Fruit_Machine.Properties.Resources.S_M_ORANGE;
        static Image Grape = Fruit_Machine.Properties.Resources.S_M_GRAPE;
        static Image Banana = Fruit_Machine.Properties.Resources.S_M_BANANA;

        Random rnd = new Random();
        int roll1 = 0;
        int roll2 = 0;
        int roll3 = 0;
        int roller1 = 7;
        int roller2 = 7;
        int roller3 = 7;
        int nudge = 0;
        int credits = 20;


        Image[] Fruits = new Image[] { Apple, Cherry, Lemon, Orange, Grape, Banana};
        public Form1()
        {
            InitializeComponent();
            label12.Text = credits.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roller1 = 0;
            if (credits > 0)
            {
                credits--;
                label12.Text = credits.ToString();
                while (roller1 != 7)
                {
                    roller1 = rnd.Next(1, 14);
                    if (roll1 >= 5) { roll1 = -1; }
                    roll1++;
                    if (roll2 >= 5) { roll2 = -1; }
                    roll2++;
                    if (roll3 >= 5) { roll3 = -1; }
                    roll3++;
                    System.Threading.Thread.Sleep(66);
                    pictureBox1.Refresh();
                    pictureBox1.Update();
                    pictureBox2.Refresh();
                    pictureBox2.Update();
                    pictureBox3.Refresh();
                    pictureBox3.Update();
                    pictureBox4.Refresh();
                    pictureBox4.Update();
                    pictureBox5.Refresh();
                    pictureBox5.Update();
                    pictureBox6.Refresh();
                    pictureBox6.Update();
                    pictureBox7.Refresh();
                    pictureBox7.Update();
                    pictureBox8.Refresh();
                    pictureBox8.Update();
                    pictureBox9.Refresh();
                    pictureBox9.Update();
                }

                roller2 = 0;
                while (roller2 != 7)
                {
                    roller2 = rnd.Next(1, 14);
                    if (roll2 >= 5) { roll2 = -1; }
                    roll2++;
                    if (roll3 >= 5) { roll3 = -1; }
                    roll3++;
                    System.Threading.Thread.Sleep(66);
                    pictureBox2.Refresh();
                    pictureBox2.Update();
                    pictureBox3.Refresh();
                    pictureBox3.Update();
                    pictureBox5.Refresh();
                    pictureBox5.Update();
                    pictureBox6.Refresh();
                    pictureBox6.Update();
                    pictureBox8.Refresh();
                    pictureBox8.Update();
                    pictureBox9.Refresh();
                    pictureBox9.Update();
                }

                roller3 = 0;
                while (roller3 != 7)
                {
                    roller3 = rnd.Next(1, 14);
                    if (roll3 >= 5) { roll3 = -1; }
                    roll3++;
                    System.Threading.Thread.Sleep(66);
                    pictureBox3.Refresh();
                    pictureBox3.Update();
                    pictureBox6.Refresh();
                    pictureBox6.Update();
                    pictureBox9.Refresh();
                    pictureBox9.Update();
                }

                if (rnd.Next(1, 10) == 1) { nudge++; }
                label8.Text = nudge.ToString();

                PrizeCheck(ref roll1, ref roll2, ref roll3);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Fruits[roll1], 0, 0, 128, 128);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Fruits[roll2], 0, 0, 128, 128);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Fruits[roll3], 0, 0, 128, 128);
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            if (roll1 <= 0)
            {
                e.Graphics.DrawImage(Fruits[roll1 + 5], 0, 0, 128, 128);
            }
            else { e.Graphics.DrawImage(Fruits[roll1 - 1], 0, 0, 128, 128); }
        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            if (roll2 <= 0)
            {
                e.Graphics.DrawImage(Fruits[roll2 + 5], 0, 0, 128, 128);
            }
            else { e.Graphics.DrawImage(Fruits[roll2 - 1], 0, 0, 128, 128); }
        }

        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            if (roll3 <= 0)
            {
                e.Graphics.DrawImage(Fruits[roll3 + 5], 0, 0, 128, 128);
            }
            else { e.Graphics.DrawImage(Fruits[roll3 - 1], 0, 0, 128, 128); }
        }

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            if (roll1 >= 5)
            {
                e.Graphics.DrawImage(Fruits[roll1 - 5], 0, 0, 128, 128);
            }
            else { e.Graphics.DrawImage(Fruits[roll1 + 1], 0, 0, 128, 128); }
        }

        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            if (roll2 >= 5)
            {
                e.Graphics.DrawImage(Fruits[roll2 - 5], 0, 0, 128, 128);
            }
            else { e.Graphics.DrawImage(Fruits[roll2 + 1], 0, 0, 128, 128); }
        }

        private void pictureBox9_Paint(object sender, PaintEventArgs e)
        {
            if (roll3 >= 5)
            {
                e.Graphics.DrawImage(Fruits[roll3 - 5], 0, 0, 128, 128);
            }
            else { e.Graphics.DrawImage(Fruits[roll3 + 1], 0, 0, 128, 128); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nudge > 0)
            {
                nudge--;
                label8.Text = nudge.ToString();
                if (roll1 >= 5) { roll1 = -1; }
                roll1++;
                pictureBox1.Refresh();
                pictureBox1.Update();
                pictureBox4.Refresh();
                pictureBox4.Update();
                pictureBox7.Refresh();
                pictureBox7.Update();
                PrizeCheck(ref roll1, ref roll2, ref roll3);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nudge > 0)
            {
                nudge--;
                label8.Text = nudge.ToString();
                if (roll2 >= 5) { roll2 = -1; }
                roll2++;
                pictureBox2.Refresh();
                pictureBox2.Update();
                pictureBox5.Refresh();
                pictureBox5.Update();
                pictureBox8.Refresh();
                pictureBox8.Update();
                PrizeCheck(ref roll1, ref roll2, ref roll3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (nudge > 0)
            {
                nudge--;
                label8.Text = nudge.ToString();
                if (roll3 >= 5) { roll3 = -1; }
                roll3++;
                pictureBox3.Refresh();
                pictureBox3.Update();
                pictureBox6.Refresh();
                pictureBox6.Update();
                pictureBox9.Refresh();
                pictureBox9.Update();
                PrizeCheck(ref roll1, ref roll2, ref roll3);
            }
        }

        public void PrizeCheck(ref int roll1, ref int roll2, ref int roll3)
        {
            if (roll3 == 0 && roll2 == 0 && roll1 == 0) //Apple
            {
                credits += 20;
            }
            else if (roll3 == 1 && roll2 == 1 && roll1 == 1) //Cherry
            {
                credits += 250;
            }
            else if (roll3 == 2 && roll2 == 2 && roll1 == 2) //Lemon
            {
                credits += 30;
            }
            else if (roll3 == 3 && roll2 == 3 && roll1 == 3) //Orange
            {
                credits += 30;
            }
            else if (roll3 == 4 && roll2 == 4 && roll1 == 4) //Grape
            {
                credits += 50;
            }
            else if (roll3 == 5 && roll2 == 5 && roll1 == 5) //Banana
            {
                credits += 100;
            }
            label12.Text = credits.ToString();
        }
    }
}
