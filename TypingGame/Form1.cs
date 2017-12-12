using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameInit();
        }
        List<Label> la = new List<Label>();
        Point[] poin = new Point[4];
        char[] ch = new char[4];
        private void GameInit()
        {
            Random rd = new Random();
            la.Add(label1);
            la.Add(label2);
            la.Add(label3);
            la.Add(label4);
            for (int i = 0; i < 4; i++)
            {
                poin[i] = new Point(i * 120 + 50, 50);
                la[i].Location = poin[i];
                ch[i] = (char)(rd.Next(0, 26) + 65);
                la[i].Text = ch[i].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            poin[0].Y += 2;
            poin[1].Y += 3;
            poin[2].Y += 4;
            poin[3].Y += 2;
            for (int i = 0; i < 4; i++)
            {
                if (poin[i].Y > this.Height)
                {
                    poin[i].Y = 0;
                }
                la[i].Location = poin[i];
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            for (int i = 0; i < 4; i++)
            {
                if (e.KeyChar.ToString().ToUpper() == la[i].Text)
                {
                    Random rd = new Random();
                    la[i].Visible = false;
                    la[i].Text = ((char)(rd.Next(0, 26) + 65)).ToString();
                    poin[i].Y = 0;
                    la[i].Visible = true;
                    break;
                }
            }
        }
    }
}
