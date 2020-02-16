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
    public partial class ImageMovementForm : Form
    {
        public int NewMovement { get; set; }

        public ImageMovementForm()
        {
            InitializeComponent();
        }

        public ImageMovementForm(int movement)
        {
            InitializeComponent();

            movementTextBox.Text = Convert.ToString(movement);
        }

        private void OK_Button_ImageMovementForm_Click(object sender, EventArgs e)
        {
            NewMovement = Convert.ToInt32(movementTextBox.Text);
            this.Close();
        }

        private void Cancel_Button_ImageMovementForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}