using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using SkillFactoryTask1;
using SkillFactoryTotalSize;

namespace SkillFactory;

class SkillFactoryTasks
{

    static void Main(string[] args)
    {
        var task1 = new Task1();
        task1.DeleteUnusingFiles();
        
        
        // Todo
        // TotalSizeTask.Calculate(Path.Combine + Environment.CurrentDirectory);

        //if(Directory.GetLastWriteTime(dir)< DateTime.Now.AddSeconds(-1))
        //   {
        //       Directory.Delete(dir, true); 
        //   }
    }
}