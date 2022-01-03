using Modbus.Device;
using Modbus.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NModbusWorkshop
{
    public class ModbusProcces
    {
        public List<ushort> codReader()
        {
            //LİSTEYİ ARRAY YAPPP !!!
            //try catchin içine al !! veya while(true)

            TcpClient client = new TcpClient(ConfigurationManager.AppSettings["ipAddress"], 502);
            ModbusIpMaster master = ModbusIpMaster.CreateIp(client);



            // read 2 input values
            byte slaveAddress = 247;
            ushort startAddress = 160;
            ushort numberofPoints = 2;
            ushort[] holdingInputs = master.ReadHoldingRegisters(slaveAddress, startAddress, numberofPoints);
            return holdingInputs.ToList<ushort>();

            //bool[] inputs = master.ReadInputs(slaveAddress, startAddress, numberofPoints);

            //for (int i = 0; i < holdingInputs.Length; i++)
            //{
            //    Console.WriteLine(holdingInputs[i]);

            //}

            //Console.ReadKey();

        }

        public void codWriter(ushort data)
        {

            try
            {

                TcpClient client = new TcpClient(ConfigurationManager.AppSettings["ipAddress"], 502);

                ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

                ushort _data = data;
                byte slaveAddress = 247;
                ushort startAddress = 160;
                ushort[] datas = { 0, _data };
                master.WriteMultipleRegisters(slaveAddress, startAddress, datas);

            }
            catch (SocketException exp)
            {

                MessageBox.Show("Please reconnect to the device.");

            }


            //bunu Configten yapmamızın sebebi ilerde proje değişirse AppConfigten ipAddressin hepsini tek seferde rahatlıkla değiştirebilelim diye







        }

        //static class ve method ile yeni bir nesne yaratmadan direkt methodu çalıştırabiliyoruz.

        //SerialPort serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        //serialPort.Open();
        //byte slaveAdress = 247;
        //ushort startAdress = 160;
        //ushort numberofPoints = 2;
        //IModbusMaster masterRTU = ModbusSerialMaster.CreateRtu(serialPort);
        //ushort[] ushortArray = masterRTU.ReadHoldingRegisters(slaveAdress,startAdress,numberofPoints);

        //for (int i=0;i<numberofPoints;i++)
        //{
        //    Console.WriteLine("Register {0},{1}", startAdress + i, ushortArray[i]);


        //}

        //masterRTU.WriteMultipleCoils(slaveAdress, startAdress, new bool[] { true, false, true });
    }
}

