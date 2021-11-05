using System;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;


namespace SystemMonitor
{
    public partial class Form1 : Form
    {
        private Computer computer;
        public Form1()
        {
            InitializeComponent();

            // open computer info channel
            computer = new Computer();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            UpdateVisitor updateVisitor = new UpdateVisitor();
            computer.Accept(updateVisitor);
            computer.Open();

            var timer = new Timer();
            timer.Tick += new EventHandler(GetSystemInfo);
            timer.Interval = 100;
            timer.Start();
        }

        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        void GetSystemInfo(object sender, EventArgs e)
        {
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                computer.Hardware[i].Update();
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        var sensor = computer.Hardware[i].Sensors[j];
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("CPU Package"))
                        {
                            cpuTemp.Text = ((int)sensor.Value.GetValueOrDefault()).ToString();
                        } 
                        else if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("CPU Total"))
                        {
                            cpuLoad.Text = ((int)sensor.Value.GetValueOrDefault()).ToString();
                        }
                    }
                } 
                else if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        var sensor = computer.Hardware[i].Sensors[j];
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("GPU Core"))
                        {
                            gpuTemp.Text = ((int)sensor.Value.GetValueOrDefault()).ToString();
                        }
                        else if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("GPU Core"))
                        {
                            gpuLoad.Text = ((int)sensor.Value.GetValueOrDefault()).ToString();
                        }
                    }
                }
            }

            systemTimeDate.Text = DateTime.Now.ToString("f");
        }
    }
}
