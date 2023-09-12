using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ServerControl
{
    public partial class ServerControl : Form
    {

        public ServerControl()
        {
            InitializeComponent();

            this.textBoxFrom.Text = ServerControlMC.Properties.Settings.Default.pathFrom;
            this.textBoxTo.Text = ServerControlMC.Properties.Settings.Default.pathTo;
            this.configNameTextBox.Text = ServerControlMC.Properties.Settings.Default.configName;
            this.serverJarFilePathTextBox.Text = ServerControlMC.Properties.Settings.Default.serverFileJarPathTextBox;
            this.fileToRunTextBox.Text = ServerControlMC.Properties.Settings.Default.fileToRun;

        }

        private void form1_Close(object sender, CancelEventArgs args)
        {
            ServerControlMC.Properties.Settings.Default.pathFrom = this.textBoxFrom.Text;
            ServerControlMC.Properties.Settings.Default.pathTo = this.textBoxTo.Text;
            ServerControlMC.Properties.Settings.Default.configName = this.configNameTextBox.Text;
            ServerControlMC.Properties.Settings.Default.serverFileJarPathTextBox = this.serverJarFilePathTextBox.Text;
            ServerControlMC.Properties.Settings.Default.fileToRun = this.fileToRunTextBox.Text;
            ServerControlMC.Properties.Settings.Default.Save();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {

            var pathFrom = this.textBoxFrom.Text;
            var fileFrom = new FileInfo(pathFrom);


            var pathTo = this.textBoxTo.Text;
            var pathToFile = this.textBoxTo.Text + @"\" + fileFrom.Name;
            var fileTo = new FileInfo(pathToFile);

            if (fileFrom.Exists)
            {
                fileFrom.CopyTo(pathToFile, true);

                if (deleteConfigCheckBox.Checked)
                {

                    var configPath = pathTo + @"\" + configNameTextBox.Text;

                    if (Directory.Exists(configPath))
                    {
                        Directory.Delete(configPath, true);

                        MessageBox.Show(
                            "Plugin succesful moved \n" +
                            "From: " + pathFrom + "\n" +
                            "To: " + pathTo + "\n" +
                            "Config file deleted"
                        );

                        return;
                    }

                    MessageBox.Show(
                        "Plugin succesful moved \n" +
                        "From: " + pathFrom + "\n" +
                        "To: " + pathTo + "\n" +
                        "Config has already been deleted"
                        );
                }
                else
                {
                    MessageBox.Show(
                    "Plugin succesful moved \n" +
                    "From: " + pathFrom + "\n" +
                    "To: " + pathTo
                    );
                }


            }
            else
            {
                MessageBox.Show("File from not exists");
            }
        }

        private void startServerButton_Click(object sender, EventArgs e)
        {

            var serverDirectory = serverJarFilePathTextBox.Text;
            var fileToRunName = fileToRunTextBox.Text;


            if (Directory.Exists(serverDirectory))
            {

                var fileToRun = new FileInfo(serverDirectory + @"\" + fileToRunName);

                if (fileToRun.Exists)
                {

                    var process = new Process();
                    var info = new ProcessStartInfo();

                    info.WorkingDirectory = serverDirectory;
                    info.FileName = "CMD.exe";
                    info.Arguments = "/C " + fileToRunName;
                    process.StartInfo = info;

                    process.Start();

                }
            }

        }
    }
}
