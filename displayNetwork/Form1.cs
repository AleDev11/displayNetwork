using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace displayNetwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartStatus();
        }

        public void StartStatus()
        {
            textIpHost.Text = "Ip Host: " + GetInfo.GetIpHost();
            textIpGateway.Text = "Ip Gateway: " + GetInfo.GetIpGateway();
            textUsername.Text = "Username: " + GetInfo.GetUsername();
            textHostname.Text = "Hostname: " + GetInfo.GetHostname();
            textSsid.Text = "SSID: " + GetInfo.GetSsid();
            textSsidStatus.Text = "SSID Status: " + GetInfo.GetSsidStatus();
            textMacAddress.Text = "Mac Address: " + GetInfo.GetMacAddress();
            textInternetConnection.Text = "Internet Connection: " + GetInfo.GetInternetConnection();
            textVmWareInstall.Text = "Is VMW Install: " + GetInfo.GetVmWareInstall();
            textVmwVersion.Text = "VMW Version: " + GetInfo.GetVmWareVersion();
            textVirtualBoxInstall.Text = "Is VirtualBox Install: " + GetInfo.GetVirtualBoxInstall();
            textVirtualBoxVersion.Text = "VirtulaBox Version: " + GetInfo.GetVirtualBoxVersion();
            textLocationPath.Text = "";
            textLocationIso.Text = "";

            comboBoxOsType.Items.Add("Not Selected");
            comboBoxOsType.Items.Add("Windows");
            comboBoxOsType.Items.Add("Ubuntu");

            comboBoxOsType.SelectedIndex = 0;

            comboBoxOsVersion.Items.Add("Not Selected");
            comboBoxOsVersion.Items.Add("Windows 10");
            comboBoxOsVersion.Items.Add("Ubuntu");

            comboBoxOsVersion.SelectedIndex = 0;

            comboBoxRam.Items.Add("Not Selected");
            comboBoxRam.Items.Add("512");
            comboBoxRam.Items.Add("1024");
            comboBoxRam.Items.Add("2048");
            comboBoxRam.Items.Add("4096");
            comboBoxRam.Items.Add("8192");
            comboBoxRam.SelectedIndex = 0;

            comboBoxCores.Items.Add("Not Selected");
            comboBoxCores.Items.Add("1");
            comboBoxCores.Items.Add("2");
            comboBoxCores.Items.Add("4");
            comboBoxCores.Items.Add("8");
            comboBoxCores.Items.Add("16");
            comboBoxCores.SelectedIndex = 0;

            comboBoxVideoMemory.Items.Add("Not Selected");
            comboBoxVideoMemory.Items.Add("8");
            comboBoxVideoMemory.Items.Add("16");
            comboBoxVideoMemory.Items.Add("32");
            comboBoxVideoMemory.Items.Add("64");
            comboBoxVideoMemory.Items.Add("128");
            comboBoxVideoMemory.SelectedIndex = 0;

            comboBoxGraphicsController.Items.Add("Not Selected");
            comboBoxGraphicsController.Items.Add("VBoxSVGA");
            comboBoxGraphicsController.Items.Add("VMSVGA");
            comboBoxGraphicsController.Items.Add("VBoxVGA");
            comboBoxGraphicsController.Items.Add("VBoxVideo");
            comboBoxGraphicsController.SelectedIndex = 0;

            comboBoxNetworkMode.Items.Add("Not Selected");
            comboBoxNetworkMode.Items.Add("Intel PRO/1000 MT Desktop (82540EM)");
            comboBoxNetworkMode.Items.Add("Intel PRO/1000 MT Server (82545EM)");
            comboBoxNetworkMode.Items.Add("Intel PRO/1000 T Server (82543GC)");
            comboBoxNetworkMode.Items.Add("Intel PRO/1000 MT Server (82545EM)");
            comboBoxNetworkMode.SelectedIndex = 0;

        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) textLocationPath.Text = dialog.FileName;
        }

        private void btnSerchIso_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = ".iso (*.iso*)|*.iso*";
            open.FilterIndex = 1;
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                textLocationIso.Text = open.FileName;
            }
        }

        private void comboBoxRam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateVm_Click(object sender, EventArgs e)
        {
            if (textLocationPath.Text == "" || textLocationIso.Text == "")
            {
                MessageBox.Show("Please select a path and a iso file");
            }
            else
            {
                string path = textLocationPath.Text;
                string iso = textLocationIso.Text;
                string name = textMachineName.Text;
                string ram = comboBoxRam.Text.ToString();
                string cpuCount = comboBoxCores.Text.ToString();
                string vdiSizeMB = textvdiSizeMB.Text;
                string osType = comboBoxOsType.Text.ToString();
                string videoMemory = comboBoxVideoMemory.Text.ToString();
                string graphicsController = comboBoxGraphicsController.Text.ToString();
                string networkMode = comboBoxNetworkMode.Text.ToString();

                if (osType == "Windows")
                {
                    osType = "Windows7_64";
                }
                else if (osType == "Ubuntu")
                {
                    osType = "Ubuntu_64";
                }

                if (name == "")
                {
                    MessageBox.Show("Please enter a name for the virtual machine");
                }
                else
                {
                    // create the virtual machine
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "C:\\Program Files\\Oracle\\VirtualBox\\VBoxManage.exe";
                    startInfo.Arguments = "createvm --name \"" + name + "\" --ostype " + osType + " --register --basefolder \"" + path + "\"";
                    Process.Start(startInfo).WaitForExit();

                    // configure the virtual machine
                    startInfo.Arguments = "modifyvm \"" + name + "\" --memory " + ram + " --cpus " + cpuCount + " --vram " + videoMemory + " --graphicscontroller " + graphicsController + " --audio none --boot1 dvd --boot2 disk --boot3 none --nic1 " + networkMode;
                    Process.Start(startInfo).WaitForExit();

                    // create the VDI disk
                    startInfo.Arguments = "createhd --filename \"" + path + "\" --size " + vdiSizeMB;
                    Process.Start(startInfo).WaitForExit();

                    // attach the ISO image to the virtual machine
                    startInfo.Arguments = "storagectl \"" + name + "\" --name \"IDE Controller\" --add ide";
                    Process.Start(startInfo).WaitForExit();
                    startInfo.Arguments = "storageattach \"" + name + "\" --storagectl \"IDE Controller\" --port 0 --device 0 --type dvddrive --medium \"" + iso + "\"";
                    Process.Start(startInfo).WaitForExit();

                    // attach the VDI disk to the virtual machine
                    startInfo.Arguments = "storagectl \"" + name + "\" --name \"SATA Controller\" --add sata --controller IntelAhci";
                    Process.Start(startInfo).WaitForExit();
                    startInfo.Arguments = "storageattach \"" + name + "\" --storagectl \"SATA Controller\" --port 0 --device 0 --type hdd --medium \"" + path + "\"";
                    Process.Start(startInfo).WaitForExit();

                    MessageBox.Show("Máquina creada con éxito");
                }
            }
        }
    }
}
