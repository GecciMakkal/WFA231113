﻿namespace WFA001
{
    partial class MainForm
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
            lblhello = new Label();
            SuspendLayout();
            // 
            // lblhello
            // 
            lblhello.AutoSize = true;
            lblhello.BackColor = SystemColors.Info;
            lblhello.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblhello.Location = new Point(214, 79);
            lblhello.Name = "lblhello";
            lblhello.Size = new Size(166, 37);
            lblhello.TabIndex = 0;
            lblhello.Text = "Hello,World!";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblhello);
            Name = "MainForm";
            Text = "Hello,World!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblhello;
    }
}