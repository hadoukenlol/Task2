using System.Drawing;
using System.IO;

namespace HomeWorkFiles2
{
    internal class Program
    {
        public static long size = 0;
        static void Main(string[] args)
        {
            var Dir = new DirectoryInfo("D://dirDeleting/");
            var Directories = Dir.GetDirectories();
            ShowDirectoryInfo(Directories);
            ShowFileInfo(Dir);
            Console.WriteLine(size);
        }

        public static void ShowDirectoryInfo(DirectoryInfo [] rootDir)
        {
            foreach (var Dir in rootDir)
            {
                try
                {
                    size += DirectoryExtension.DirSize(Dir);
                }
                catch (Exception e)
                {
                    Console.WriteLine (Dir.Name + $" - Не удалось скачать - {e.Message}");
                }
            }
        }

        public static void ShowFileInfo(DirectoryInfo rootDir)
        {
            foreach (var item in rootDir.GetFiles())
            {
                size += item.Length;
            }
        }

    }
}