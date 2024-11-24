using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkingWithFiles.ArturTask;
//Создать классы Folder(добавить свойство Size:
//посчитать размер всех вложенных файлов),
//File(name, extension, size), 

//Folder: AddFile(), AddFolder()

//Добавить навигацию стрелочками, выделять активный пункт меню.

//При нажатии на Enter В консоль выводить "Выбрана папка {Name}" или "Выбран файл {Name.extension}"

public class Folder
{
    string path = @"C://SomeDir";
    string subpath = @"program/avalon";
    DirectoryInfo dirInfo = new DirectoryInfo(path);
   if(!dirInfo.Exists)
        {
        dirInfo.Create();
        }
dirInfo.CreateSubdierctory(subpath)

      

}

}
