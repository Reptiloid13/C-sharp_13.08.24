using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Playground2.Tasks1
{
    class Person
    {
        public event Action GoToSleep;
        public event EventHandler DoWork;

        public string Name { get; set; }

        public void TakeTime(DateTime now)
        {
            if (now.Hour <= 8)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                var args = new EventArgs();

                DoWork?.Invoke(this, null);
            }

        }
    }
}