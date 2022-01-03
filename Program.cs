using EntesProject.DatabaseOperations;
using EntesProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntesProject
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataView());
           
          
            

        }
    }
}
