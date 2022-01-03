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
    public partial class DataGet : Form,IDataLoads
    {
        SqlConnection _sqlConnection = new SqlConnection(@"server=ARGYZLM\SQLEXPRESS;initial catalog=ProjectEntes;integrated security=false;uid=sa;password=sa123");
        General.DeviceDatas _device = new General.DeviceDatas();
        General.ModemDatas _modem = new General.ModemDatas();
        General.Datas _datas = new General.Datas();
     
        public DataGet()
        {
            InitializeComponent();
        }

        private void DataGet_Load(object sender, EventArgs e)
        {
            //dgwGet.DataSource = _device.GeT();
        }

        private void btnGetMac_Click(object sender, EventArgs e)
        {
            var query =tbxGet.Text.ToString();
            dgwGet.DataSource = _device.Get(query);
            lblQuery.Text = "Device Datas";

        }

        private void cbxGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGet.Text == cbxGet.Items[0].ToString()) 
            {
                ModemDatasLoad();
                gbxModem.Show();

            }
            else if (cbxGet.Text == cbxGet.Items[1].ToString())
            {
                DeviceDatasLoad();
                
            }
            
            lblSearching.Text = cbxGet.Text;
        }

        public void DeviceDatasLoad()
        {
            dgwShowDatas.DataSource = _device.GetAllDeviceDatas();
        }

        public void DatasLoad()
        {
            dgwShowDatas.DataSource = _datas.GetAllDatas();
        }

        public void ModemDatasLoad()
        {
            dgwShowDatas.DataSource = _modem.GetAllModemDatas();
        }

        private void btnDataSearching_Click(object sender, EventArgs e)
        {
            
            try    
            {
                var query = Convert.ToInt32(tbxDataSearching.Text);
                dgwGet.DataSource = _datas.Get(query);
            }
            catch (System.Data.SqlClient.SqlException exception)
            {
                MessageBox.Show("Something is wrong...");
            }
            catch (System.InvalidOperationException exception1)
            {
                MessageBox.Show("Something is wrong...");
            }
            finally
            {
                _sqlConnection.Close();
            }
            lblQuery.Text = "Datas";
 
        }

        private void dgwShowDatas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbxGet.Text == "Modem Datas")
            {
                tbxGet.Text = dgwShowDatas.CurrentRow.Cells[0].Value.ToString();
               
                
            }
            else if (cbxGet.Text== "Device Datas")
            {
                tbxDataSearching.Text = dgwShowDatas.CurrentRow.Cells[dgwShowDatas.ColumnCount-1].Value.ToString();
            }
           

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDatas(tbxSearch.Text);
        }

        private void SearchDatas(string key)
        {
            if (cbxGet.Text == cbxGet.Items[0].ToString()) {

                var resultModem = _modem.GetAllModemDatas().Where(p => p.ModelName.ToLower().Contains(key.ToLower())).ToList();
                dgwShowDatas.DataSource = resultModem;
                

            }
            else if (cbxGet.Text==cbxGet.Items[1].ToString()) {

                var resultDevice = _device.GetAllDeviceDatas().Where(p => p.ModelName.ToLower().Contains(key.ToLower())).ToList();
                dgwShowDatas.DataSource = resultDevice;
                //bunu GetByName diye bi method ile yaparsan direkt LINQ ile sql e komut gönderir !! , where methodu collection objectlerde çalışır !
                
            }





        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var theDate = dateTimePicker1.Value.ToShortDateString();
            var resultData = _datas.GetAllDatas().Where(p => p.Date.ToString().Contains(theDate)).ToList();
            dgwShowDatas.DataSource = resultData;
            cbxGet.Text = cbxGet.Items[2].ToString();

        }
    }
}
