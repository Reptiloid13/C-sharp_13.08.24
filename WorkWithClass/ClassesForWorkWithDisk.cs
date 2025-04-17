using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithClass
{


    public class ClassesForWorkWithDisk
    {
        public static void TestClassesforWWD()
        {
            // GetDiskInformation.GetDisk();
            // GetDiskInformation.GetCatalogs();
            GetDiskInformation.Task821();
        }
    }

    public class GetDiskInformation
    {
        //Попробуем получить информацию о дисках на компьютере: 
        public static void GetDisk()
        {


            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название -  {drive.Name}");
                Console.WriteLine($"Тип - {drive.DriveType}");

                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем - {drive.TotalSize}");
                    Console.WriteLine($"Свободно - {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка - {drive.VolumeLabel}");
                }
            }
        }

        //Попробуем получить все файлы и папки корневого каталога: 
        public static void GetCatalogs()
        {

            string dirName = @"/"; // прописываем путь к корневой папки


            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Папки - ");
                string[] dirs = Directory.GetDirectories(dirName); //получаем все директории корневого каталога

                foreach (string d in dirs)
                {
                    Console.WriteLine(d);

                    Console.WriteLine();
                    Console.WriteLine("Файлы");

                    string[] files = Directory.GetFiles(dirName); // получим все файлы корневого каталога

                    foreach (string s in files)
                        Console.WriteLine(s);
                }
            }

        }
        //        Задание 8.2.1
        //Напишите метод, который считает количество файлов и папок в корне вашего диска и выводит итоговое количество объектов

        public static void Task821()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"/");

            if (dirInfo.Exists)
            {
                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);


            }
            DirectoryInfo dirInfo2 = new DirectoryInfo(@"/");

            if (!dirInfo2.Exists)
                dirInfo2.Create();

            Console.WriteLine(dirInfo2.GetDirectories().Length + dirInfo2.GetFiles().Length);
        }

    }

}
// 1) свойства откуда можно получить полезную информацию:

//    AvailableGreeSpace - Указывает на объем доступного свободного места на диске

//    DriveFormat - Получает имя файловой системы

//    DriveType - Представляет тип диска;

//    IsReady - Готов ли диск? (например, DVD-диск может быть не вставлен в дисковод);

//    Name - Получает имя диска;

//    TotalFreeSpace - Получает общий объем свободного места на диске в байтах;

//    TotalSize - общий размер диска в байтах;

//    VolumeLavel - получает или устанавливает метку тома. 


//2) Для работы с ними в языке С#  предусмотрены два класса: Directory и DirectoryInfo.

//(!) Класс Directory предоставляет ряд статических методов для управления каталогами.
//    Наиболее используемые: 

//    CreateDirectory(path) - Создает катклог по указанному пути;
//    Delete(path) - Удаляет катклог по указанному пути;

//    Exist(path) - Оперделяет, существует ли каталог по указанному пути;

//    GetDirectories(path) - Получает список каталогов в каталоге path;

//    GetFiles(path) - Получает список фалов в каталоге path;

//    Move(source, destination) - перемещает каталог; 

//    GetParent(path) - Получение родительского каталога; 

//(!) DirectoryInfo
//    Crete() - Создает каталог;

//CreateSubdirectiry(path) - Создает подкаталок по указаному пути path;

//Delete() - Удаление каталога; 

//GetDirectories() - получает список каталогов/директорий.;

//    GetFiles() - получает список файлов;

//    MoveTo(destDirName) - пермещает катклог;
//  Свойства  Exist - определяет существует ли каталог/директорий;
//    Свойства Parent - Опрделяет родительский каталог;
//   Свойства  Root - Получение корневого кталога;