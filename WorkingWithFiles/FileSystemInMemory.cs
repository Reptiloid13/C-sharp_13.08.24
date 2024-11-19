using System.Diagnostics.CodeAnalysis;

namespace WorkingWithFiles.Model;

public class Model
{

    public void GetCatalogs()
    {
        string dirName = @"C:\\";
        if (Directory.Exists(dirName))
        {
            Console.WriteLine("Folders: ");
            string[] dirs = Directory.GetDirectories(dirName);
            foreach (string dir in dirs)
                Console.WriteLine(dir);
            Console.WriteLine();
            Console.WriteLine("Files");
            string[] files = Directory.GetFiles(dirName);
            foreach (string s in files)
                Console.WriteLine(s);
        }
    }
    public void GetCatalogsVer2()
    {
        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C://");
            if (dirInfo.Exists)
            {
                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);

            }



            DirectoryInfo newdirInfo = new DirectoryInfo(@"C:\Users\luft");
            if (!newdirInfo.Exists)
                newdirInfo.Create();

            newdirInfo.CreateSubdirectory("NewFolder");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}