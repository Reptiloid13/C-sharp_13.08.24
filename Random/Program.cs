using Random.Tasks1;
namespace Random;
class Program
{
    public static void Main(string[] args)
    {
        DriveInfo[] drivers = DriveInfo.GetDrives();
        GetFiles(); //Почему не видно ?
        GetCatalogs();

        foreach (DriveInfo drive in drivers)
        {
            Console.WriteLine(drive.Name);
            Console.WriteLine(drive.DriveType);
            if (drive.IsReady)
            {
                Console.WriteLine($"Объем: {drive.TotalSize}");
                Console.WriteLine($"Свободно: {drive.TotalSize}");
                Console.WriteLine($"Метка: {drive.VolumeLabel}");
            }
        }

        static void GetCatalogs()
        {
            string dirName = "C:\\";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Папки: ");
                string[] dirs = Directory.GetDirectories(dirName);

                foreach (string d in dirs)
                    Console.WriteLine(d);
                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(dirName);

                foreach (string s in files)
                    Console.WriteLine(s);
            }
        }
    }

}

