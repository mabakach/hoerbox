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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HörBoxEncoder
{
    public partial class MainForm : Form
    {
        private XOREncryption xorEncryption = new XOREncryption(102);

        private BackgroundWorker backgroundWorker;

        public MainForm()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork +=
                new DoWorkEventHandler(ConvertFile);
            backgroundWorker.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            ConvertCompleted);
            backgroundWorker.ProgressChanged +=
                new ProgressChangedEventHandler(
            ConvertProgressChangedEventHandler);
        }

        private void BrowseInputPathButton_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a MP3.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Dateien|*.mp3;*.smp";
            openFileDialog.Title = "Input Datei auswählen";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                inputPathTextField.Text = openFileDialog.FileName;
            }
        }

        private void BrowseOutputPathButton_Click(object sender, EventArgs e)
        {
            // Displays an SaveFileDialog so the user can select a MP3.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Dateien|*.mp3;*.smp";
            saveFileDialog.Title = "Output Datei auswählen";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outputPathTextField.Text = saveFileDialog.FileName;
            }
        }

        private void StartConvertButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
            this.Enabled = false;
        }

        private void ConvertFile(object sender, DoWorkEventArgs e)
        {
            xorEncryption.EncryptFile(inputPathTextField.Text, outputPathTextField.Text);
        }

        private void ConvertCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBoxEx.Show(this, "Konvertierung erfolgreich beendet!", "", MessageBoxButtons.OK);
            this.Enabled = true;
        }

        private void ConvertProgressChangedEventHandler(object sender, ProgressChangedEventArgs e)
        {

        }

        private void FileCloseMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
