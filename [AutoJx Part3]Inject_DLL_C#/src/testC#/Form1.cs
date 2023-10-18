using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static testC_.frmMain;

namespace testC_ {
    public partial class frmMain : Form {
        [DllImport("kernel32.dll")] private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("Kernel32.dll")] private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out int lpNumberOfBytesRead);
        [DllImport("kernel32.dll")] private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll")] private static extern Int32 CloseHandle(IntPtr hProcess);
        [DllImport("kernel32.dll")] private static extern IntPtr GetModuleHandle(string lpModuleName);
        [DllImport("kernel32.dll")] private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
        [DllImport("kernel32.dll")] private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, int flAllocationType, int flProtect);
        [DllImport("kernel32.dll")] private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, int dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        private const int PROCESS_VM_READ = 0x0010;
        private const int PROCESS_VM_WRITE = 0x0020;
        private const int PROCESS_VM_OPERATION = 0x0008;
        private const int PROCESS_CREATE_THREAD = 0x0002;
        private const int PROCESS_QUERY_INFORMATION = 0x0400;

        private const int MEM_COMMIT = 0x00001000;
        private const int MEM_RESERVE = 0x00002000;
        private const int PAGE_READWRITE = 4;

        public const string GAMEY_EXE_NAME = "Game";
        public const string GAMEY_MODULE_NAME = "Game.exe";
        public const string CORE_FILE_NAME = "test.dll";
        public const string CORE_MODULE_NAME = "test.dll";
        public static int TCVN3_CODEPAGE = 1252;

        public frmMain() {
            InitializeComponent();
        }

        private void lswGBasic_ItemChecked(object sender, ItemCheckedEventArgs e) {
            ListViewItem lswItem = e.Item;
            if (!lswItem.Focused) return;
            if (string.IsNullOrEmpty(lswItem.Text)) {
                lswItem.Checked = false;
                return;
            }
            int.TryParse(lswItem.SubItems[3].Text, out int gPid);
            if (lswItem.Checked) {
                Process gProc = Process.GetProcessById(gPid);
                if (GetModuleBaseAddress(gProc, CORE_MODULE_NAME) == IntPtr.Zero) {
                    string dllFilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + Path.DirectorySeparatorChar + CORE_FILE_NAME;
                    inject(gPid, dllFilePath);
                }
            }
        }

        private static void inject(int procId, string dllFilePath) {
            IntPtr procHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, procId);
            IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
            IntPtr allocMemAddress = VirtualAllocEx(procHandle, IntPtr.Zero, (dllFilePath.Length + 1) * Marshal.SizeOf(typeof(char)), MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);
            WriteProcessMemory(procHandle, allocMemAddress, Encoding.Default.GetBytes(dllFilePath), ((dllFilePath.Length + 1) * Marshal.SizeOf(typeof(char))), out _);
            CreateRemoteThread(procHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);
            CloseHandle(procHandle);
        }

        private void tmGlobal_Tick(object sender, EventArgs e) {
            Process[] gProcs = Process.GetProcessesByName(GAMEY_EXE_NAME);
            foreach (ListViewItem lswItem in lswGBasic.Items) {
                int lswGPid = 0;
                if (lswItem.SubItems.Count >= 4) int.TryParse(lswItem.SubItems[3].Text, out lswGPid);
                if (!gProcs.Any(x => x.Id == lswGPid)) lswGBasic.Items.Remove(lswItem);
            }
            foreach (Process gProc in gProcs) {
                int gPid = gProc.Id;
                IntPtr gBaseAddr = GetModuleBaseAddress(gProc, GAMEY_MODULE_NAME);
                string charName = getCharName(gPid, gBaseAddr);
                string mapName = getMapName(gPid, gBaseAddr);
                string serverName = getServerName(gPid, gBaseAddr);
                var lswItem = lswGBasic.Items.Cast<ListViewItem>().FirstOrDefault(item => (item.SubItems[3].Text == gPid.ToString()));
                if (lswItem != default(ListViewItem)) {
                    lswItem.SubItems[0].Text = charName;
                    lswItem.SubItems[1].Text = mapName;
                    lswItem.SubItems[2].Text = serverName;
                    lswItem.SubItems[3].Text = gPid.ToString();
                } else {
                    lswGBasic.Items.Add(new ListViewItem { Text = charName, SubItems = { mapName, serverName, gPid.ToString() } });
                }
            }
        }

        private string getCharName(int gPid, IntPtr gBaseAddr) {
            return ReadStringMemory(gPid, IntPtr.Add(gBaseAddr, 0x2DF3B0), Encoding.GetEncoding(TCVN3_CODEPAGE), 32);
        }
        private string getMapName(int gPid, IntPtr gBaseAddr) {
            return ReadStringMemory(gPid, IntPtr.Add(gBaseAddr, 0xEFA5A0), Encoding.GetEncoding(TCVN3_CODEPAGE), 32);
        }
        private string getServerName(int gPid, IntPtr gBaseAddr) {
            return ReadStringMemory(gPid, IntPtr.Add(gBaseAddr, 0x2DF32C), Encoding.GetEncoding(TCVN3_CODEPAGE), 32);
        }

        public static string ReadStringMemory(int procId, IntPtr address, Encoding encoding, int maxSize) {
            byte[] bytes = ReadBytesMemory(procId, address, maxSize);
            if (bytes.Length == 0) return string.Empty;
            return encoding.GetString(bytes.TakeWhile(b => !b.Equals(0)).ToArray());
        }
        public static byte[] ReadBytesMemory(int procId, IntPtr address, int size) {
            byte[] buffer = new byte[size];
            IntPtr procHandle = OpenProcess(PROCESS_VM_READ, false, procId);
            ReadProcessMemory(procHandle, address, buffer, buffer.Length, out _);
            CloseHandle(procHandle);
            return buffer;
        }
        public static IntPtr GetModuleBaseAddress(int procId, string moduleName) {
            try {
                Process proc = Process.GetProcessById(procId);
                return GetModuleBaseAddress(proc, moduleName);
            } catch { return IntPtr.Zero; }
        }
        public static IntPtr GetModuleBaseAddress(Process proc, string moduleName) {
            IntPtr address = IntPtr.Zero;
            foreach (ProcessModule procModule in proc.Modules) {
                if (procModule.ModuleName.ToLower() == moduleName.ToLower()) {
                    address = procModule.BaseAddress;
                    break;
                }
            }
            return address;
        }

    }
}
