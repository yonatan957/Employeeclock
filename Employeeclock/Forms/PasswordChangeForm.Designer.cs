namespace Employeeclock
{
    partial class PasswordChangeForm
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
            label1 = new Label();
            label_NPassword = new Label();
            label_NPasswordApprove = new Label();
            label4 = new Label();
            button_password_apruve = new Button();
            textBox_TZ = new TextBox();
            textBox_OPassword = new TextBox();
            textBoxNPassword = new TextBox();
            textBox_NPasswordApprove = new TextBox();
            label5 = new Label();
            linkLabel_ppTOlp = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(612, 79);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 0;
            label1.Text = "תעודת זהות";
            // 
            // label_NPassword
            // 
            label_NPassword.AutoSize = true;
            label_NPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label_NPassword.Location = new Point(597, 222);
            label_NPassword.Name = "label_NPassword";
            label_NPassword.Size = new Size(133, 28);
            label_NPassword.TabIndex = 1;
            label_NPassword.Text = "סיסמא חדשה";
            // 
            // label_NPasswordApprove
            // 
            label_NPasswordApprove.AutoSize = true;
            label_NPasswordApprove.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label_NPasswordApprove.Location = new Point(539, 294);
            label_NPasswordApprove.Name = "label_NPasswordApprove";
            label_NPasswordApprove.Size = new Size(191, 28);
            label_NPasswordApprove.TabIndex = 2;
            label_NPasswordApprove.Text = "אישור סיסמא חדשה";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(612, 64);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 3;
            // 
            // button_password_apruve
            // 
            button_password_apruve.Location = new Point(303, 363);
            button_password_apruve.Name = "button_password_apruve";
            button_password_apruve.Size = new Size(162, 48);
            button_password_apruve.TabIndex = 4;
            button_password_apruve.Text = "ביצוע החלפת סיסמא";
            button_password_apruve.UseVisualStyleBackColor = true;
            button_password_apruve.Click += button_ppTOlp_apruve_Click;
            // 
            // textBox_TZ
            // 
            textBox_TZ.Location = new Point(159, 80);
            textBox_TZ.Name = "textBox_TZ";
            textBox_TZ.Size = new Size(199, 27);
            textBox_TZ.TabIndex = 5;
            // 
            // textBox_OPassword
            // 
            textBox_OPassword.Location = new Point(159, 148);
            textBox_OPassword.Name = "textBox_OPassword";
            textBox_OPassword.Size = new Size(199, 27);
            textBox_OPassword.TabIndex = 6;
            // 
            // textBoxNPassword
            // 
            textBoxNPassword.Location = new Point(159, 223);
            textBoxNPassword.Name = "textBoxNPassword";
            textBoxNPassword.Size = new Size(199, 27);
            textBoxNPassword.TabIndex = 7;
            // 
            // textBox_NPasswordApprove
            // 
            textBox_NPasswordApprove.Location = new Point(159, 294);
            textBox_NPasswordApprove.Name = "textBox_NPasswordApprove";
            textBox_NPasswordApprove.Size = new Size(199, 27);
            textBox_NPasswordApprove.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(608, 148);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 9;
            label5.Text = "סיסמא ישנה";
            // 
            // linkLabel_ppTOlp
            // 
            linkLabel_ppTOlp.AutoSize = true;
            linkLabel_ppTOlp.Location = new Point(502, 391);
            linkLabel_ppTOlp.Name = "linkLabel_ppTOlp";
            linkLabel_ppTOlp.Size = new Size(44, 20);
            linkLabel_ppTOlp.TabIndex = 10;
            linkLabel_ppTOlp.TabStop = true;
            linkLabel_ppTOlp.Text = "ביטול";
            linkLabel_ppTOlp.LinkClicked += linkLabel_ppTOlp_cancel_LinkClicked;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 448);
            Controls.Add(linkLabel_ppTOlp);
            Controls.Add(label5);
            Controls.Add(textBox_NPasswordApprove);
            Controls.Add(textBoxNPassword);
            Controls.Add(textBox_OPassword);
            Controls.Add(textBox_TZ);
            Controls.Add(button_password_apruve);
            Controls.Add(label4);
            Controls.Add(label_NPasswordApprove);
            Controls.Add(label_NPassword);
            Controls.Add(label1);
            Name = "PasswordChangeForm";
            Text = "PasswordChangeForm";
            FormClosed += PasswordChangeForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_NPassword;
        private Label label_NPasswordApprove;
        private Label label4;
        private Button button_password_apruve;
        private TextBox textBox_TZ;
        private TextBox textBox_OPassword;
        private TextBox textBoxNPassword;
        private TextBox textBox_NPasswordApprove;
        private Label label5;
        private LinkLabel linkLabel_ppTOlp;
    }
}