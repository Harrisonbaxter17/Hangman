using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        enum BodyParts
        // this stores the different body parts used for the hangman character.
        {
            Head,
            Left_Eye,
            Right_Eye,
            Mouth,
            Right_Arm,
            Left_Arm,
            Body,
            Right_Leg,
            Left_Leg
        }
        void DrawHangPost()
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Brown, 10);
            g.DrawLine(p, new Point(130, 218), new Point(130, 5));
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            g.DrawLine(p, new Point(60, 0), new Point(60, 5));
            DrawBodyPart(BodyParts.Head);
            DrawBodyPart(BodyParts.Left_Eye);
        }
        
        void DrawBodyPart(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);
            if (bp == BodyParts.Head)
                g.DrawEllipse(p, 40, 50, 40, 40);
            else if (bp == BodyParts.Left_Eye)
        }
        
        
         
        











        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
