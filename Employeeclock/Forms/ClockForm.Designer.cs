namespace Employeeclock.NewFolder
{
    partial class ClockForm
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
            label2 = new Label();
            label3 = new Label();
            button_entrance = new Button();
            button_exit = new Button();
            label_Name = new Label();
            label_LastExit = new Label();
            label_lastEntrance = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 214);
            label1.Name = "label1";
            label1.Size = new Size(202, 31);
            label1.TabIndex = 0;
            label1.Text = "תאריך יציאה אחרון";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(393, 125);
            label2.Name = "label2";
            label2.Size = new Size(205, 31);
            label2.TabIndex = 1;
            label2.Text = "תאריך כניסה אחרון";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(536, 53);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(179, 46);
            label3.TabIndex = 2;
            label3.Text = "זהות עובד:";
            // 
            // button_entrance
            // 
            button_entrance.BackColor = Color.FromArgb(128, 255, 128);
            button_entrance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_entrance.Location = new Point(527, 301);
            button_entrance.Name = "button_entrance";
            button_entrance.Size = new Size(114, 92);
            button_entrance.TabIndex = 3;
            button_entrance.Text = "כניסה";
            button_entrance.UseVisualStyleBackColor = false;
            button_entrance.Click += button_entrance_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(255, 128, 128);
            button_exit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_exit.Location = new Point(180, 302);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(114, 91);
            button_exit.TabIndex = 4;
            button_exit.Text = "יציאה";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Name.Location = new Point(119, 53);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(117, 46);
            label_Name.TabIndex = 5;
            label_Name.Text = "label4";
            // 
            // label_LastExit
            // 
            label_LastExit.AutoSize = true;
            label_LastExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label_LastExit.Location = new Point(119, 214);
            label_LastExit.Name = "label_LastExit";
            label_LastExit.Size = new Size(79, 31);
            label_LastExit.TabIndex = 6;
            label_LastExit.Text = "label4";
            // 
            // label_lastEntrance
            // 
            label_lastEntrance.AutoSize = true;
            label_lastEntrance.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label_lastEntrance.Location = new Point(119, 125);
            label_lastEntrance.Name = "label_lastEntrance";
            label_lastEntrance.Size = new Size(79, 31);
            label_lastEntrance.TabIndex = 7;
            label_lastEntrance.Text = "label5";
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 462);
            Controls.Add(label_lastEntrance);
            Controls.Add(label_LastExit);
            Controls.Add(label_Name);
            Controls.Add(button_exit);
            Controls.Add(button_entrance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClockForm";
            Text = "ClockForm";
            FormClosed += ClockForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_entrance;
        private Button button_exit;
        private Label label_Name;
        private Label label_LastExit;
        private Label label_lastEntrance;
    }
}