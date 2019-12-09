﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            var clw = new ConsoleLogWriter();
            var flw = new FileLogWriter();
            using (var fl = new MultipleLogWriter(clw, flw))
            {
                fl.LogInfo("Info message");
                Thread.Sleep(40);
                fl.LogWarning("Warning message");
                Thread.Sleep(350);
                fl.LogError("Error message");
            }

        }
                
        
    }
}
