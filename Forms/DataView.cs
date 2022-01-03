using EntesProject.Abstracts;
using EntesProject.Forms;
using GeneralDatas;
using NModbusWorkshop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntesProject
{
    public partial class DataView : Form,IDataLoads
    {
       
        General.ModemDatas _modem = new General.ModemDatas();
        General.DeviceDatas _device = new General.DeviceDatas();
        General.Datas _datas = new General.Datas();
        

        public DataView()
        {
            InitializeComponent();
        }

        private void cbxAddDatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            labelValue.Text = cbxAddDatas.Text;

            if (labelValue.Text=="Device") //cbxAddDatas.Text == cbxAddDatas.Items[0].ToString() bu da olabilir fakat string cok daha hızlı
            {
                DeviceDatasLoad();
                //deneme.IsActive = true;
                //dgwDeviceDatas.DataSource = deneme.GetDatas();
            }
            else if (labelValue.Text=="Datas" ){

                DatasLoad();
            }
            else if (labelValue.Text=="Modem")
            {
                ModemDatasLoad();
            }
            
           
    }

        public void DeviceDatasLoad()
        {
            dgwDeviceDatas.DataSource = _device.GetAllDeviceDatas();
        }

        public void DatasLoad()
        {
            dgwDatas.DataSource = _datas.GetAllDatas();
        }

        public void ModemDatasLoad()
        {
            dgwModemDatas.DataSource = _modem.GetAllModemDatas();

        }

        private void btnAccessAdd_Click(object sender, EventArgs e)
        {
            DataAdd dataAdd = new DataAdd();
            dataAdd.Show();
        }

        private void btnAccessDelete_Click(object sender, EventArgs e)
        {
            DataDelete dataDelete = new DataDelete();
            dataDelete.Show();
            
        }

        private void btnAccessUpdate_Click(object sender, EventArgs e)
        {
            DataUpdate dataUpdate = new DataUpdate();
            dataUpdate.Show();
           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void btnAccessGet_Click(object sender, EventArgs e)
        {
            DataGet dataGet = new DataGet();
            dataGet.Show();
        }

        private void btnModbusGet_Click(object sender, EventArgs e)
        {
            ModbusGet modbusGet = new ModbusGet();
            modbusGet.Show();
        }

        private void btnDeviceController_Click(object sender, EventArgs e)
        {
            ModbusDesign modbusDesign = new ModbusDesign();
            modbusDesign.Show();
        }
    }
}
