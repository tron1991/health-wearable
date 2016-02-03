using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ElderlyCareSystemV2
{
    public partial class ElderlyCareSystem : Form
    {
        public ElderlyCareSystem()
        {
            InitializeComponent();
        }

        /************************************************************************/

        int i;
        TcpClient client;
        NetworkStream stream;
        string clientRcv = "";
        byte[] datalength = new byte[4];

        private void checkBox_server_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_server.Checked == true)
            {
                labelIP.Enabled = true;
                comboBoxIP.Enabled = true;
                Button_Connect_Server.Enabled = true;
                Button_Disconnect_Server.Enabled = true;
            }
        }

        private void Button_Connect_Server_Click(object sender, EventArgs e)
        {
            Button_Connect_Server.Enabled = false;
            checkBox_cw.Enabled = true;
            checkBox_rfid.Enabled = true;
            checkBox_en.Enabled = true;
            try
            {
                client = new TcpClient(comboBoxIP.Text, 1980);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Disconnect_Server_Click(object sender, EventArgs e)
        {
            Alert(true, "Fall Detection", DateTime.Now.ToString("HH:mm:ss tt"));
        }

        public void ClientSend(string msg)
        {
            stream = client.GetStream();
            byte[] data;
            data = Encoding.Default.GetBytes(msg);
            int length = data.Length;
            byte[] datalength = new byte[4];
            datalength = BitConverter.GetBytes(length);
            stream.Write(datalength, 0, 4);
            stream.Write(data, 0, data.Length);
        }

        public void ClientRecieve()
        {
            stream = client.GetStream();
            new Thread(() =>
            {
                byte[] data = new byte[BitConverter.ToInt32(datalength, 0)];
                stream.Read(data, 0, data.Length);
                this.Invoke((MethodInvoker)delegate
                {
                    clientRcv = Encoding.Default.GetString(data);

                });
            }).Start();
        }

        /************************************************************************/

        private static int main_counter = 0;
        private static string input_cw = "";
        private static List<int> accelero = new List<int>();
        private static List<int> emergency_button = new List<int>();
        private static List<int> heart_rate = new List<int>();
        private static int avg_heart_rate = 70;
        private static int med = 0;

        private void checkBox_cw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cw.Checked == true)
            {
                labelPortNameCw.Enabled = true;
                comboBoxPortNameCw.Enabled = true;
                labelGenderCw.Enabled = true;
                comboBoxGenderCw.Enabled = true;
                labelMedicationCw.Enabled = true;
                comboBoxMedicationCw.Enabled = true;

                Button_Connect_CW.Enabled = true;
            }

            if (checkBox_cw.Checked == false && Button_Disconnect_CW.Enabled == false)
            {
                labelPortNameCw.Enabled = false;
                comboBoxPortNameCw.Enabled = false;
                labelGenderCw.Enabled = false;
                comboBoxGenderCw.Enabled = false;
                labelMedicationCw.Enabled = false;
                comboBoxMedicationCw.Enabled = false;

                Button_Connect_CW.Enabled = false;

                comboBoxPortNameCw.Text = "";
                comboBoxGenderCw.Text = "";
                comboBoxMedicationCw.Text = "";
            }
        }

        private void Button_Connect_CW_Click(object sender, EventArgs e)
        {
            if (!serialPort_cw.IsOpen)
            {
                serialPort_cw.PortName = comboBoxPortNameCw.Text;
                serialPort_cw.Open();

                if (comboBoxMedicationCw.Text == "Betablocker") med = -5;
                else if (comboBoxMedicationCw.Text == "Thyroid") med = 5;
                else med = 0;

                if (comboBoxGenderCw.Text == "Man") avg_heart_rate = 70;
                else if (comboBoxGenderCw.Text == "Woman") avg_heart_rate = 73;
                else avg_heart_rate = 70; 

                Button_Connect_CW.Enabled = false;
                Button_Disconnect_CW.Enabled = true;
                checkBox_cw.Enabled = false;
                comboBoxPortNameCw.Enabled = false;
                comboBoxGenderCw.Enabled = false;
                comboBoxMedicationCw.Enabled = false;
                current_cw.Visible = true;
                avg_cw.Visible = true;
                high_cw.Visible = true;
                low_cw.Visible = true;

                Chart();
            }
        }

        private void Button_Disconnect_CW_Click(object sender, EventArgs e)
        {
            serialPort_cw.Close();

            Button_Disconnect_CW.Enabled = false;
            checkBox_cw.Enabled = true;
            checkBox_cw.Checked = false;
            labelPortNameCw.Enabled = false;
            comboBoxPortNameCw.Enabled = false;
            labelGenderCw.Enabled = false;
            comboBoxGenderCw.Enabled = false;
            labelMedicationCw.Enabled = false;
            comboBoxMedicationCw.Enabled = false;
            current_cw.Visible = false;
            avg_cw.Visible = false;
            high_cw.Visible = false;
            low_cw.Visible = false;

            comboBoxPortNameCw.Text = "";
            comboBoxGenderCw.Text = "";
            comboBoxMedicationCw.Text = "";
            chart_cw.ChartAreas.Clear();
            chart_cw.Series.Clear();
        }

        private void serialPort_cw_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                input_cw += serialPort_cw.ReadExisting();
                this.Invoke(new EventHandler(InputCW));

            }
            catch (System.TimeoutException ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void InputCW(object sender, EventArgs e)
        {
            string acc_temp, b_temp, h_temp;
            acc_temp = ""; b_temp = ""; h_temp = "";

            if (input_cw.Length > 6)
            {
                acc_temp = input_cw.Substring(1, ((input_cw.IndexOf('H') - 1)));
                input_cw = input_cw.Substring(2);

                h_temp = input_cw.Substring(1, ((input_cw.IndexOf('B') - 1)));
                input_cw = input_cw.Substring(input_cw.IndexOf('B'));

                b_temp = input_cw.Substring(1, 1);
                input_cw = input_cw.Substring(2);

                StoreCW(Convert.ToInt32(acc_temp), Convert.ToInt32(h_temp) + med, Convert.ToInt32(b_temp));
            }
        }

        private void StoreCW(int acc, int h, int b)
        {
            accelero.Add(acc);
            heart_rate.Add(h);
            emergency_button.Add(b);
            DisplayCW();
            avg_heart_rate = GetAvg();
            main_counter++;
        }

        private void DisplayCW()
        {
            current_cw.Text = heart_rate[main_counter].ToString();
            avg_cw.Text = avg_heart_rate.ToString();
            high_cw.Text = heart_rate.Max().ToString();
            low_cw.Text = heart_rate.Min().ToString();


            chart_cw.Series["Current"].Points.AddXY(main_counter, heart_rate[main_counter]);
            chart_cw.Series["Normal"].Points.AddXY(main_counter, avg_heart_rate);
            chart_cw.Series["Avg"].Points.AddXY(main_counter, avg_heart_rate);
        }

        private void Chart()
        {
            chart_cw.ChartAreas.Add("Pulse");
            chart_cw.Series.Add("Normal");
            chart_cw.Series.Add("Current");
            chart_cw.Series.Add("Avg");
            chart_cw.BackColor = Color.Black;

            chart_cw.ChartAreas["Pulse"].BackColor = Color.Black;
            chart_cw.ChartAreas["Pulse"].AxisX.Minimum = 0;
            chart_cw.ChartAreas["Pulse"].AxisY.Minimum = 40;
            chart_cw.ChartAreas["Pulse"].AxisX.Interval = 1;
            chart_cw.ChartAreas["Pulse"].AxisY.Interval = 1;

            chart_cw.ChartAreas["Pulse"].BorderWidth = 100;
            chart_cw.ChartAreas["Pulse"].Position.X = 0;
            chart_cw.ChartAreas["Pulse"].Position.Y = 0;
            chart_cw.ChartAreas["Pulse"].Position.Height = 100;
            chart_cw.ChartAreas["Pulse"].Position.Width = 100;
            chart_cw.ChartAreas["Pulse"].AxisX.IntervalAutoMode.Equals(40);
            chart_cw.ChartAreas["Pulse"].AxisY.IntervalAutoMode.Equals(30);

            chart_cw.Series["Current"].Color = Color.Red;
            chart_cw.Series["Current"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_cw.Series["Current"].BorderWidth = 3;
            chart_cw.Series["Normal"].Color = Color.Green;
            chart_cw.Series["Normal"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_cw.Series["Avg"].Color = Color.DarkOrange;
            chart_cw.Series["Avg"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private int GetAvg()
        {
            int sum = 0;
            for (int i = 0; i < (main_counter + 1); i++)
            {
                sum = sum + heart_rate[i];
            }
            avg_heart_rate = sum / (main_counter + 1);
            return avg_heart_rate;
        }

        /************************************************************************/

        private static int rfid_counter = 0;
        private static string input_rfid = "";
        public delegate void rfidCheck();
        private static List<string> rfid = new List<string>();

        private void checkBox_rfid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_rfid.Checked == true)
            {
                labelPortNameRfid.Enabled = true;
                comboBoxPortNameRfid.Enabled = true;

                Button_Connect_RFID.Enabled = true;
            }
            if (checkBox_rfid.Checked == false)
            {
                labelPortNameRfid.Enabled = false;
                comboBoxPortNameRfid.Enabled = false;

                Button_Connect_RFID.Enabled = false;

                comboBoxPortNameRfid.Text = "";
            }
        }

        private void Button_Connect_RFID_Click(object sender, EventArgs e)
        {
            if (!serialPort_rfid.IsOpen)
            {
                serialPort_rfid.PortName = comboBoxPortNameRfid.Text;
                serialPort_rfid.Open();
                serialPort_rfid.DataReceived += new SerialDataReceivedEventHandler(serialPort_rfid_DataReceived);
                Button_Connect_RFID.Enabled = false;
                Button_Disconnect_RFID.Enabled = true;
                checkBox_rfid.Enabled = false;
                comboBoxPortNameRfid.Enabled = false;
            }
        }

        private void Button_Disconnect_RFID_Click(object sender, EventArgs e)
        {
            serialPort_rfid.Close();

            Button_Disconnect_RFID.Enabled = false;
            checkBox_rfid.Enabled = true;
            checkBox_rfid.Checked = false;
            labelPortNameRfid.Enabled = false;
            comboBoxPortNameRfid.Enabled = false;

            comboBoxPortNameRfid.Text = "";
        }

        private void serialPort_rfid_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rfidCheck updateDisplayRfid = new rfidCheck(StoreRFID);
            this.Invoke(updateDisplayRfid);
        }

        public void StoreRFID()
        {
            string current = "";
            string previous = "";
            string status = "Inside";
            string t = "";

            input_rfid = input_rfid + serialPort_rfid.ReadExisting();

            if (input_rfid.Length == 12)
            {
                current = GetPlace(input_rfid);
                t = DateTime.Now.ToString("HH:mm:ss tt");

                if (rfid_counter > 0)
                {
                    previous = rfid[rfid_counter - 1];
                }
                else
                {
                    previous = "n/a";
                }

                if (current != previous)
                {
                    rfid.Add(current);
                    DisplayRFID(current, previous, t, status);
                    System.Media.SystemSounds.Beep.Play();
                    rfid_counter++;
                }

                serialPort_rfid.DtrEnable = false;
                DateTimeOffset timeOut = DateTime.Now.AddMilliseconds(1500);

                while (DateTime.Now < timeOut)
                {
                    Application.DoEvents();
                }

                input_rfid = serialPort_rfid.ReadExisting();
                serialPort_rfid.DiscardInBuffer();
                input_rfid = "";
                serialPort_rfid.DtrEnable = true;
            }
        }

        private void DisplayRFID(string current, string previous, string t, string status)
        {
            current_rfid.Text = current;
            previous_rfid.Text = previous;
            status_rfid.Text = status;
            time_rfid.Text = t;

            if (current == "Bedroom")
            {
                bedroom.BackColor = Color.GreenYellow;
                lounge.BackColor = Color.White;
                bathroom.BackColor = Color.White;
                front_door.BackColor = Color.White;
                back_door.BackColor = Color.White;
                kitchen.BackColor = Color.White;
            }
            else if (current == "Kitchen")
            {
                bedroom.BackColor = Color.White;
                lounge.BackColor = Color.White;
                bathroom.BackColor = Color.White;
                front_door.BackColor = Color.White;
                back_door.BackColor = Color.White;
                kitchen.BackColor = Color.GreenYellow;
            }
            else if (current == "Bathroom")
            {
                bedroom.BackColor = Color.White;
                lounge.BackColor = Color.White;
                bathroom.BackColor = Color.GreenYellow;
                front_door.BackColor = Color.White;
                back_door.BackColor = Color.White;
                kitchen.BackColor = Color.White;
            }
            else if (current == "Lounge")
            {
                bedroom.BackColor = Color.White;
                lounge.BackColor = Color.GreenYellow;
                bathroom.BackColor = Color.White;
                front_door.BackColor = Color.White;
                back_door.BackColor = Color.White;
                kitchen.BackColor = Color.White;
            }
        }

        public string GetPlace(string place)
        {
            place = place.Trim();
            if (place == "8400356857") place = "Lounge";
            else if (place == "8400355EB5") place = "Bedroom";
            else if (place == "8400342147") place = "Bathroom";
            else if (place == "840034439D") place = "Kitchen";

            return place;
        }

        private void checkBox_en_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_en.Checked == true)
            {
                labelPortNameEn.Enabled = true;
                comboBoxPortNameEn.Enabled = true;

                Button_Connect_EN.Enabled = true;
            }

            if (checkBox_en.Checked == false)
            {
                labelPortNameEn.Enabled = false;
                comboBoxPortNameEn.Enabled = false;

                Button_Connect_EN.Enabled = false;

                comboBoxPortNameEn.Text = "";
            }
        }

        /************************************************************************/

        private void Button_Connect_EN_Click(object sender, EventArgs e)
        {
            if (!serialPort_en.IsOpen)
            {
                serialPort_en.PortName = comboBoxPortNameEn.Text;
                serialPort_en.Open();
                Button_Connect_EN.Enabled = false;
                Button_Disconnect_EN.Enabled = true;
                checkBox_en.Enabled = false;
                comboBoxPortNameEn.Enabled = false;
            }
        }

        private void Button_Disconnect_EN_Click(object sender, EventArgs e)
        {
            serialPort_en.Close();
            Button_Disconnect_EN.Enabled = false;
            checkBox_en.Enabled = true;
            checkBox_en.Checked = false;
            labelPortNameEn.Enabled = false;
            comboBoxPortNameEn.Enabled = false;

            comboBoxPortNameEn.Text = "";
        }

        /************************************************************************/

        private int time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;

        public void SendEmerg()
        {
            string msg = emergType.Text;
            ClientSend(msg);
            MessageBox.Show("Report sent");
            Alert(false, "No Emergency", DateTime.Now.ToString("HH:mm:ss tt"));
        }

        public void Alert(bool state, string type, string t)
        {
            if (state == true)
            {
                groupBox_emerg.Visible = true;
                groupBox_cw.Visible = false;
                groupBox_en.Visible = false;
                groupBox_monitoring.Visible = false;
                groupBox_rfid.Visible = false;

                time = 31;
                emergType.Text = type;
                emergTime.Text = t;
               
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000;
                timer1.Start();

                timer2 = new System.Windows.Forms.Timer();
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Interval = 500;
                alert.BackColor = Color.Red;
                timer2.Start();
            }

            else if (state == false)
            {
                groupBox_emerg.Visible = false;
                groupBox_cw.Visible = true;
                groupBox_en.Visible = true;
                groupBox_monitoring.Visible = true;
                groupBox_rfid.Visible = true;

                alert.BackColor = Color.Transparent;
                timer1.Stop();
                timer2.Stop();
            }
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time < 1)
            {
                SendEmerg();
            }
            else
            {
                countdown.Text = time.ToString();
                countdown.Visible = true;
            }
        }

        void timer2_Tick(object sender, EventArgs e)
        {
            if (alert.BackColor == Color.Red)
            {
                alert.BackColor = Color.Transparent;
            }
            else if (alert.BackColor == Color.Transparent)
            {
                alert.BackColor = Color.Red;
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Alert(false, "No Emergency", DateTime.Now.ToString("HH:mm:ss tt"));
        }

        private void Button_Emerg_Click(object sender, EventArgs e)
        {
            SendEmerg();
        }

        private void enApp1_Click(object sender, EventArgs e)
        {
            serialPort_en.Write("0");
        }

        private void enApp2_Click(object sender, EventArgs e)
        {
            serialPort_en.Write("2");
        }

        /************************************************************************/

    }
}