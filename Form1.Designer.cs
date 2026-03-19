namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEchoMessenger = new Label();
            myTextBox = new TextBox();
            mylistBox = new ListBox();
            btnTransmit = new Button();
            SuspendLayout();
            // 
            // lblEchoMessenger
            // 
            lblEchoMessenger.AutoSize = true;
            lblEchoMessenger.Font = new Font("한컴 고딕", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblEchoMessenger.ForeColor = Color.Blue;
            lblEchoMessenger.Location = new Point(27, 22);
            lblEchoMessenger.Name = "lblEchoMessenger";
            lblEchoMessenger.Size = new Size(348, 56);
            lblEchoMessenger.TabIndex = 0;
            lblEchoMessenger.Text = "Echo Messenger";
            // 
            // myTextBox
            // 
            myTextBox.Font = new Font("한컴 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            myTextBox.Location = new Point(27, 375);
            myTextBox.Name = "myTextBox";
            myTextBox.Size = new Size(588, 43);
            myTextBox.TabIndex = 1;
            // 
            // mylistBox
            // 
            mylistBox.Font = new Font("한컴 고딕", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 129);
            mylistBox.FormattingEnabled = true;
            mylistBox.Location = new Point(27, 81);
            mylistBox.Name = "mylistBox";
            mylistBox.Size = new Size(738, 262);
            mylistBox.TabIndex = 2;
            // 
            // btnTransmit
            // 
            btnTransmit.BackColor = Color.FromArgb(128, 255, 128);
            btnTransmit.Font = new Font("한컴 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnTransmit.Location = new Point(621, 363);
            btnTransmit.Name = "btnTransmit";
            btnTransmit.Size = new Size(144, 75);
            btnTransmit.TabIndex = 3;
            btnTransmit.Text = "전송";
            btnTransmit.UseVisualStyleBackColor = false;
            btnTransmit.Click += btnTransmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnTransmit);
            Controls.Add(mylistBox);
            Controls.Add(myTextBox);
            Controls.Add(lblEchoMessenger);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEchoMessenger;
        private TextBox myTextBox;
        private ListBox mylistBox;
        private Button btnTransmit;
    }
}
