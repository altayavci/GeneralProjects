using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntesProject
{
    public class Objects <T> where T:class,new()
    {
        public void ObjectMaker(T argument)
        {
            T arg = new T();
        }

    }
}
