﻿
namespace AlarmSystem
{
    partial class NewAlarmPage
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCustRepetition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(297, 304);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 57);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCustRepetition
            // 
            this.btnCustRepetition.Location = new System.Drawing.Point(297, 153);
            this.btnCustRepetition.Name = "btnCustRepetition";
            this.btnCustRepetition.Size = new System.Drawing.Size(163, 74);
            this.btnCustRepetition.TabIndex = 1;
            this.btnCustRepetition.Text = "Custom Repetition";
            this.btnCustRepetition.UseVisualStyleBackColor = true;
            this.btnCustRepetition.Click += new System.EventHandler(this.btnCustRepetition_Click);
            // 
            // NewAlarmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnCustRepetition);
            this.Controls.Add(this.btnClose);
            this.Name = "NewAlarmPage";
            this.Text = "CustomAlarm";
            this.Load += new System.EventHandler(this.NewAlarmPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCustRepetition;
    }
}