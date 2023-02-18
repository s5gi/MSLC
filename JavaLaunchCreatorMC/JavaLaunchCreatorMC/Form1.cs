using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaLaunchCreatorMC
{
    public partial class Form1 : Form
    {

        public static string windowName = "Minecraft Server";

        string fileContent = string.Empty;
        string filePath = string.Empty;
        string fileName = string.Empty;
        string ram = string.Empty;

        bool gui = false;
        bool eula = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void windowname_TextChanged(object sender, EventArgs e)
        {
            windowName = windowname.Text;
            updateLabel5();
        }
        public void updateLabel5()
        {
            label5.Text = windowName;
        }
        public void updateGUILabel()
        {
            guilabel.Text = "GUI: " + gui;
        }
        public void updateServerFileText()
        {
            serverFile.Text = filePath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Minecraft Server Jar File (*.jar)|*.jar";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".jar";
                if (File.Exists(filePath.Replace(fileName, "") + "start.bat"))
                {
                    button2.Enabled = true;
                } else
                {
                    button2.Enabled = false;
                }
            }
            updateServerFileText();
        }

        private void togglegui_Click(object sender, EventArgs e)
        {
            gui = !gui;
            updateGUILabel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (filePath.Equals(""))
            {
                MessageBox.Show("Please Select a file to make a script for!", "Warning!", MessageBoxButtons.OK);
                return;
            }

            if (ram.Equals(""))
            {
                MessageBox.Show("Please fill out the \"Ram Allocated\" Field!", "Warning!", MessageBoxButtons.OK);
                return;
            }

            if (eula == true)
            {
                File.WriteAllText(filePath.Replace(fileName, "") + "eula.txt", "eula=true");
            }

            


            if (gui == true)
            {
                MessageBox.Show("It is recommended that you turn off GUI for a better experience.", "Warning!", MessageBoxButtons.OK);
            }


            StringBuilder stringBuilder = new StringBuilder();
            FileInfo file = new FileInfo(filePath);
            DriveInfo drive = new DriveInfo(file.Directory.Root.FullName);
            stringBuilder.Append("@echo off\n");
            stringBuilder.Append(drive.ToString().Replace("\\", "") + "\n");
            stringBuilder.Append("title " + windowName + "\n");
            stringBuilder.Append("java -Xmx" + ram + " -Xms" + ram + " -jar \"" + filePath + "\"");
            if (!gui)
            {
                stringBuilder.Append(" nogui");
            }
            File.WriteAllText(filePath.Replace(fileName, "") + "start.bat" , stringBuilder.ToString());
            File.WriteAllText(filePath.Replace(fileName, "") + "start.sh", stringBuilder.ToString().Replace("@echo off\n" + drive.ToString().Replace("\\", "") + "\n" + "title " + windowName + "\n", ""));
            MessageBox.Show("Successfully generated the files!", "Finished" , MessageBoxButtons.OK);
            if (File.Exists(filePath.Replace(fileName, "") + "start.bat"))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ram = textBox1.Text;
        }

        private void serverFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath.Replace(fileName, "") + "start.bat"))
            {
                System.Diagnostics.Process.Start("cmd.exe", "/c " + filePath.Replace(fileName, "") + "start.bat");

                /*Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                *//*cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;*//*
                cmd.StartInfo.CreateNoWindow = false;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine(filePath.Replace(fileName, "") + "start.bat");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();*/
            }
        }

        public void updateEULALabel()
        {
            label7.Text = "eula: " + eula;
        }

        private void toggleuela_Click(object sender, EventArgs e)
        {
            if (eula == false) { 
                MessageBox.Show("By changing the EULA to TRUE you are indicating your agreement to Minecraft's EULA (https://aka.ms/MinecraftEULA)", "!", MessageBoxButtons.OK);
            }
            eula = !eula;
            updateEULALabel();
        }
    }
}
