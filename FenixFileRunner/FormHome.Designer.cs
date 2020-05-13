namespace FenixFileRunner
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.btnAddProgram = new Telerik.WinControls.UI.RadButton();
            this.telerikMetroTheme = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.gbEnterProgram = new Telerik.WinControls.UI.RadGroupBox();
            this.btnLoadProgram = new Telerik.WinControls.UI.RadButton();
            this.txtProgram = new Telerik.WinControls.UI.RadTextBox();
            this.btnDeleteProgram = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbEnterProgram)).BeginInit();
            this.gbEnterProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.Location = new System.Drawing.Point(71, 118);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(118, 24);
            this.btnAddProgram.TabIndex = 1;
            this.btnAddProgram.Text = "Add program";
            this.btnAddProgram.ThemeName = "TelerikMetro";
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // gbEnterProgram
            // 
            this.gbEnterProgram.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbEnterProgram.Controls.Add(this.btnLoadProgram);
            this.gbEnterProgram.Controls.Add(this.txtProgram);
            this.gbEnterProgram.HeaderText = "Enter program";
            this.gbEnterProgram.Location = new System.Drawing.Point(12, 21);
            this.gbEnterProgram.Name = "gbEnterProgram";
            this.gbEnterProgram.Size = new System.Drawing.Size(393, 75);
            this.gbEnterProgram.TabIndex = 2;
            this.gbEnterProgram.Text = "Enter program";
            this.gbEnterProgram.ThemeName = "TelerikMetro";
            // 
            // btnLoadProgram
            // 
            this.btnLoadProgram.Location = new System.Drawing.Point(326, 33);
            this.btnLoadProgram.Name = "btnLoadProgram";
            this.btnLoadProgram.Size = new System.Drawing.Size(52, 24);
            this.btnLoadProgram.TabIndex = 1;
            this.btnLoadProgram.Text = "...";
            this.btnLoadProgram.ThemeName = "TelerikMetro";
            this.btnLoadProgram.Click += new System.EventHandler(this.btnLoadProgram_Click);
            // 
            // txtProgram
            // 
            this.txtProgram.AllowDrop = true;
            this.txtProgram.Location = new System.Drawing.Point(20, 35);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.ReadOnly = true;
            this.txtProgram.Size = new System.Drawing.Size(300, 24);
            this.txtProgram.TabIndex = 0;
            this.txtProgram.ThemeName = "TelerikMetro";
            this.txtProgram.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtProgram_DragDrop);
            this.txtProgram.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtProgram_DragEnter);
            // 
            // btnDeleteProgram
            // 
            this.btnDeleteProgram.Location = new System.Drawing.Point(214, 118);
            this.btnDeleteProgram.Name = "btnDeleteProgram";
            this.btnDeleteProgram.Size = new System.Drawing.Size(118, 24);
            this.btnDeleteProgram.TabIndex = 3;
            this.btnDeleteProgram.Text = "Delete program";
            this.btnDeleteProgram.ThemeName = "TelerikMetro";
            this.btnDeleteProgram.Click += new System.EventHandler(this.btnDeleteProgram_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 161);
            this.Controls.Add(this.btnDeleteProgram);
            this.Controls.Add(this.gbEnterProgram);
            this.Controls.Add(this.btnAddProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Fenix File Runner 1.0 - Copyright © Ismael Heredia 2020";
            this.ThemeName = "TelerikMetro";
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbEnterProgram)).EndInit();
            this.gbEnterProgram.ResumeLayout(false);
            this.gbEnterProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnAddProgram;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme;
        private Telerik.WinControls.UI.RadGroupBox gbEnterProgram;
        private Telerik.WinControls.UI.RadButton btnLoadProgram;
        private Telerik.WinControls.UI.RadTextBox txtProgram;
        private Telerik.WinControls.UI.RadButton btnDeleteProgram;
    }
}