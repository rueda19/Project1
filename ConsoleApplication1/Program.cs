using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Diagnostics.Debug.Write(Sys);
            String user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            System.Diagnostics.Debug.Write(user);
        }
    }
}
