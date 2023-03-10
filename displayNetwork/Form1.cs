using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
