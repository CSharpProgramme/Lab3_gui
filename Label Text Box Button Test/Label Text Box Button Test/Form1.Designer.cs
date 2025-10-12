namespace Label_Text_Box_Button_Test
{
    partial class Form1
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
            this.displayPasswordButton = new System.Windows.Forms.Button();
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayPasswordButton
            // 
            this.displayPasswordButton.Location = new System.Drawing.Point(105, 123);
            this.displayPasswordButton.Name = "displayPasswordButton";
            this.displayPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.displayPasswordButton.TabIndex = 0;
            this.displayPasswordButton.Text = "Show me";
            this.displayPasswordButton.UseVisualStyleBackColor = true;
            this.displayPasswordButton.Click += new System.EventHandler(this.displayPasswordButton_Click);
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPasswordLabel.Location = new System.Drawing.Point(23, 73);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(241, 23);
            this.displayPasswordLabel.TabIndex = 1;
            this.displayPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.Location = new System.Drawing.Point(26, 27);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.Size = new System.Drawing.Size(238, 20);
            this.inputPasswordTextBox.TabIndex = 2;
            this.inputPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 192);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Controls.Add(this.displayPasswordLabel);
            this.Controls.Add(this.displayPasswordButton);
            this.Name = "Form1";
            this.Text = "Label, TextBox, and Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayPasswordButton;
        private System.Windows.Forms.Label displayPasswordLabel;
        private System.Windows.Forms.TextBox inputPasswordTextBox;
    }
}

