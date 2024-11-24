using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles.Task832;

public class SolvingTask832()
{
    //Сделайте так, чтобы ваша программа из задания 8.3.1
    //при каждом запуске добавляла в свой исходный код
    //комментарий о времени последнего запуска. 


    // var fileInfo = new FileInfo(@"C:\Users\фвьшт\AppData\Local\Temp\tmpvo0fk5.tmp");

    string filePath = @"C:// Users/фвьшт/Downloads/BinaryFile.bin";
    if (File.Exists(filePath))
        {
        string stringValue;
    using(BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
{
stringValue=ReaderWriterLock.ReadString();
}
        }

        
}
