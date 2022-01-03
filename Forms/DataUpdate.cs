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
    public partial class DataUpdate : Form, IDataLoads
    {

        General.ModemDatas _modem = new General.ModemDatas();
        General.DeviceDatas _device = new General.DeviceDatas();
        General.Datas _datas = new General.Datas();
        SqlConnection _sqlConnection = new SqlConnection(@"server=ARGYZLM\SQLEXPRESS;initial catalog=ProjectEntes;integrated security=false;uid=sa;password=sa123");

        public DataUpdate()
        {
            InitializeComponent();
        }

        public void DatasLoad()
        {
            dgwDataUpdate.DataSource = _datas.GetAllDatas();
        }

        public void DeviceDatasLoad()
        {
            dgwDataUpdate.DataSource = _device.GetAllDeviceDatas();
        }

        public void ModemDatasLoad()
        {
            dgwDataUpdate.DataSource = _modem.GetAllModemDatas();
        }

        private void cbxUpdateDatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelValue.Text = cbxUpdateDatas.Text;

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

        private void btnDeviceUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                General.DeviceDatas device = new General.DeviceDatas();
                device.Nod = Convert.ToInt32(tbxNod.Text);
                device.ModelName = tbxModelName.Text.ToString();
                device.ModemId = Convert.ToInt32(tbxModemId.Text);
                device.Id = Convert.ToInt32(dgwDataUpdate.CurrentRow.Cells[dgwDataUpdate.ColumnCount - 1].Value);
                device.Model = tbxModel.Text.ToString();
                device.IsActive = Convert.ToBoolean(chbxIsActive.Checked);

                _device.Update(device);
                DeviceDatasLoad();
                MessageBox.Show("Updated !");
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

        private void btnModemUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                General.ModemDatas modem = new General.ModemDatas();
                modem.Id = Convert.ToInt32(dgwDataUpdate.CurrentRow.Cells[dgwDataUpdate.ColumnCount - 1].Value);
                modem.Ip = tbxIp.Text.ToString();
                modem.Mac = tbxMac.Text.ToString();
                modem.BaudRate = Convert.ToInt32(tbxBaudRate.Text);
                modem.ModelName = tbxModelNameModem.Text.ToString();
                _modem.Update(modem);
                ModemDatasLoad();
                MessageBox.Show("Updated !");
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

        private void btnDataUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                General.Datas datas = new General.Datas();
                datas.Id = Convert.ToInt32(dgwDataUpdate.CurrentRow.Cells[dgwDataUpdate.ColumnCount - 1].Value);
                datas.Current = Convert.ToInt32(tbxCurrent.Text);
                datas.Voltage = Convert.ToInt32(tbxVoltage.Text);
                datas.Date = Convert.ToDateTime(tbxDate.Text);
                datas.DeviceId = Convert.ToInt32(tbxDeviceId.Text);

                _datas.Update(datas);
                DatasLoad();
                MessageBox.Show("Updated !");
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

        private void dgwDataUpdate_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (labelValue.Text == "Device")
            {
                tbxModelName.Text = dgwDataUpdate.CurrentRow.Cells[0].Value.ToString();
                tbxModel.Text = dgwDataUpdate.CurrentRow.Cells[1].Value.ToString();
                tbxModemId.Text = dgwDataUpdate.CurrentRow.Cells[2].Value.ToString();
                tbxNod.Text = dgwDataUpdate.CurrentRow.Cells[3].Value.ToString();
                chbxIsActive.Checked = Convert.ToBoolean(dgwDataUpdate.CurrentRow.Cells[4].Value);

            }
            else if (labelValue.Text == "Datas")
            {
                tbxDate.Text = dgwDataUpdate.CurrentRow.Cells[0].Value.ToString();
                tbxCurrent.Text = dgwDataUpdate.CurrentRow.Cells[1].Value.ToString();
                tbxDeviceId.Text = dgwDataUpdate.CurrentRow.Cells[2].Value.ToString();
                tbxVoltage.Text = dgwDataUpdate.CurrentRow.Cells[3].Value.ToString();


            }
            else if (labelValue.Text == "Modem")
            {
                tbxMac.Text = dgwDataUpdate.CurrentRow.Cells[0].Value.ToString();
                tbxBaudRate.Text = dgwDataUpdate.CurrentRow.Cells[1].Value.ToString();
                tbxIp.Text = dgwDataUpdate.CurrentRow.Cells[2].Value.ToString();
                tbxModelNameModem.Text = dgwDataUpdate.CurrentRow.Cells[3].Value.ToString();

            }


        }

        private void chbxIsActive_CheckedChanged(object sender, EventArgs e)
        {

            switch (chbxIsActive.CheckState)
            {
                case CheckState.Checked:
                    _device.IsActive = true;
                    break;
                case CheckState.Unchecked:
                    _device.IsActive = false;
                    break;
                case CheckState.Indeterminate:
                    _device.IsActive = true;
                    break;
            }
        }
    }
}
