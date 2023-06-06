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
        string serverType = "Windows";

        bool bungeeCord = false;
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
            if (eula == true && !bungeeCord) 
            {
                File.WriteAllText(filePath.Replace(fileName, "") + "eula.txt", "eula=true");
            }
            if (gui == true)
            {
                MessageBox.Show("It is recommended that you turn off GUI for a better experience.", "Warning!", MessageBoxButtons.OK);
            }
            if (textBox2.Enabled)
            {
                if (bungeeCord) 
                {
                    File.WriteAllText(filePath.Replace(fileName, "") + "config.yml", "  host: 0.0.0.0:" + textBox2.Text) ;
                } else
                {
                    File.WriteAllText(filePath.Replace(fileName, "") + "server.properties", "server-port=" + textBox2.Text);
                }
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
            if (serverType.Equals("Windows")) File.WriteAllText(filePath.Replace(fileName, "") + "start.cmd" , stringBuilder.ToString());
            if (serverType.Equals("Linux")) File.WriteAllText(filePath.Replace(fileName, "") + "start.sh", stringBuilder.ToString().Replace("@echo off\n" + drive.ToString().Replace("\\", "") + "\n" + "title " + windowName + "\n", ""));
            MessageBox.Show("Successfully generated the files!", "Finished" , MessageBoxButtons.OK);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ram = textBox1.Text;
        }

        private void serverFile_TextChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            bungeeCord = !bungeeCord;
            if (bungeeCord)
            {
                toggleuela.Enabled = false;
                eula = false;
                updateEULALabel();
            }
            else
            {
                toggleuela.Enabled = true;
            }
            label8.Text = "BungeeCord: " + bungeeCord;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.serverType = "Windows";
            this.label9.Text = "Server Type: " + serverType;
            this.button3.Enabled = false;
            this.button5.Enabled = true;
            this.windowname.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.serverType = "Linux";
            this.label9.Text = "Server Type: " + serverType;
            this.button3.Enabled = true;
            this.button5.Enabled = false;
            this.windowname.Enabled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int por = int.Parse(textBox2.Text);
                if (por > 25565) textBox2.Text = "65535";
            } catch (Exception)
            {
                //ignore
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bungeeCord = !bungeeCord;
            if (bungeeCord)
            {
                textBox2.Text = "disabled";
                textBox2.Enabled = false;
            }
            else
            {
                textBox2.Text = "25565";
                textBox2.Enabled = true;
            }
        }
    }
}
