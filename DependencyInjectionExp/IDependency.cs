using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionExp
{
   public interface IDependency
    {
       public string  WriteMessage(string message);
    }
}
