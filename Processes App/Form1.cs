using System.Diagnostics;
namespace Processes_App
    //Done
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Process killProcess = new Process();

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        public void UpdateProcessList()
        {
            Process[] processes = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process process in processes)
            {
                listBox1.Items.Add(process.ProcessName);                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int orderNumber = 0;
                int counter = 0;
                foreach (object obj in listBox1.Items)
                {
                    if((string)obj == listBox1.Items[listBox1.SelectedIndex].ToString())
                    {
                        if(counter == listBox1.SelectedIndex)
                        {
                            break;
                        }
                        orderNumber++;
                    }
                    counter++;
                }
                Process[] processesByName = Process.GetProcessesByName(listBox1.Items[listBox1.SelectedIndex].ToString());
                if (processesByName.Length > 0)
                {
                    killProcess = processesByName[0];
                    label_id.Text = processesByName[0].Id.ToString();
                    label_start.Text = processesByName[0].StartTime.ToString("H:m:s:fff");
                    label_time.Text = processesByName[0].TotalProcessorTime.ToString();
                    label_count.Text = processesByName[0].Threads.Count.ToString();
                    label_copy.Text = processesByName.Count().ToString();
                }
                //foreach(Process process in processesByName)
                //{
                //    MessageBox.Show(process.GetHashCode().ToString());
                //}
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Int32.Parse(textBox1.Text) * 1000;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            killProcess.Kill();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(textBox_start.Text);
            process.Start();
        }

        private void textBox_start_TextChanged(object sender, EventArgs e)
        {
            if (textBox_start.Text.Length > 0)
            {
                button_start.Enabled = true;
            }
            else
            {
                button_start.Enabled = false;
            }
        }
    }
}