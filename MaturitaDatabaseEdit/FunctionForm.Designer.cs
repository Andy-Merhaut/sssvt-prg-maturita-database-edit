
namespace MaturitaDatabaseEdit
{
    partial class FunctionForm
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
            this.ContextPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.PowerTextBox = new System.Windows.Forms.TextBox();
            this.ContextPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextPanel
            // 
            this.ContextPanel.Controls.Add(this.PowerTextBox);
            this.ContextPanel.Controls.Add(this.PowerLabel);
            this.ContextPanel.Controls.Add(this.NameTextBox);
            this.ContextPanel.Controls.Add(this.NameLabel);
            this.ContextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContextPanel.Location = new System.Drawing.Point(0, 0);
            this.ContextPanel.Name = "ContextPanel";
            this.ContextPanel.Size = new System.Drawing.Size(434, 422);
            this.ContextPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.OkButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 322);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(434, 100);
            this.MainPanel.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(175, 40);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OKAY";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(89, 114);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "NAME";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(175, 114);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(89, 166);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(48, 13);
            this.PowerLabel.TabIndex = 2;
            this.PowerLabel.Text = "POWER";
            // 
            // PowerTextBox
            // 
            this.PowerTextBox.Location = new System.Drawing.Point(175, 163);
            this.PowerTextBox.Name = "PowerTextBox";
            this.PowerTextBox.Size = new System.Drawing.Size(100, 20);
            this.PowerTextBox.TabIndex = 3;
            // 
            // FunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 422);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ContextPanel);
            this.Name = "FunctionForm";
            this.Text = "FunctionForm";
            this.ContextPanel.ResumeLayout(false);
            this.ContextPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContextPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox PowerTextBox;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button OkButton;
    }
}