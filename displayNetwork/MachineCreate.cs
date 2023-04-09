using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Windows.Forms;

namespace displayNetwork
{
    internal class MachineCreate
    {
        public static void CreateMachine(string name, string path, string iso, string osType, string ram, string vdiSizeMB, string cpuCount, string videoMemory, string graphicsController, string networkMode)
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

        public static ulong GetTotalRam()
        {
            ComputerInfo CI = new ComputerInfo();
            ulong mem = ulong.Parse(CI.TotalPhysicalMemory.ToString());
            return (mem / (1024 * 1024));
        }
    }
}
