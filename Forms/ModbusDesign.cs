using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NModbusWorkshop
{
    public partial class ModbusDesign : Form
    {
        ModbusProcces _modbusProcces = new ModbusProcces();

        private void StatusCheck(List<ushort> modbusProccesList)
        {

            if (modbusProccesList[1] == 0)
            {

                lblExp.Text = "Close";
                MessageBox.Show("Device is off");

            }
            else
            {

                lblExp.Text = "Open";
                MessageBox.Show("Device is on");

            }


        }

        private bool codWriterExecuter(ushort value)
        {
            bool situationStatus = true;

            //burdaki bool fonksiyon icerisindeki durumu sorgulayan bir parametre 
           
           try
            {

                ushort data = Convert.ToUInt16(tbxWriter.Text);
               
                if (data == value)
                {
                    _modbusProcces.codWriter(data);
                    lblExp.Text = "Open";


                    return situationStatus;
                }
                else
                {

                    situationStatus = false;
                    return situationStatus;
                }

            }
            catch (System.FormatException exp)
            {
                situationStatus = false;
            }
            return situationStatus;
        }

        public ModbusDesign()
        {
            InitializeComponent();
        }

        private void btnOpenGreen_Click_1(object sender, EventArgs e)
        {
            codWriterExecuter(1);


            if (codWriterExecuter(1) == true ||  string.IsNullOrEmpty(tbxWriter.Text))
            {
                tbxOpenGreen.BackColor = Color.Green;

                if (tbxOpenRed.BackColor == Color.Red)
                {
                    tbxOpenRed.BackColor = Color.White;
                }

            }
            else
            {
                MessageBox.Show("Entered value is wrong for this command.");
            }
        }

        private void btnOpenAll_Click_1(object sender, EventArgs e)
        {
            codWriterExecuter(3);

            if (codWriterExecuter(3) == true || string.IsNullOrEmpty(tbxWriter.Text))
            {
                tbxOpenGreen.BackColor = Color.Green;
                tbxOpenRed.BackColor = Color.Red;


            }
            else
            {
                MessageBox.Show("Entered value is wrong for this command.");
            }
        }

        private void btnOpenRed_Click_1(object sender, EventArgs e)
        {
            codWriterExecuter(2);


            if (codWriterExecuter(2) == true || string.IsNullOrEmpty(tbxWriter.Text))
            {
                tbxOpenRed.BackColor = Color.Red;
                if (tbxOpenGreen.BackColor == Color.Green)
                {
                    tbxOpenGreen.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Entered value is wrong for this command.");
            }
        }

        private void btnCloseAll_Click_1(object sender, EventArgs e)
        {
            codWriterExecuter(0);

            if (codWriterExecuter(0) == true || string.IsNullOrEmpty(tbxWriter.Text))
            {
                tbxOpenGreen.BackColor = Color.White;
                tbxOpenRed.BackColor = Color.White;
                lblExp.Text = "Close";

            }
            else
            {
                MessageBox.Show("Entered value is wrong for this command.");
            }
        }

        private void btnReconnect_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void btnStatusCheck_Click_1(object sender, EventArgs e)
        {

            List<ushort> readingValues = _modbusProcces.codReader();
            StatusCheck(readingValues);

            if (readingValues[1] == 2)
            {
                btnOpenRed_Click_1(sender, e);    //kırmızı 
            }
            else if (readingValues[1] == 1)
            {
                btnOpenGreen_Click_1(sender, e);  //yeşil 
            }
            else if (readingValues[1] == 3)
            {
                btnOpenAll_Click_1(sender, e);    //hepsi
            }
        }

        //bütün butonları tekrardan implemente et 
    }
}