using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace BaneMark2
{
   


    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadRooms()
        {
            //read from file.

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void createAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Shutdown(string computerName, decimal time, string message)
        {
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.FileName = "shutdown.exe";
            info.CreateNoWindow = true;
            info.Arguments = "-s -m \\" + computerName + " -t " + time + " -c " + message;
            myProcess.StartInfo = info;
            myProcess.Start();
        }
        private void Abort(string computerName)
        {
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.FileName = "shutdown.exe";
            info.CreateNoWindow = true;
            info.Arguments = "-a -m \\" + computerName;
            myProcess.StartInfo = info;
            myProcess.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //shutdown specific computer
            Shutdown(computerToShutDown.Text, numericUpDown1.Value,"Shutdown will occur shortly. Save and log off");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //abort specific computer
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //shutdown the whole room
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //abort the whole room.
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void changeShutdownMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string hour = DateTime.Now.Hour.ToString();
            if (hour.Length == 1)
            {
                hour = "0" + hour;
            }
            string mins = DateTime.Now.Minute.ToString();
            if (mins.Length == 1)
            {
                mins = "0" + mins;
            }
            timeLBL.Text = hour + ":" + mins;
        }
    }
    public class Node
    {
        public string ComputerName;
        public Point Position; //for gui display.
        public Node(string ComputerName)
        {
            this.ComputerName = ComputerName;
        }

    }
    public class Room
    {
        public string RoomName;
        public List<Node> ComputerList;

        public Room(string RoomName)
        {
            ComputerList = new List<Node>();
            this.RoomName = RoomName;
        }
        public void AddComputer(string ComputerName)
        {
            Node newComputer = new Node(ComputerName);
            ComputerList.Add(newComputer);
        }

    }

}
