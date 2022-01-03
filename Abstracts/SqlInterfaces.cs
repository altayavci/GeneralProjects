using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntesProject.Abstracts
{
    public interface ISqlInterfaces <T> where T:class,new()
    {
        void Object(T argument);

    }
}
