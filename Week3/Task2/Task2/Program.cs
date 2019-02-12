using System;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;

namespace Task2
{
    class FarManager
    {
        public int cursor;
        public string path;
        public int sz;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;

        public FarManager()
        {
            cursor = 0;
        }

        public FarManager(string path)
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            sz = directory.GetFileSystemInfos().Length;
            ok = true;
        }

        public void Color(FileSystemInfo fs, int index)
        {
            if (cursor == index)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                currentFs = fs;
            }
            else if (fs is DirectoryInfo)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }
                Color(fs[i], k);
                Console.WriteLine(fs[i].Name);
                k++;
            }
        }
        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }

        public void CalcSz()
        {
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            sz = fs.Length;
            if (ok == false)
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')
                        sz--;
        }
        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        public void Start()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape)
            {
                CalcSz();
                Show();
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();
                if (consoleKey.Key == ConsoleKey.RightArrow)
                {
                    ok = false;
                    cursor = 0;
                }
                if (consoleKey.Key == ConsoleKey.LeftArrow)
                {
                    cursor = 0;
                    ok = true;
                }
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    if (currentFs is DirectoryInfo)
                    {
                        path = currentFs.FullName;
                    }
                    else
                    {
                        Process P = new Process();
                        P.StartInfo.FileName = "/Applications/TextEdit.app/Contents/MacOS/TextEdit";
                        P.StartInfo.Arguments = currentFs.FullName;

                        P.Start();
                    }
                    cursor = 0;
                }
                if (consoleKey.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    path = directory.Parent.FullName;
                }
                if (consoleKey.Key == ConsoleKey.D)
                {
                    if (currentFs is DirectoryInfo)
                    {
                        DeleteDirectory(currentFs.FullName);
                    }
                    else
                    {
                        currentFs.Delete();
                    }
                    cursor = 0;

                }
                if (consoleKey.Key == ConsoleKey.P)
                {
                    string oldname = currentFs.FullName;
                    string newname = Console.ReadLine();


                    File.Move(oldname, newname);

                }
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            string path = "/Users/daniyarbekulyyerassyl/documents";
            FarManager farManager = new FarManager(path);
            farManager.Start();
        }
    }
}