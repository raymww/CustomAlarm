
namespace AlarmSystem
{
    partial class HomePage
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNextAlarm = new System.Windows.Forms.Label();
            this.btnNewAlarm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstbxCurrentAlarms = new System.Windows.Forms.ListBox();
            this.btnDeleteAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(106, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(131, 36);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNextAlarm
            // 
            this.lblNextAlarm.AutoSize = true;
            this.lblNextAlarm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextAlarm.Location = new System.Drawing.Point(37, 67);
            this.lblNextAlarm.Name = "lblNextAlarm";
            this.lblNextAlarm.Size = new System.Drawing.Size(278, 21);
            this.lblNextAlarm.TabIndex = 1;
            this.lblNextAlarm.Text = "Next Alarm: XX:XX AM on XX/XX";
            // 
            // btnNewAlarm
            // 
            this.btnNewAlarm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAlarm.Location = new System.Drawing.Point(115, 109);
            this.btnNewAlarm.Name = "btnNewAlarm";
            this.btnNewAlarm.Size = new System.Drawing.Size(119, 34);
            this.btnNewAlarm.TabIndex = 2;
            this.btnNewAlarm.Text = "Set New Alarm";
            this.btnNewAlarm.UseVisualStyleBackColor = true;
            this.btnNewAlarm.Click += new System.EventHandler(this.btnNewAlarm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(219, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstbxCurrentAlarms
            // 
            this.lstbxCurrentAlarms.FormattingEnabled = true;
            this.lstbxCurrentAlarms.Location = new System.Drawing.Point(27, 155);
            this.lstbxCurrentAlarms.Name = "lstbxCurrentAlarms";
            this.lstbxCurrentAlarms.Size = new System.Drawing.Size(311, 329);
            this.lstbxCurrentAlarms.TabIndex = 5;
            // 
            // btnDeleteAlarm
            // 
            this.btnDeleteAlarm.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAlarm.Location = new System.Drawing.Point(27, 502);
            this.btnDeleteAlarm.Name = "btnDeleteAlarm";
            this.btnDeleteAlarm.Size = new System.Drawing.Size(89, 33);
            this.btnDeleteAlarm.TabIndex = 6;
            this.btnDeleteAlarm.Text = "Delete Alarm";
            this.btnDeleteAlarm.UseVisualStyleBackColor = true;
            this.btnDeleteAlarm.Click += new System.EventHandler(this.btnDeleteAlarm_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 547);
            this.Controls.Add(this.btnDeleteAlarm);
            this.Controls.Add(this.lstbxCurrentAlarms);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewAlarm);
            this.Controls.Add(this.lblNextAlarm);
            this.Controls.Add(this.lblWelcome);
            this.Name = "HomePage";
            this.Text = "CustomAlarm";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNextAlarm;
        private System.Windows.Forms.Button btnNewAlarm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstbxCurrentAlarms;
        private System.Windows.Forms.Button btnDeleteAlarm;
    }
}

