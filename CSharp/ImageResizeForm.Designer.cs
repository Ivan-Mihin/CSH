namespace CSharp
{
    partial class ImageResizeForm
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
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.OK_Button_ImageResizeForm = new System.Windows.Forms.Button();
            this.Cancel_Button_ImageResizeForm = new System.Windows.Forms.Button();
            this.TextBoxInputCheck_irf = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // widthTextBox
            // 
            this.widthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.widthTextBox.Location = new System.Drawing.Point(109, 73);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(198, 30);
            this.widthTextBox.TabIndex = 0;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.heightTextBox.Location = new System.Drawing.Point(109, 154);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(198, 30);
            this.heightTextBox.TabIndex = 1;
            // 
            // widthLabel
            // 
            this.widthLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(12, 73);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(80, 30);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightLabel
            // 
            this.heightLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(12, 154);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(80, 30);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OK_Button_ImageResizeForm
            // 
            this.OK_Button_ImageResizeForm.Location = new System.Drawing.Point(118, 255);
            this.OK_Button_ImageResizeForm.Name = "OK_Button_ImageResizeForm";
            this.OK_Button_ImageResizeForm.Size = new System.Drawing.Size(98, 36);
            this.OK_Button_ImageResizeForm.TabIndex = 4;
            this.OK_Button_ImageResizeForm.Text = "OK";
            this.OK_Button_ImageResizeForm.UseVisualStyleBackColor = true;
            this.OK_Button_ImageResizeForm.Click += new System.EventHandler(this.OK_Button_ImageResizeForm_Click);
            // 
            // Cancel_Button_ImageResizeForm
            // 
            this.Cancel_Button_ImageResizeForm.Location = new System.Drawing.Point(222, 255);
            this.Cancel_Button_ImageResizeForm.Name = "Cancel_Button_ImageResizeForm";
            this.Cancel_Button_ImageResizeForm.Size = new System.Drawing.Size(98, 36);
            this.Cancel_Button_ImageResizeForm.TabIndex = 5;
            this.Cancel_Button_ImageResizeForm.Text = "Cancel";
            this.Cancel_Button_ImageResizeForm.UseVisualStyleBackColor = true;
            this.Cancel_Button_ImageResizeForm.Click += new System.EventHandler(this.Cancel_Button_ImageResizeForm_Click);
            // 
            // TextBoxInputCheck_irf
            // 
            this.TextBoxInputCheck_irf.Enabled = true;
            this.TextBoxInputCheck_irf.Interval = 50;
            this.TextBoxInputCheck_irf.Tick += new System.EventHandler(this.TextBoxInputCheck_irf_Tick);
            // 
            // ImageResizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 303);
            this.Controls.Add(this.Cancel_Button_ImageResizeForm);
            this.Controls.Add(this.OK_Button_ImageResizeForm);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Name = "ImageResizeForm";
            this.Text = "ImageResizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button OK_Button_ImageResizeForm;
        private System.Windows.Forms.Button Cancel_Button_ImageResizeForm;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Timer TextBoxInputCheck_irf;
    }
}