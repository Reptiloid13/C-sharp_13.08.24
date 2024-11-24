using System;
using System.IO;
using WorkingWithFiles.Model;
using WorkingWithFiles.CreateFile;
namespace WorkingWithFiles
{
    class FileWriter
    {
        public static void Main()
        {
            var test = new Model.Model();
            test.GetCatalogsVer2();
            var test1 = new CreateFile.Model();
            test1.GetFile();





        }
    }
}