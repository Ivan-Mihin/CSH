namespace CSharp
{
    partial class ImageMovementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.movementLabel = new System.Windows.Forms.Label();
            this.movementTextBox = new System.Windows.Forms.TextBox();
            this.OK_Button_ImageMovementForm = new System.Windows.Forms.Button();
            this.Cancel_Button_ImageMovementForm = new System.Windows.Forms.Button();
            this.TextBoxInputCheck_imf = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // movementLabel
            // 
            this.movementLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movementLabel.Location = new System.Drawing.Point(6, 120);
            this.movementLabel.Name = "movementLabel";
            this.movementLabel.Size = new System.Drawing.Size(107, 30);
            this.movementLabel.TabIndex = 3;
            this.movementLabel.Text = "Movement";
            this.movementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movementTextBox
            // 
            this.movementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.movementTextBox.Location = new System.Drawing.Point(118, 120);
            this.movementTextBox.Name = "movementTextBox";
            this.movementTextBox.Size = new System.Drawing.Size(198, 30);
            this.movementTextBox.TabIndex = 4;
            // 
            // OK_Button_ImageMovementForm
            // 
            this.OK_Button_ImageMovementForm.Location = new System.Drawing.Point(118, 255);
            this.OK_Button_ImageMovementForm.Name = "OK_Button_ImageMovementForm";
            this.OK_Button_ImageMovementForm.Size = new System.Drawing.Size(98, 36);
            this.OK_Button_ImageMovementForm.TabIndex = 5;
            this.OK_Button_ImageMovementForm.Text = "OK";
            this.OK_Button_ImageMovementForm.UseVisualStyleBackColor = true;
            this.OK_Button_ImageMovementForm.Click += new System.EventHandler(this.OK_Button_ImageMovementForm_Click);
            // 
            // Cancel_Button_ImageMovementForm
            // 
            this.Cancel_Button_ImageMovementForm.Location = new System.Drawing.Point(222, 255);
            this.Cancel_Button_ImageMovementForm.Name = "Cancel_Button_ImageMovementForm";
            this.Cancel_Button_ImageMovementForm.Size = new System.Drawing.Size(98, 36);
            this.Cancel_Button_ImageMovementForm.TabIndex = 6;
            this.Cancel_Button_ImageMovementForm.Text = "Cancel";
            this.Cancel_Button_ImageMovementForm.UseVisualStyleBackColor = true;
            this.Cancel_Button_ImageMovementForm.Click += new System.EventHandler(this.Cancel_Button_ImageMovementForm_Click);
            // 
            // TextBoxInputCheck_imf
            // 
            this.TextBoxInputCheck_imf.Enabled = true;
            this.TextBoxInputCheck_imf.Interval = 50;
            this.TextBoxInputCheck_imf.Tick += new System.EventHandler(this.TextBoxInputCheck_imf_Tick);
            // 
            // ImageMovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 303);
            this.Controls.Add(this.Cancel_Button_ImageMovementForm);
            this.Controls.Add(this.OK_Button_ImageMovementForm);
            this.Controls.Add(this.movementTextBox);
            this.Controls.Add(this.movementLabel);
            this.Name = "ImageMovementForm";
            this.Text = "ImageMovementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movementLabel;
        private System.Windows.Forms.Button OK_Button_ImageMovementForm;
        private System.Windows.Forms.Button Cancel_Button_ImageMovementForm;
        private System.Windows.Forms.TextBox movementTextBox;
        private System.Windows.Forms.Timer TextBoxInputCheck_imf;
    }
}