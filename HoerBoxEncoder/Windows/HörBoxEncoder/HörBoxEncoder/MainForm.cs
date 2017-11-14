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
    }
}
