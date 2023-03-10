using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net.Sockets;
using SimpleWifi;
using System.Management;
using System.Text.RegularExpressions;
using System.Drawing;
using Microsoft.WindowsAPICodePack.Net;
using System.IO;

namespace displayNetwork
{
    internal class GetInfo
    {
        public static string GetHostname()
        {
            return Dns.GetHostName();
        }

        public static string GetVirtualBoxVersion()
        {
            if (File.Exists("C:\\Program Files\\Oracle\\VirtualBox\\VBoxManage.exe"))
            {
                var version = FileVersionInfo.GetVersionInfo("C:\\Program Files\\Oracle\\VirtualBox\\VBoxManage.exe").FileVersion;

                return version == null ? "N/A" : version;
            }
            else
            {
                return "N/A";
            }
        }

        public static string GetVmWareVersion()
        {
            if (File.Exists("C:\\Program Files (x86)\\VMware\\VMware Workstation\\vmware.exe"))
            {
                var version = FileVersionInfo.GetVersionInfo("C:\\Program Files (x86)\\VMware\\VMware Workstation\\vmware.exe").FileVersion;

                return version == null ? "N/A" : version;
            }
            else
            {
                return "N/A";
            }
        }

        public static string GetMacAddress()
        {
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }

            return macAddresses;
        }

        public static string GetSsid()
        {
            var ssid = "Disconnected";
            
            var process = new Process
            {
                StartInfo = {
                    FileName = "netsh.exe",
                    Arguments = "wlan show interfaces",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            process.Start();

            var output = process.StandardOutput.ReadToEnd();
            var line = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault(l => l.Contains("SSID") && !l.Contains("BSSID"));
            if (line == null)
            {
                return string.Empty;
            }

            if (line.Contains("SSID")) ssid = line.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries)[1].TrimStart();
            else ssid = "Ethernet";

            return ssid;
        }

        public static string GetSsidStatus()
        {
            var networks = NetworkListManager.GetNetworks(NetworkConnectivityLevels.Connected);
            foreach (var network in networks)
            {
                if (network.IsConnected) return "Connected";
            }
            return "Disconnected";
        }

        public static string GetIpHost()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                if (adapter.Description.ToLower().Contains("virtual") || adapter.Description.ToLower().Contains("vmware") || adapter.Description.ToLower().Contains("virtualbox")) continue;

                if (adapter.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ip = adapter.GetIPProperties();
                    foreach (UnicastIPAddressInformation ipInfo in ip.UnicastAddresses)
                    {
                        if (ipInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            return ipInfo.Address.ToString();
                        }
                    }
                }
            }
            return "Loading...";
        }

        public static string GetIpGateway()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                if (adapter.Description.ToLower().Contains("virtual") || adapter.Description.ToLower().Contains("vmware") || adapter.Description.ToLower().Contains("virtualbox")) continue;

                if (adapter.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ip = adapter.GetIPProperties();
                    foreach (GatewayIPAddressInformation ipInfo in ip.GatewayAddresses)
                    {
                        if (ipInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            return ipInfo.Address.ToString();
                        }
                    }
                }
            }
            return "Loading...";
        }

        public static string GetUsername()
        {
            return Environment.UserName;
        }

        public static string GetInternetConnection()
        {
            Ping ping = new Ping();
            PingReply pingStatus = ping.Send("8.8.8.8");
            if (pingStatus.Status == IPStatus.Success) return "Connected";
            else return "Disconnected";
        }

        public static string GetVmWareInstall()
        {
            if (File.Exists("C:\\Program Files (x86)\\VMware\\VMware Workstation\\vmware.exe"))
            {

                string[] files = Directory.GetFiles(@"C:\Program Files (x86)\VMware\VMware Workstation", "vmware-authd.exe", SearchOption.AllDirectories);

                if (files.Length > 0) return "Installed";
                else return "Not installed";
            }
            else
            {
                return "Not installed";
            }
        }

        public static string GetVirtualBoxInstall()
        {
            if (File.Exists("C:\\Program Files\\Oracle\\VirtualBox\\VBoxManage.exe"))
            {
                string[] files = Directory.GetFiles(@"C:\Program Files\Oracle\VirtualBox", "VBoxManage.exe", SearchOption.AllDirectories);

                if (files.Length > 0) return "Installed";
                else return "Not installed";
            }
            else
            {
                return "Not installed";
            }
        }
    }
}
