/*  License

All files are licensed under the MIT license.
The MIT License (MIT)

Copyright (c) 2017 Marc Baumgartner

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
associated documentation files (the "Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies 
of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS
OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*/

namespace HörBoxEncoder
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputPathLabel = new System.Windows.Forms.Label();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.inputPathTextField = new System.Windows.Forms.TextBox();
            this.outputPathTextField = new System.Windows.Forms.TextBox();
            this.browseInputFileButton = new System.Windows.Forms.Button();
            this.browseOutputPathButton = new System.Windows.Forms.Button();
            this.startConvertButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.inputPathLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputPathLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputPathTextField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputPathTextField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.browseInputFileButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.browseOutputPathButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.startConvertButton, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // inputPathLabel
            // 
            resources.ApplyResources(this.inputPathLabel, "inputPathLabel");
            this.inputPathLabel.Name = "inputPathLabel";
            // 
            // outputPathLabel
            // 
            resources.ApplyResources(this.outputPathLabel, "outputPathLabel");
            this.outputPathLabel.Name = "outputPathLabel";
            // 
            // inputPathTextField
            // 
            resources.ApplyResources(this.inputPathTextField, "inputPathTextField");
            this.inputPathTextField.Name = "inputPathTextField";
            // 
            // outputPathTextField
            // 
            resources.ApplyResources(this.outputPathTextField, "outputPathTextField");
            this.outputPathTextField.Name = "outputPathTextField";
            // 
            // browseInputFileButton
            // 
            resources.ApplyResources(this.browseInputFileButton, "browseInputFileButton");
            this.browseInputFileButton.Name = "browseInputFileButton";
            this.browseInputFileButton.UseVisualStyleBackColor = true;
            this.browseInputFileButton.Click += new System.EventHandler(this.BrowseInputPathButton_Click);
            // 
            // browseOutputPathButton
            // 
            resources.ApplyResources(this.browseOutputPathButton, "browseOutputPathButton");
            this.browseOutputPathButton.Name = "browseOutputPathButton";
            this.browseOutputPathButton.UseVisualStyleBackColor = true;
            this.browseOutputPathButton.Click += new System.EventHandler(this.BrowseOutputPathButton_Click);
            // 
            // startConvertButton
            // 
            resources.ApplyResources(this.startConvertButton, "startConvertButton");
            this.startConvertButton.Name = "startConvertButton";
            this.startConvertButton.UseVisualStyleBackColor = true;
            this.startConvertButton.Click += new System.EventHandler(this.StartConvertButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            resources.ApplyResources(this.dateiToolStripMenuItem, "dateiToolStripMenuItem");
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            resources.ApplyResources(this.beendenToolStripMenuItem, "beendenToolStripMenuItem");
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.FileCloseMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            resources.ApplyResources(this.hilfeToolStripMenuItem, "hilfeToolStripMenuItem");
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label inputPathLabel;
        private System.Windows.Forms.Label outputPathLabel;
        private System.Windows.Forms.TextBox inputPathTextField;
        private System.Windows.Forms.TextBox outputPathTextField;
        private System.Windows.Forms.Button browseInputFileButton;
        private System.Windows.Forms.Button browseOutputPathButton;
        private System.Windows.Forms.Button startConvertButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

