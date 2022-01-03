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
    public partial class DataDelete : Form,IDataLoads
    {
        
        General.ModemDatas _modem = new General.ModemDatas();
        General.Datas _datas = new General.Datas();
        General.DeviceDatas _device = new General.DeviceDatas();
        
        SqlConnection _sqlConnection = new SqlConnection(@"server=ARGYZLM\SQLEXPRESS;initial catalog=ProjectEntes;integrated security=false;uid=sa;password=sa123");

        public DataDelete()
        {
            InitializeComponent();
        }

        public void DeviceDatasLoad()
        {
            dgwDelete.DataSource = _device.GetAllDeviceDatas();
        }

        public void DatasLoad()
        {
            dgwDelete.DataSource = _datas.GetAllDatas();
        }

        public void ModemDatasLoad()
        {
            dgwDelete.DataSource = _modem.GetAllModemDatas();
        }

        private void cbxDeleteData_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelValue.Text = cbxDeleteData.Text;

            if (labelValue.Text == "Device")
            {
                DeviceDatasLoad();
                

            }
            else if (labelValue.Text == "Datas")
            {

                DatasLoad();
            }
            else if (labelValue.Text == "Modem")
            {
                ModemDatasLoad();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (labelValue.Text == "Modem")
            {
                try
                {
                    General.ModemDatas modem = new General.ModemDatas();
                    modem.Id = Convert.ToInt32(dgwDelete.CurrentRow.Cells[dgwDelete.ColumnCount - 1].Value);

                    _modem.Delete(modem);
                    ModemDatasLoad();
                    MessageBox.Show("Selected Data from Modem is deleted.");
                }
                catch (System.Data.SqlClient.SqlException exception) {

                   
                    MessageBox.Show("Something is wrong...");
                }
                finally
                {
                    _sqlConnection.Close();
                }
                
            }

            else if (labelValue.Text == "Datas")
            {
                try
                {
                    General.Datas datas = new General.Datas();
                    datas.Id = Convert.ToInt32(dgwDelete.CurrentRow.Cells[dgwDelete.ColumnCount - 1].Value);

                    _datas.Delete(datas);
                    DatasLoad();

                    MessageBox.Show("Selected Data from Datas is deleted.");
                }
                catch (System.Data.SqlClient.SqlException exception)
                {
                    MessageBox.Show("Something is wrong...");
                }
                finally
                {
                    _sqlConnection.Close();
                }
            }

            else if (labelValue.Text == "Device")
            {
                try
                {
                    General.DeviceDatas device = new General.DeviceDatas();
                    device.Id = Convert.ToInt32(dgwDelete.CurrentRow.Cells[dgwDelete.ColumnCount - 1].Value);
                    device.IsActive = false;
                    _device.Delete(device);
                    DeviceDatasLoad();

                    MessageBox.Show("Selected Data from Device is deleted.");
                }
                catch (System.Data.SqlClient.SqlException exception )
                {
                    MessageBox.Show("Something is wrong...");

                }
                finally
                {
                    _sqlConnection.Close();
                }

            }


        }

    }



}
