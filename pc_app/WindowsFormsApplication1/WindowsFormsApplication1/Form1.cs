using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        #region quan ly bien
        long tickStart = 0;
        public enum _enCheDo { Compact = 0, Scroll };
        _enCheDo CheDo = _enCheDo.Compact;

        #endregion

        #region quan ly ham
        private void _KhoiTao()
        {
            cbxTenCom.DataSource = SerialPort.GetPortNames();

            for (int i = 0; i < cbxTenCom.Items.Count; i++)
            {
                if (cbxTenCom.Items[i].ToString() == "COM2")
                {
                    cbxTenCom.Text = "COM2";
                    break;
                }
            }
        }

        public void draw(double setpoint1, double setpoint2)
        {
            //make sure that curvelist has at least one curve
            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return; // Kiểm tra việc khởi tạo các đường curve

            LineItem curve1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            LineItem curve2 = zedGraphControl1.GraphPane.CurveList[1] as LineItem;
            if (curve1 == null)
                return;
            if (curve2 == null)
                return;

            IPointListEdit list1 = curve1.Points as IPointListEdit;
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            if (list1 == null)
                return;
            if (list2 == null)
                return;

            tickStart = tickStart + 1;
            double time = tickStart;
            //time = (Environment.TickCount - tickStart) / 500.0;

            list1.Add(time, setpoint1);// Đây chính là hàm hiển thị dữ liệu của mình lên đồ thị
            list2.Add(time, setpoint2);

            //keep the X scale at a rolling 30 seconed interval, with one major step
            //between the max X value and the end of the axis
            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                if (CheDo == _enCheDo.Compact)
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = xScale.Max - 30.0;
                }
                else
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = 0;
                }
            }

            //make sure the y axis is rescaled to accommodate actual data
            zedGraphControl1.AxisChange();
            // Force a redraw
            zedGraphControl1.Invalidate();
        }
        #endregion

        #region quan ly form
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            _KhoiTao();

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "ĐỒ THỊ NHIỆT ĐỘ TỪ CẢM BIẾN LM35";
            myPane.XAxis.Title.Text = "Thời Gian";
            myPane.YAxis.Title.Text = "Nhiệt Độ";
            RollingPointPairList list1 = new RollingPointPairList(2000);
            RollingPointPairList list2 = new RollingPointPairList(2000);
            LineItem curve1 = myPane.AddCurve("Nhiệt Độ 1", list1, Color.Blue, SymbolType.None);
            LineItem curve2 = myPane.AddCurve("Nhiệt Độ 2", list2, Color.Black, SymbolType.None);
            myPane.XAxis.Scale.Min = 0;  // Min = 0;
            myPane.XAxis.Scale.Max = 30; // Max = 30;
            myPane.XAxis.Scale.MinorStep = 1;  // Đơn vị chia nhỏ nhất 1
            myPane.XAxis.Scale.MajorStep = 5; // Đơn vị chia lớn 5

            //scale the axes
            zedGraphControl1.AxisChange();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Close();
                        break;
                    }
            }
        }
        #endregion

        string Temp = "";
        int[] NhietDo = new int[2] { 0,0};
        private void UART_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Temp = UART.ReadTo("\n");
            var Tach = Temp.Split(',');

            if (Tach.Length > 1)
            {
                NhietDo[0] = Convert.ToInt32(Tach[0]);
                NhietDo[1] = Convert.ToInt32(Tach[1]);
            }


            draw(NhietDo[0], NhietDo[1]);

        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                UART.BaudRate = 9600;
                UART.PortName = cbxTenCom.Text;
                UART.Open();
                if (UART.IsOpen == true)
                {
                    btnKetNoi.Enabled = false;
                    btnNgatKetNoi.Enabled = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);                
            }
        }

        private void btnNgatKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                UART.Close();
                if (UART.IsOpen == false)
                {
                    btnKetNoi.Enabled = true;
                    btnNgatKetNoi.Enabled = false;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void miCompact_Click(object sender, EventArgs e)
        {
            CheDo = _enCheDo.Compact;
        }

        private void miScroll_Click(object sender, EventArgs e)
        {
            CheDo = _enCheDo.Scroll;
        }
    }
}
