
using GeneralDatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntesProject.Abstracts
{
    public abstract class BaseAbstract <T>:ConnectionController
    {

        public abstract void Add(T argument);

        public abstract void Delete(T argument);

        public abstract void Update(T argument);

        public int Id { get; set; }

        //nesneyi burda tanımla 

        //public abstract void ConnectionControlForAbstract();
        //taşınacak 
        

        

    }
}
