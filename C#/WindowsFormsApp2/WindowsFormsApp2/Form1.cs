using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        player p1;
        player p2;
        ArrayList objects = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            p1 = new player(player1,this,1,1,5);
            p2 = new player(player2,this,-1,1,5);
            objects.Add(p1);
            objects.Add(p2);
        }
        public bool isClear(PictureBox p, int x, int y)
        {
            foreach (var item in Controls)
            {
                if(typeof(PictureBox) == item.GetType() && p!=item)
                {
                    PictureBox picturebox = (PictureBox)item;
                    Point newPoint = new Point(p.Location.X + x, p.Location.Y + y);
                    Rectangle newRect= new Rectangle(p.Location.X + x, p.Location.Y + y,p.Width, p.Height);
                    if (picturebox.Bounds.IntersectsWith(newRect))
                    {
                        return false;
                    }
                        
                }
               
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            int speed = 5;
            if (e.Shift && progressBar1.Value > 2)
            {
                speed = 10;
                progressBar1.Value--;
            }


            if (e.KeyCode == Keys.Left)
            {
                p1.moveleft();
            }
            if (e.KeyCode == Keys.Right)
            {
                p1.moveright();
            }
            if (e.KeyCode == Keys.Up)
            {
                p1.moveup();
            }
            if (e.KeyCode == Keys.Down)
            {
                p1.movedown();
            }
            if (e.KeyCode == Keys.A)
            {
                p2.moveleft();
            }
            if (e.KeyCode == Keys.D)
            {
                p2.moveright();
            }
            if (e.KeyCode == Keys.W)
            {
                p2.moveup();
            }
            if (e.KeyCode == Keys.S)
            {
                p2.movedown();
                isClear(player1, 5, 5);

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value++;
            foreach (player item in objects)
            {
                if (isClear(item.m_picture,0,5))
                    item.tick();
            }
        }

       
    }
}
