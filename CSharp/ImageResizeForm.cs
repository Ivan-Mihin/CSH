using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp
{
    public partial class ImageResizeForm : Form
    {
        public Image NewBitmap { get; set; }

        public ImageResizeForm()
        {
            InitializeComponent();
        }

        public ImageResizeForm(Image image, int width, int height)
        {
            InitializeComponent();

            NewBitmap = image;

            widthTextBox.Text = Convert.ToString(width);
            heightTextBox.Text = Convert.ToString(height);
        }

        private static Image ResizeImage(Image bitmap, int width, int height)
        {
            Image resizedBitmap = new Bitmap(width, height);

            using (Graphics GFX = Graphics.FromImage((Bitmap)resizedBitmap))
            {
                GFX.DrawImage(bitmap, new Rectangle(0, 0, width, height));
            }

            return resizedBitmap;
        }

        private void OK_Button_ImageResizeForm_Click(object sender, EventArgs e)
        {
            NewBitmap = ResizeImage(NewBitmap, Convert.ToInt32(widthTextBox.Text), Convert.ToInt32(heightTextBox.Text));
            this.Close();
        }

        private void Cancel_Button_ImageResizeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}