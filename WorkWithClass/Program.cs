namespace WorkWithClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClassesForWorkWithDisk.TestClassesforWWD();
            //WorkWithFiles.FileWriter();
            //WorkWithFiles.Task831();


        }
        //            Задание 8.1.4
        //Придумайте простой класс, который будет предоставлять информацию об
        //установленном в системе диске.

        //Нужны свойства, чтобы хранить: имя диска, объём, свободное место.С
        //Свойства инициализируются при создании нового объекта в методе-конструкто

        public class SimpleClass
        {
            public string NameOfDisk { get; set; }
            public long Capacity { get; set; }
            public long FreeSpace { get; set; }

            public SimpleClass(string nameOfDisk, long capacity, long freeSpace)
            {
                NameOfDisk = nameOfDisk;
                Capacity = capacity;
                FreeSpace = freeSpace;
            }
        }
        //       8.1.5 Нужно создать папки(директории) для сортировки файлов
        //Добавьте метод для создания новой директории на диске
        public class Folder
        {
            public List<string> Files { get; set; } = new List<string>();


            Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();
            public void CreateFolder(string name)
            {
                Folders.Add(name, new Folder());
            }

        }
    }
}
