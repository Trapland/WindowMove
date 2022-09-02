using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left && this.Location.X > 0)
                this.Location = new Point(this.Location.X - 50, this.Location.Y);
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right && this.Location.X + this.Width < Screen.PrimaryScreen.Bounds.Width)
                this.Location = new Point(this.Location.X + 50, this.Location.Y);
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up && this.Location.Y > 0)
                this.Location = new Point(this.Location.X, this.Location.Y - 50);
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down && this.Location.Y + this.Height < Screen.PrimaryScreen.Bounds.Height)
                this.Location = new Point(this.Location.X, this.Location.Y + 50);
        }
    }
}
