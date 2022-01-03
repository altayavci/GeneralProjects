using EntesProject.DatabaseOperations;
using GeneralDatas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntesProject.Forms
{
    public partial class ModbusGet : Form
    {
        ModbusDal modbusDal = new ModbusDal();
        General.Datas datas = new General.Datas();

        public ModbusGet()
        {
            InitializeComponent();
        }

        private void cbxModbusGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxModbusGet.Text=="Datas")
            {
                modbusDal.DataReader();
                dgwModbusGet.DataSource = datas.GetAllDatas();
                lblCount.Text = datas.GetAllDatas().Count.ToString();

            }
        }

     
    }
}
