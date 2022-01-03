using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntesProject.Abstracts;



namespace GeneralDatas
{
    public class General
    {
       
        public class DeviceDatas : BaseAbstract<General.DeviceDatas>
        {
            SqlConnection _sqlConnection = new SqlConnection(@"server=ARGYZLM\SQLEXPRESS;initial catalog=ProjectEntes;integrated security=false;uid=sa;password=sa123");
            //SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.AppSettings[@"adress"]);

            public string ModelName { get; set; }
            public string Model { get; set; }
            public int ModemId { get; set; }
            public int Nod { get; set; }
            public bool IsActive { get; set; }
           
            

            public override void Add(DeviceDatas device)
            {
                ConnectionControlForAbstract();
                
                SqlCommand command = new SqlCommand("Insert into Device(Nod,ModelName,ModemId,Model,IsActive) values(@nod,@modelname,@modemid,@model,@isactive)", _sqlConnection);
                DeviceDatasParametersAddWithValueMethod(device, command);
                //üsttekileri de class içinde fonksiyon oluştururarak direkt çağır

                //values için databasedeki sıra ÇOK önemli !!

                command.ExecuteNonQuery();
                //_sqlConnection.Close();
                
            }

            public List<General.DeviceDatas> GetAllDeviceDatas()
            {
                ConnectionControlForAbstract();

                SqlCommand comandDevice = new SqlCommand("Select *from Device ", _sqlConnection);

                SqlDataReader sqlDataReader = comandDevice.ExecuteReader();
                List<General.DeviceDatas> device = new List<General.DeviceDatas>();

                while (sqlDataReader.Read())
                {
                    DeviceDatas deviceDatas = GetMethodDeviceReader(sqlDataReader);

                    device.Add(deviceDatas);

                }

                sqlDataReader.Close();
                _sqlConnection.Close();


                return device;

            }

            public override void Delete(DeviceDatas device)
            {
                ConnectionControlForAbstract();
                SqlCommand command = new SqlCommand("Delete from Device where Id=@id", _sqlConnection);

                command.Parameters.AddWithValue("@id", device.Id);

                command.ExecuteNonQuery();
                //_sqlConnection.Close();
            }

            public List<General.DeviceDatas> Get(string mac)
            {
                ConnectionControlForAbstract();

                SqlCommand command = new SqlCommand("Select *from Device where ModemId=(Select Id from Modem where Mac=@mac)", _sqlConnection);

             
       
                command.Parameters.AddWithValue("@mac",mac);
                
                SqlDataReader sqlDataReader = command.ExecuteReader();
                List<General.DeviceDatas> deviceForGet = new List<General.DeviceDatas>();
                

                while (sqlDataReader.Read())
                {
                    DeviceDatas deviceDatas = GetMethodDeviceReader(sqlDataReader);


                    deviceForGet.Add(deviceDatas);
                    

                }
                

                sqlDataReader.Close();
                _sqlConnection.Close();
                
                return deviceForGet;

            }

            public override void Update(DeviceDatas device)
            {
                ConnectionControlForAbstract();
                SqlCommand command = new SqlCommand("Update Device set Nod=@nod,ModelName=@modelname,ModemId=@modemid,Model=@model,IsActive=@isactive where Id=@id", _sqlConnection);

                DeviceDatasParametersAddWithValueMethod(device, command);
                command.Parameters.AddWithValue("@id", device.Id);

                command.ExecuteNonQuery();
                //_sqlConnection.Close();
            }

            private static void DeviceDatasParametersAddWithValueMethod(DeviceDatas device, SqlCommand command)
            {
                command.Parameters.AddWithValue("@modelname", device.ModelName);
                command.Parameters.AddWithValue("@modemid", device.ModemId);
                command.Parameters.AddWithValue("@nod", device.Nod);
                command.Parameters.AddWithValue("model", device.Model);
                command.Parameters.AddWithValue("@isactive", device.IsActive);
            }

            private static DeviceDatas GetMethodDeviceReader(SqlDataReader sqlDataReader)
            {
                return new General.DeviceDatas
                {
                    Id = sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(sqlDataReader["Id"]) : Convert.ToInt32(null),
                    Nod = sqlDataReader["Nod"] != DBNull.Value ? Convert.ToInt32(sqlDataReader["Nod"]) : Convert.ToInt32(null),
                    ModelName = sqlDataReader["ModelName"] != DBNull.Value ? sqlDataReader["ModelName"].ToString() : "NULL",
                    ModemId = sqlDataReader["ModemId"]!=DBNull.Value ? Convert.ToInt32(sqlDataReader["ModemId"]):Convert.ToInt32(null),
                    Model = sqlDataReader["Model"]!=DBNull.Value ? sqlDataReader["Model"].ToString():"NULL",
                    IsActive = sqlDataReader["IsActive"] != DBNull.Value ?Convert.ToBoolean(sqlDataReader["IsActive"]) :Convert.ToBoolean(null)

                };
            }

            public override void ConnectionControlForAbstract()
            {

                if (_sqlConnection.State == ConnectionState.Closed)
                {
                    _sqlConnection.Open();
                }

            }

          
        }

        public class ModemDatas : BaseAbstract<General.ModemDatas>
        {

            SqlConnection _sqlConnection = new SqlConnection(@"server=ARGYZLM\SQLEXPRESS;initial catalog=ProjectEntes;integrated security=false;uid=sa;password=sa123");

            public string Mac { get; set; }
            public int BaudRate { get; set; }
            public string Ip { get; set; }
            public string ModelName { get; set; }
        


            public override void Add(ModemDatas modem)
            {
                ConnectionControlForAbstract();
                SqlCommand command = new SqlCommand("Insert into Modem(Ip,Mac,BaudRate,ModelName) values(@ip,@mac,@baudrate,@modelname)", _sqlConnection);

                ModemDatasParametersAddWithValueMethod(modem,command);

                command.ExecuteNonQuery();
                //_sqlConnection.Close();

            }

            public List<General.ModemDatas> GetAllModemDatas()
            {

                ConnectionControlForAbstract();

                SqlCommand commandModem = new SqlCommand("Select *from Modem", _sqlConnection);

                SqlDataReader sqlDataReader = commandModem.ExecuteReader();
                List<General.ModemDatas> modemDatas = new List<General.ModemDatas>();

                while (sqlDataReader.Read())
                {
                    General.ModemDatas modem = new General.ModemDatas
                    {
                        Id = Convert.ToInt32(sqlDataReader["Id"]),
                        Ip = sqlDataReader["Ip"].ToString(),
                        Mac = sqlDataReader["Mac"].ToString(),
                        BaudRate = Convert.ToInt32(sqlDataReader["BaudRate"]),
                        ModelName = sqlDataReader["ModelName"].ToString(),
                       
                    };


                    modemDatas.Add(modem);


                }
                sqlDataReader.Close();
                _sqlConnection.Close();
                return modemDatas;



            }



            public override void Delete(ModemDatas modem)
            {
                ConnectionControlForAbstract();
                SqlCommand command = new SqlCommand("Delete from Modem where Id=@id", _sqlConnection);

                command.Parameters.AddWithValue("@id", modem.Id);

                command.ExecuteNonQuery();
               // _sqlConnection.Close();
                


            }


            public override void Update(ModemDatas modem)
            {
                ConnectionControlForAbstract();
                SqlCommand command = new SqlCommand("Update Modem set Ip=@ip,Mac=@mac,BaudRate=@baudrate,ModelName=@modelname where Id=@id ", _sqlConnection);

                ModemDatasParametersAddWithValueMethod(modem, command);
                command.Parameters.AddWithValue("@id", modem.Id);

                command.ExecuteNonQuery();
                //_sqlConnection.Close();

            }

            private static void ModemDatasParametersAddWithValueMethod(ModemDatas modem, SqlCommand command)
            {
                command.Parameters.AddWithValue("@mac", modem.Mac);
                command.Parameters.AddWithValue("@baudrate", modem.BaudRate);
                command.Parameters.AddWithValue("@ip", modem.Ip);
                command.Parameters.AddWithValue("modelname", modem.ModelName);
            }

            public override void ConnectionControlForAbstract()
            {
                if (_sqlConnection.State == ConnectionState.Closed)
                {
                    _sqlConnection.Open();
                }

            }
        }

        public class Datas : BaseAbstract<General.Datas>
        {
            SqlConnection _sqlConnection = new SqlConnection(@"server=ARGYZLM\SQLEXPRESS;initial catalog=ProjectEntes;integrated security=false;uid=sa;password=sa123");

            public DateTime Date { get; set; }
            public int Current { get; set; }
            public int DeviceId { get; set; }
            public int Voltage { get; set; }
           
            

            public override void Add(Datas datas)
            {
                ConnectionControlForAbstract();

                SqlCommand command = new SqlCommand("Insert into Data(Date,Akım,Voltage,DeviceId) values(@date,@current,@voltage,@deviceid)", _sqlConnection);
                DatasParametersAddWithValueMethod(datas, command);
               
                    command.ExecuteNonQuery();
                    //_sqlConnection.Close();
                
               
            }

            public List<General.Datas> GetAllDatas()
            {

                ConnectionControlForAbstract();

                SqlCommand commandData = new SqlCommand("Select *from Data", _sqlConnection);
                

                SqlDataReader sqlDataReader = commandData.ExecuteReader();
                List<General.Datas> datas = new List<General.Datas>();

                while (sqlDataReader.Read())
                {
                    Datas Datas = GetMethodDataReader(sqlDataReader);

                    datas.Add(Datas);

                }
                sqlDataReader.Close();
                _sqlConnection.Close();

                return datas;


            }

           

            public List<General.Datas> Get(int id)
            {
                ConnectionControlForAbstract();

                SqlCommand command = new SqlCommand("Select *from Data where DeviceId=@id ", _sqlConnection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader sqlDataReader = command.ExecuteReader();
                List<General.Datas> dataForGet = new List<General.Datas>();


                while (sqlDataReader.Read())
                {
                    Datas Datas = GetMethodDataReader(sqlDataReader);


                    dataForGet.Add(Datas);


                }


                sqlDataReader.Close();
                _sqlConnection.Close();

                return dataForGet;

            }

            public override void Delete(General.Datas datas)
            {
                ConnectionControlForAbstract();
                SqlCommand command = new SqlCommand("Delete from Data where Id=@id", _sqlConnection);

                command.Parameters.AddWithValue("@id", datas.Id);

                command.ExecuteNonQuery();
               // _sqlConnection.Close();

            }


            public override void Update(General.Datas datas)
            {
                ConnectionControlForAbstract();
                SqlCommand command = new SqlCommand("Update Data set Date=@date,Akım=@current,Voltage=@voltage,DeviceId=@deviceid where Id=@id", _sqlConnection);


                DatasParametersAddWithValueMethod(datas, command);
                command.Parameters.AddWithValue("@id", datas.Id);

                command.ExecuteNonQuery();
               // _sqlConnection.Close();
            }

            private static void DatasParametersAddWithValueMethod(Datas datas, SqlCommand command)
            {
                command.Parameters.AddWithValue("@date", datas.Date);
                command.Parameters.AddWithValue("@current", datas.Current);
                command.Parameters.AddWithValue("@voltage", datas.Voltage);
                command.Parameters.AddWithValue("@deviceid", datas.DeviceId);
               
                
            }
            private static Datas GetMethodDataReader(SqlDataReader sqlDataReader)
            {
                return new General.Datas
                {
                    Id = sqlDataReader["Id"] != DBNull.Value ? Convert.ToInt32(sqlDataReader["Id"]) :Convert.ToInt32("yok"),
                    Date = sqlDataReader["Date"] != DBNull.Value ? Convert.ToDateTime(sqlDataReader["Date"]) : DateTime.Now,
                    Current = sqlDataReader["Akım"] != DBNull.Value ? Convert.ToInt32(sqlDataReader["Akım"]):-1,
                    Voltage = sqlDataReader["Voltage"] != DBNull.Value ? Convert.ToInt32(sqlDataReader["Voltage"]): Convert.ToInt32("yok"),
                    DeviceId = sqlDataReader["DeviceId"] != DBNull.Value ? Convert.ToInt32(sqlDataReader["DeviceId"]):-1
                };
            }

            public override void ConnectionControlForAbstract()
            {
                if (_sqlConnection.State == ConnectionState.Closed)
                {
                    _sqlConnection.Open();
                }
               
            }


            public void NullController(General.Datas argument)
            {
                Datas datas = new Datas();
                List<Datas> datasList = new List<Datas>();
                datasList = datas.GetAllDatas();

                if (string.IsNullOrEmpty(datas.Date.ToString())) {
                    Console.WriteLine(datas.Date.ToString()+ "is null");

                }
                else
                {
                    Console.WriteLine(datas.Date.ToString() + "is not null");
                }



            }
           
        }
     
    }

    

    
}

    


