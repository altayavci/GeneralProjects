using EntesProject.Abstracts;
using GeneralDatas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntesProject.Forms
{
    public partial class DataAdd : Form,IDataLoads
    {
        
        General.ModemDatas _modem = new General.ModemDatas();
        General.DeviceDatas _device = new General.DeviceDatas();
        General.Datas _datas = new General.Datas();
        SqlConnection _sqlConnection = new SqlConnection(@"server=ARGYZLM\SQLEXPRESS;initial catalog=ProjectEntes;integrated security=false;uid=sa;password=sa123");

        //bu nesneleri IObjects... interfaceinden getir !!

        public DataAdd()
        {
            InitializeComponent();
        }

        private void btnDeviceAdd_Click(object sender, EventArgs e)
        {
            General.DeviceDatas deviceDatas = new General.DeviceDatas();

            try
            {
                deviceDatas.ModelName = tbxModelName.Text.ToString();
                deviceDatas.Nod = Convert.ToInt32(tbxNod.Text);
                deviceDatas.ModemId = Convert.ToInt32(tbxModemId.Text);
                deviceDatas.Model = tbxModel.Text.ToString();
                deviceDatas.IsActive = true;
                _device.Add(deviceDatas);
                DeviceDatasLoad();
                MessageBox.Show("Added !");
            }

            catch (System.Data.SqlClient.SqlException exception)
            {
                MessageBox.Show("Try again");
            }

            finally
            {
                _sqlConnection.Close();
            }

            
        }

        private void btnModemAdd_Click(object sender, EventArgs e)
        {
            General.ModemDatas modemDatas = new General.ModemDatas();
            modemDatas.Ip = tbxIp.Text.ToString();
            modemDatas.Mac = tbxMac.Text.ToString(); 
            modemDatas.BaudRate = Convert.ToInt32(tbxBaudRate.Text);
            modemDatas.ModelName = tbxModelNameModem.Text.ToString();
            _modem.Add(modemDatas);
            ModemDatasLoad();

            MessageBox.Show("Added !");
        }

        private void btnDataAdd_Click(object sender, EventArgs e)
        {
            General.Datas datas = new General.Datas();


            {
                try
                {
                    datas.Date = Convert.ToDateTime(tbxDate.Text);
                    datas.Current = Convert.ToInt32(tbxCurrent.Text);
                    datas.Voltage = Convert.ToInt32(tbxVoltage.Text);
                    datas.DeviceId = Convert.ToInt32(tbxDeviceId.Text);
                    _datas.Add(datas);
                    DatasLoad();
                    MessageBox.Show("Added !");

                }

                catch (System.Data.SqlClient.SqlException exception)
                {
                    MessageBox.Show("Try Again");

                }

                finally
                {
                    _sqlConnection.Close();
                }

            }
        }
   
        public void DeviceDatasLoad()
        {
            dgwDataAdding.DataSource = _device.GetAllDeviceDatas();
            
        }

        public void DatasLoad()
        {
            dgwDataAdding.DataSource = _datas.GetAllDatas();
        }

        public void ModemDatasLoad()
        {
            dgwDataAdding.DataSource = _modem.GetAllModemDatas();
        }

        private void chbxActive_CheckedChanged(object sender, EventArgs e)
        {
            
        }

      
    }
}
