﻿namespace EEditor
{
    partial class Statistics
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fgradioButton = new System.Windows.Forms.RadioButton();
            this.actradioButton = new System.Windows.Forms.RadioButton();
            this.bgradioButton = new System.Windows.Forms.RadioButton();
            this.decorradioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 270);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // fgradioButton
            // 
            this.fgradioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.fgradioButton.AutoSize = true;
            this.fgradioButton.Image = global::EEditor.Properties.Resources.eeditor_block;
            this.fgradioButton.Location = new System.Drawing.Point(36, 301);
            this.fgradioButton.Name = "fgradioButton";
            this.fgradioButton.Size = new System.Drawing.Size(22, 22);
            this.fgradioButton.TabIndex = 3;
            this.fgradioButton.TabStop = true;
            this.fgradioButton.UseVisualStyleBackColor = true;
            this.fgradioButton.CheckedChanged += new System.EventHandler(this.FgradioButton_CheckedChanged);
            // 
            // actradioButton
            // 
            this.actradioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.actradioButton.AutoSize = true;
            this.actradioButton.Image = global::EEditor.Properties.Resources.eeditor_action;
            this.actradioButton.Location = new System.Drawing.Point(64, 301);
            this.actradioButton.Name = "actradioButton";
            this.actradioButton.Size = new System.Drawing.Size(22, 22);
            this.actradioButton.TabIndex = 4;
            this.actradioButton.TabStop = true;
            this.actradioButton.UseVisualStyleBackColor = true;
            // 
            // bgradioButton
            // 
            this.bgradioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.bgradioButton.AutoSize = true;
            this.bgradioButton.Image = global::EEditor.Properties.Resources.eeditor_bg;
            this.bgradioButton.Location = new System.Drawing.Point(92, 301);
            this.bgradioButton.Name = "bgradioButton";
            this.bgradioButton.Size = new System.Drawing.Size(22, 22);
            this.bgradioButton.TabIndex = 5;
            this.bgradioButton.TabStop = true;
            this.bgradioButton.UseVisualStyleBackColor = true;
            // 
            // decorradioButton
            // 
            this.decorradioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.decorradioButton.AutoSize = true;
            this.decorradioButton.Image = global::EEditor.Properties.Resources.eeditor_decor;
            this.decorradioButton.Location = new System.Drawing.Point(120, 301);
            this.decorradioButton.Name = "decorradioButton";
            this.decorradioButton.Size = new System.Drawing.Size(22, 22);
            this.decorradioButton.TabIndex = 6;
            this.decorradioButton.TabStop = true;
            this.decorradioButton.UseVisualStyleBackColor = true;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 345);
            this.Controls.Add(this.decorradioButton);
            this.Controls.Add(this.bgradioButton);
            this.Controls.Add(this.actradioButton);
            this.Controls.Add(this.fgradioButton);
            this.Controls.Add(this.panel1);
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton fgradioButton;
        private System.Windows.Forms.RadioButton actradioButton;
        private System.Windows.Forms.RadioButton bgradioButton;
        private System.Windows.Forms.RadioButton decorradioButton;
    }
}