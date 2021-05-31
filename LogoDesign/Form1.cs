using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //set up form name
            this.Text = "Dallas Stars Puck Logo";
            //set up and assign variables for graphics
            Graphics g = this.CreateGraphics();
            Pen greenPen = new Pen(Color.ForestGreen, 8);
            Pen balckPen = new Pen(Color.Black, 40);
            Pen whitePen = new Pen(Color.White, 100);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush greenBrush = new SolidBrush(Color.ForestGreen);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush greyBrush = new SolidBrush(Color.Gray);
            Font drawFont = new Font("Arial Oblique", 130);
            //Clear the screen to white in order to make the hockey puck stand out
            g.Clear(Color.White);
            //Create the puck using an ellispe and FillEllipse
            g.DrawEllipse(balckPen, 150, 30, 500, 500);
            g.FillEllipse(blackBrush, 150, 30, 500, 500);
            //Create the first string and rotate it according to liking
            g.TranslateTransform(320, 200);
            g.RotateTransform(10);
            g.DrawString("D", drawFont, greyBrush, 0, -35);
            g.ResetTransform();
            //Create the second string that overlaps the first and is also rotated
            g.TranslateTransform(320, 200);
            g.RotateTransform(10);
            g.DrawString("D", drawFont, whiteBrush, 10, -40);
            g.ResetTransform();
            //Draw the lines for the Dallas Stars Puck Logo
            g.DrawLine(greenPen, 300, 300, 200, 200);
            g.DrawLine(greenPen, 200, 200, 350, 200);
            g.DrawLine(greenPen, 350, 200, 360, 175);
            g.DrawLine(greenPen, 360, 175, 385, 175);
            g.DrawLine(greenPen, 385, 175, 430, 60);
            g.DrawLine(greenPen, 430, 60, 460, 175);
            g.DrawArc(greenPen, 440, 175, 40, 60, 270, 80);
            g.DrawLine(greenPen, 480, 200, 620, 200);
            g.DrawLine(greenPen, 620, 200, 490, 300);
            g.DrawLine(greenPen, 300, 300, 270, 375);
            g.DrawLine(greenPen, 270, 375, 295, 375);
            g.DrawLine(greenPen, 295, 375, 260, 430);
            g.DrawLine(greenPen, 260, 430, 400, 375);
            g.DrawLine(greenPen, 400, 375, 490, 420);
            g.DrawLine(greenPen, 490, 420, 472, 330);
            g.DrawArc(greenPen, 430, 275, 60, 60, 350, 75);
        }
    }
}
