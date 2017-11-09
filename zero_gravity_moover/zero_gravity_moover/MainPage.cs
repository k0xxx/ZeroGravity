using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zero_gravity_moover
{
    public partial class MainPage : Form
    {
        int counter = 1;
        public MainPage()
        {
            InitializeComponent();
        }
        // Открытие порта
        private void openPort_Click(object sender, EventArgs e)
        {
            serialPort.PortName = "COM" + portName.Text;
            serialPort.BaudRate = 115200;
            serialPort.DtrEnable = true;
            serialPort.Open();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            
            openPort.Enabled = false;
            closePort.Enabled = true;
            portStatus.Text = "Port is open!";
        }
        /*
        private void MainPage_Load(object sender, EventArgs e)
        {
            mot1speed.Text = "200";
            mot2speed.Text = "200";
            mot3speed.Text = "200";
            mot4speed.Text = "200";
            mot5speed.Text = "200";
            mot6speed.Text = "200";

            mot1dist.Text = "200";
            mot2dist.Text = "200";
            mot3dist.Text = "200";
            mot4dist.Text = "200";
            mot5dist.Text = "200";
            mot6dist.Text = "200";
        }*/

        private void startMove_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == true && dataGridView1.RowCount > 1)
            {
                counter = 1;
                var m1s = dataGridView1.Rows[0].Cells[0].Value.ToString();
                var m1d = dataGridView1.Rows[0].Cells[1].Value.ToString();
                var m2s = dataGridView1.Rows[0].Cells[2].Value.ToString();
                var m2d = dataGridView1.Rows[0].Cells[3].Value.ToString();
                var m3s = dataGridView1.Rows[0].Cells[4].Value.ToString();
                var m3d = dataGridView1.Rows[0].Cells[5].Value.ToString();
                var m4s = dataGridView1.Rows[0].Cells[6].Value.ToString();
                var m4d = dataGridView1.Rows[0].Cells[7].Value.ToString();
                var m5s = dataGridView1.Rows[0].Cells[8].Value.ToString();
                var m5d = dataGridView1.Rows[0].Cells[9].Value.ToString();
                var m6s = dataGridView1.Rows[0].Cells[10].Value.ToString();
                var m6d = dataGridView1.Rows[0].Cells[11].Value.ToString();
                string str = m1s + " " + m1d + " " + m2s + " " + m2d + " " + m3s + " " + m3d + " " + m4s + " " + m4d + " " + m5s + " " + m5d + " " + m6s + " " + m6d;

                startMove.Enabled = false;
                Stop.Enabled = true;
                serialPort.Write(str);
            }
            else
            {
                portStatus.Text = "Открой порт!";
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            this.Invoke(new EventHandler(getNextValue));
            
        }

        public void getNextValue(object s, EventArgs e)
        {
            int index = dataGridView1.RowCount - 1;
            if(index > counter)
            {
                var m1s = dataGridView1.Rows[counter].Cells[0].Value.ToString();
                var m1d = dataGridView1.Rows[counter].Cells[1].Value.ToString();
                var m2s = dataGridView1.Rows[counter].Cells[2].Value.ToString();
                var m2d = dataGridView1.Rows[counter].Cells[3].Value.ToString();
                var m3s = dataGridView1.Rows[counter].Cells[4].Value.ToString();
                var m3d = dataGridView1.Rows[counter].Cells[5].Value.ToString();
                var m4s = dataGridView1.Rows[counter].Cells[6].Value.ToString();
                var m4d = dataGridView1.Rows[counter].Cells[7].Value.ToString();
                var m5s = dataGridView1.Rows[counter].Cells[8].Value.ToString();
                var m5d = dataGridView1.Rows[counter].Cells[9].Value.ToString();
                var m6s = dataGridView1.Rows[counter].Cells[10].Value.ToString();
                var m6d = dataGridView1.Rows[counter].Cells[11].Value.ToString();

                string str = m1s + " " + m1d + " " + m2s + " " + m2d + " " + m3s + " " + m3d + " " + m4s + " " + m4d + " " + m5s + " " + m5d + " " + m6s + " " + m6d;
                if (serialPort.IsOpen == true)
                {
                    serialPort.Write(str);
                }
                //инкремент значения строки
                counter++;
                portStatus.Text = counter.ToString();
            }
            else
            {
                counter = 1;
                startMove.Enabled = true;
                portStatus.Text = "Действие закончено";
            }
            
        }

        private void addValues_Click(object sender, EventArgs e)
        {
            mot1speed.Text = "200";
            mot2speed.Text = "200";
            mot3speed.Text = "200";
            mot4speed.Text = "200";
            mot5speed.Text = "200";
            mot6speed.Text = "200";

            mot1dist.Text = "200";
            mot2dist.Text = "200";
            mot3dist.Text = "200";
            mot4dist.Text = "200";
            mot5dist.Text = "200";
            mot6dist.Text = "200";
        }

        private void addString_Click(object sender, EventArgs e)
        {
            var m1s = mot1speed.Text;
            var m1d = mot1dist.Text;
            var m2s = mot2speed.Text;
            var m2d = mot2dist.Text;
            var m3s = mot3speed.Text;
            var m3d = mot3dist.Text;
            var m4s = mot4speed.Text;
            var m4d = mot4dist.Text;
            var m5s = mot5speed.Text;
            var m5d = mot5dist.Text;
            var m6s = mot6speed.Text;
            var m6d = mot6dist.Text;
            if (m1s != "" && m1d != "" && m2s != "" && m2d != "" && m3s != "" && m3d != "" && m4s != "" && m4d != "" && m5s != "" && m5d != "" && m6s != "" && m6d != "")
            {
                dataGridView1.Rows.Add(m1s, m1d, m2s, m2d, m3s, m3d, m4s, m4d, m5s, m5d, m6s, m6d);
            }
            else
            {
                portStatus.Text = "Значение пропущено!";
            }
           
        }

        private void Speed_back_bar_ValueChanged(object sender, EventArgs e)
        {
            mot1speed.Text = Speed_back_bar.Value.ToString();
            mot2speed.Text = Speed_back_bar.Value.ToString();
        }

        private void Speed_up_bar_ValueChanged(object sender, EventArgs e)
        {
            mot3speed.Text = Speed_up_bar.Value.ToString();
            mot4speed.Text = Speed_up_bar.Value.ToString();
        }

        private void Speed_front_bar_ValueChanged(object sender, EventArgs e)
        {
            mot5speed.Text = Speed_front_bar.Value.ToString();
            mot6speed.Text = Speed_front_bar.Value.ToString();
        }

        private void Position_back_bar_ValueChanged(object sender, EventArgs e)
        {
            mot1dist.Text = Position_back_bar.Value.ToString();
            mot2dist.Text = Position_back_bar.Value.ToString();
        }

        private void Position_up_bar_ValueChanged(object sender, EventArgs e)
        {
            mot3dist.Text = Position_up_bar.Value.ToString();
            mot4dist.Text = Position_up_bar.Value.ToString();
        }

        private void Position_front_bar_ValueChanged(object sender, EventArgs e)
        {
            mot5dist.Text = Position_front_bar.Value.ToString();
            mot6dist.Text = Position_front_bar.Value.ToString();
        }

        private void Till_back_bar_ValueChanged(object sender, EventArgs e)
        {
            mot1_2tilt.Text = Till_back_bar.Value.ToString();
        }

        private void Tilt_up_bar_ValueChanged(object sender, EventArgs e)
        {
            mot3_4tilt.Text = Tilt_up_bar.Value.ToString();
        }

        private void Tilt_front_bar_ValueChanged(object sender, EventArgs e)
        {
            mot5_6tilt.Text = Tilt_front_bar.Value.ToString();
        }

        private void Acc_back_bar_ValueChanged(object sender, EventArgs e)
        {
            mot1_2acc.Text = Acc_back_bar.Value.ToString();
        }

        private void Acc_up_bar_ValueChanged(object sender, EventArgs e)
        {
            mot3_4acc.Text = Acc_up_bar.Value.ToString();
        }

        private void Acc_front_bar_ValueChanged(object sender, EventArgs e)
        {
            mot5_6acc.Text = Acc_front_bar.Value.ToString();
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string file = "d:\\mygrid.bin";
            using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; ++i)
                {
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            dataGridView1.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                }
            }
        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            string file = "d:\\mygrid.bin";
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(dataGridView1.Columns.Count);
                bw.Write(dataGridView1.Rows.Count);
                foreach (DataGridViewRow dgvR in dataGridView1.Rows)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }
        }

        private void closePort_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            openPort.Enabled = true;
            closePort.Enabled = false;
            portStatus.Text = "Port is close!";
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            var stopstring = "0 0 0 0 0 0 0 0 0 0 0 0";
            serialPort.Write(stopstring);
        }
    }
}
