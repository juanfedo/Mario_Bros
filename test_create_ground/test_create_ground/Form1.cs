using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_create_ground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _RandomGround ground = new _RandomGround();
            ground.Start();
            foreach (Tuple<float, float> t in _Parameters.Coord_ground)            
                label1.Text += t.First.ToString() + ":" + t.Second.ToString() + " , ";
            _RandomSoild soild = new _RandomSoild();
            soild.Start();
            _RandomGoomba goomba = new _RandomGoomba();
            goomba.Start();
            _RandomPipe pipe = new _RandomPipe();
            pipe.Start();
        }
    }
}