namespace Employeeclock.NewFolder
{
    partial class LoginpageForm
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
            button2 = new Button();
            textBox_tz = new TextBox();
            textBox_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_lpTOpp = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            button2.Location = new Point(50, 531);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(526, 74);
            button2.TabIndex = 1;
            button2.Text = "כניסה";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_lpTOcp_Click;
            // 
            // textBox_tz
            // 
            textBox_tz.Location = new Point(53, 341);
            textBox_tz.Margin = new Padding(5);
            textBox_tz.Name = "textBox_tz";
            textBox_tz.Size = new Size(524, 38);
            textBox_tz.TabIndex = 2;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(52, 199);
            textBox_password.Margin = new Padding(5);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(524, 38);
            textBox_password.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(257, 281);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 4;
            label1.Text = "תעודת זהות";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(287, 131);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 5;
            label2.Text = "סיסמא";
            // 
            // button_lpTOpp
            // 
            button_lpTOpp.Location = new Point(50, 448);
            button_lpTOpp.Name = "button_lpTOpp";
            button_lpTOpp.Size = new Size(526, 60);
            button_lpTOpp.TabIndex = 6;
            button_lpTOpp.Text = "החלפת סיסמא";
            button_lpTOpp.UseVisualStyleBackColor = true;
            button_lpTOpp.Click += button_lpTOpp_Click;
            // 
            // LoginpageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 631);
            Controls.Add(button_lpTOpp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_password);
            Controls.Add(textBox_tz);
            Controls.Add(button2);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "LoginpageForm";
            Text = "LoginPageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private TextBox textBox_tz;
        private TextBox textBox_password;
        private Label label1;
        private Label label2;
        private Button button_lpTOpp;
    }
}