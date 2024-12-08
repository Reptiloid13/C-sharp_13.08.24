using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using SkillFactoryTask1;

namespace SkillFactory;

class SkillFactoryTasks
{

    static void Main(string[] args)
    {
        var task1 = new Task1();
        task1.DeleteUnusingFiles();

        //if(Directory.GetLastWriteTime(dir)< DateTime.Now.AddSeconds(-1))
        //   {
        //       Directory.Delete(dir, true); 
        //   }
    }
}