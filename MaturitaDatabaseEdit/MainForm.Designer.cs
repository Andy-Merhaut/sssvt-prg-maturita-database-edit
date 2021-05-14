
namespace MaturitaDatabaseEdit
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ContextPanel = new System.Windows.Forms.Panel();
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.MainListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.ContextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.AddButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuPanel.Location = new System.Drawing.Point(0, 391);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(800, 59);
            this.MenuPanel.TabIndex = 0;
            // 
            // ContextPanel
            // 
            this.ContextPanel.Controls.Add(this.MainListBox);
            this.ContextPanel.Controls.Add(this.MainDataGridView);
            this.ContextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContextPanel.Location = new System.Drawing.Point(0, 0);
            this.ContextPanel.Name = "ContextPanel";
            this.ContextPanel.Size = new System.Drawing.Size(800, 391);
            this.ContextPanel.TabIndex = 1;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.Location = new System.Drawing.Point(12, 12);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.Size = new System.Drawing.Size(776, 205);
            this.MainDataGridView.TabIndex = 0;
            // 
            // MainListBox
            // 
            this.MainListBox.FormattingEnabled = true;
            this.MainListBox.Location = new System.Drawing.Point(12, 223);
            this.MainListBox.Name = "MainListBox";
            this.MainListBox.Size = new System.Drawing.Size(776, 160);
            this.MainListBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(288, 24);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContextPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MenuPanel.ResumeLayout(false);
            this.ContextPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel ContextPanel;
        private System.Windows.Forms.ListBox MainListBox;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.Button AddButton;
    }
}

