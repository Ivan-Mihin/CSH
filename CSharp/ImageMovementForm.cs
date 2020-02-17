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

        private static bool IsDigitsOnly(string input)
        {
            if (string.Compare(input, "0") == 0 || string.Compare(input, "") == 0)
            {
                return false;
            }

            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            return true;
        }

        private void TextBoxInputCheck_imf_Tick(object sender, EventArgs e)
        {
            if (IsDigitsOnly(movementTextBox.Text))
            {
                OK_Button_ImageMovementForm.Enabled = true;
            }
            else
            {
                OK_Button_ImageMovementForm.Enabled = false;
            }
        }

        private void OK_Button_ImageMovementForm_Click(object sender, EventArgs e)
        {
            try
            {
                NewMovement = Convert.ToInt32(movementTextBox.Text);

                this.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + '\n' + "Please enter a natural number.");
            }
        }

        private void Cancel_Button_ImageMovementForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}