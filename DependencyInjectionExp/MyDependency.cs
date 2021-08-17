using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionExp
{
    public class MyDependency : IDependency
    {
        public string  WriteMessage(string message)
        {
            return "MyDependency.WriteMessage Message:" + message;
        }
    }
}
