using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp
{
    public partial class MainForm : Form
    {
        public int Movement { get; set; } = 5;

        bool key_UpArrow,    key_W = false;
        bool key_LeftArrow,  key_A = false;
        bool key_DownArrow,  key_S = false;
        bool key_RightArrow, key_D = false;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                key_UpArrow = true;
                key_W = true;
                ImageMovement();
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                key_LeftArrow = true;
                key_A = true;
                ImageMovement();
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                key_DownArrow = true;
                key_S = true;
                ImageMovement();
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                key_RightArrow = true;
                key_D = true;
                ImageMovement();
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                key_UpArrow = false;
                key_W = false;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                key_LeftArrow = false;
                key_A = false;
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                key_DownArrow = false;
                key_S = false;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                key_RightArrow = false;
                key_D = false;
            }
        }

        void ImageMovement()
        {
            if (key_UpArrow || key_W)
            {
                if (bitmapSlika.Location.Y - Movement > 0)
                {
                    bitmapSlika.Location = new Point(bitmapSlika.Location.X, bitmapSlika.Location.Y - Movement);
                }
            }

            if (key_LeftArrow || key_A)
            {
                if (bitmapSlika.Location.X - Movement > 0)
                {
                    bitmapSlika.Location = new Point(bitmapSlika.Location.X - Movement, bitmapSlika.Location.Y);
                }
            }

            if (key_DownArrow || key_S)
            {
                if (bitmapSlika.Location.Y + Movement < background.Height - bitmapSlika.Height)
                {
                    bitmapSlika.Location = new Point(bitmapSlika.Location.X, bitmapSlika.Location.Y + Movement);
                }
            }

            if (key_RightArrow || key_D)
            {
                if (bitmapSlika.Location.X + Movement < background.Width - bitmapSlika.Width)
                {
                    bitmapSlika.Location = new Point(bitmapSlika.Location.X + Movement, bitmapSlika.Location.Y);
                }
            }
        }

        private void ImageResizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ImageMovementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}