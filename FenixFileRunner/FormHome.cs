// Fenix File Runner 1.0
// Copyright © Ismael Heredia 2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace FenixFileRunner
{
    public partial class FormHome : Telerik.WinControls.UI.RadForm
    {
        public string program_title;

        public FormHome()
        {
            InitializeComponent();
            program_title = "Fenix File Runner 1.0";
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            string program = txtProgram.Text;
            string name = Path.GetFileNameWithoutExtension(program);
            string value = program;
            if (program != "")
            {
                try
                {
                    RegistryKey registry = Registry.LocalMachine;
                    registry = registry.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    registry.CreateSubKey(name);
                    registry.SetValue(name, value, RegistryValueKind.String);
                    registry.Close();
                    RadMessageBox.Show("Program added in the registry", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                catch
                {
                    RadMessageBox.Show("Error adding program in registry", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                RadMessageBox.Show("Select program", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDeleteProgram_Click(object sender, EventArgs e)
        {
            string program = txtProgram.Text;
            string name = Path.GetFileNameWithoutExtension(program);
            if (program != "")
            {
                try
                {
                    RegistryKey registry = Registry.LocalMachine;
                    registry = registry.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    registry.DeleteValue(name);
                    registry.Close();
                    RadMessageBox.Show("Program deleted in the registry", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                catch
                {
                    RadMessageBox.Show("Error deleting program in registry", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                RadMessageBox.Show("Select program", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnLoadProgram_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Title = "Select program";
            openFileDialog.DefaultExt = "exe";
            openFileDialog.Filter = "Program (.exe)|*.exe";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtProgram.Text = openFileDialog.FileName;
            }
        }

        private void txtProgram_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                txtProgram.Text = files[0];
            }
        }

        private void txtProgram_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
