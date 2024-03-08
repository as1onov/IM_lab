using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double height, angle, speed, size, weight, dt;
        double t, v, x, y, v0, vx, vy, cosa, sina, S, m, k;

        private void textBox_step_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_Distance_Click(object sender, EventArgs e)
        {

        }

        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;
        double ymax = 0;
        private void button_start_Click(object sender, EventArgs e)
        {
            height = (double)edHeight.Value;
            angle = (double)edAngle.Value;
            speed = (double)edSpeed.Value;
            S = (double)edSize.Value;
            m = (double)edWeight.Value;
            dt = (double)edStep.Value;
            t = 0;
            x = 0;
            y = height;
            v0 = speed;
            angle = angle * Math.PI / 180;
            cosa = Math.Cos(angle);
            sina = Math.Sin(angle);

            k = 0.5 * C * rho * S / m; 
            vx = v0* cosa;
            vy= v0* sina;

            chart1.Series[0].Points.AddXY(x, y);
            timer1.Start();

        
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            t += dt;

            v = (double)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            
            if (ymax < y) ymax = y;

            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0) timer1.Stop();
            
            textBox_step.Text = "" + dt;
            textBox_distance.Text = "" + x;
            textBox_max_height.Text = "" + ymax;
            textBox1_speed_end_point.Text = "" + v;


        }

 



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void height_Click(object sender, EventArgs e)
        {

        }

        private void edHeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
