﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    class Chaser : Sprite
    {
        int m_xdir = 0;
        int m_ydir = 0;
        public Chaser(PictureBox picture) : base(picture)
        {
        }
        public override bool collision(PictureBox other)
        {
            return false;
        }
        public override void tick()
        {
            Sprite other = m_parent.getSpriteByName("Ballpicture");
          
            if (other.m_location.X < this.m_location.X)
                m_xdir = -6;
            else
                m_xdir = 6;
            if (other.m_location.Y < this.m_location.Y)
                m_ydir = -6;
            else
                m_ydir = 6;
           
            move(m_xdir, m_ydir);

        }
    }
}
