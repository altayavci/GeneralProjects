using EntesProject.Abstracts;
using Modbus.Device;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntesProject.DatabaseOperations
{
    class ModbusDal:ConnectionController,ISqlInterfaces <SqlConnection>
    {
        SqlConnection _sqlConnection = new SqlConnection(@"server=ARGYZLM\SQLEXPRESS;initial catalog=ProjectEntes;integrated security=false;uid=sa;password=sa123");

        public void Object(SqlConnection argument)
        {
            SqlConnection _sqlConnection = new SqlConnection(@"server=ARGYZLM\SQLEXPRESS;initial catalog=ProjectEntes;integrated security=false;uid=sa;password=sa123");

        }

        public void DataReader()
        {
        
            ConnectionControlForAbstract();

            TcpClient client = new TcpClient(ConfigurationManager.AppSettings["ipAddress"], 502);
            ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

            

            // read 20 input values
            byte slaveAddress = 247;
            ushort currentStartAddress = 2014;
            ushort voltageStartAddress = 14;
            ushort numberofPoints =20;
            ushort[] currentInputs = master.ReadHoldingRegisters(slaveAddress, currentStartAddress, numberofPoints);
            ushort[] voltageInputs = master.ReadHoldingRegisters(slaveAddress, voltageStartAddress, numberofPoints);

           
           
               try
                {

                for (int i = 0; i < currentInputs.Length; i++)
                    {
                    SqlCommand command = new SqlCommand("Insert into Data(Date,Akım,Voltage,DeviceId) values(@date,@current,@voltage,@deviceid)", _sqlConnection);
                    command.Parameters.AddWithValue("@current", Convert.ToInt32(currentInputs[i]));
                    command.Parameters.AddWithValue("@date", DateTime.Now);
                    command.Parameters.AddWithValue("@voltage", Convert.ToInt32(voltageInputs[i]));
                    command.Parameters.AddWithValue("@deviceid", 4948);
                    command.ExecuteNonQuery();
                    }
                }
                catch (System.Data.SqlClient.SqlException exception)
                {
                    MessageBox.Show("Wrong Id");
                }

            //client.Close();
           
            _sqlConnection.Close();

            
        }

        public override void ConnectionControlForAbstract()
        {

            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }

       
    }
}
