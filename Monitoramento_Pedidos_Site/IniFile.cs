using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Monitoramento_Pedidos_Site
{
    public class IniFile
    {
        string path;
        string exe = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath = null)
        {
            path = new FileInfo(IniPath ?? exe + ".ini").FullName;
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? exe, Key, "", RetVal, 255, path);
            return RetVal.ToString();
        }

    }
}
