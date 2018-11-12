using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Globalization;
using System.Threading;
using System.IO;
using System.Reflection;

namespace ImageScroller
{
    public partial class frm_DownloadCVR : Form
    {
        string[] arry_BtnClick = new string[10];
        int[] _n = new int[10];
        int[] m = new int[10];
        string uihandle;
        int count = frm_SaveChannel.count_VideoDownload;  // Count Click
        string DownloadBtn_Click = frm_SaveChannel.DownloadBtn_Click;  // Which Btn click

        Thread[] T = new Thread[10];
        int ThreadCount;
    
        cls_CompIp cls_CompIp = new cls_CompIp(); // class file declare for using function
        int DownloadPer = 0;

        private frm_SaveChannel _frm_SaveChannel;

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        private bool _isConnected;   
        string All_String;
        string D_String;
        string P_String;       
        string _Ip = "10.0.0.225";
        int _Port = 80;
        string _UserName = "admin";
        string _Password = "Securens$#2018";
        int _LoginType = 0; //Login type. Reserved, set as 0.
        int iMqPort = 61618; //Port No. of MQ server, the default value is 61618.
        string _ClientName = Environment.GetEnvironmentVariable("USERNAME");
        string format = "dd/MM/yyyy HH:mm:ss";

        public static string Download_Path;
        public static string _Percentage;
        public static string _Percentage2;
        public static string ret_btnClick;

        public frm_DownloadCVR(frm_SaveChannel frm_SaveChannel)
        {
            InitializeComponent();
            _frm_SaveChannel = frm_SaveChannel;
        }       
      
        private void frm_DownloadCVR_Load(object sender, EventArgs e)
        {          
            try
            {
                // Check frm_DownloadCVR only open once
                if (Application.OpenForms.OfType<frm_DownloadCVR>().Count() < 1 ||
                    Application.OpenForms.OfType<frm_DownloadCVR>().Count() > 1)
                {
                    Application.OpenForms.OfType<frm_DownloadCVR>().First().Close();
                    //frm_DownloadCVR CVR_Download = new frm_DownloadCVR();
                    //CVR_Download.Show();
                }

                cls_CompIp.Get_ipAddress(out string MyComp_Ip); // Computer Ip address
                clientSocket.Connect(MyComp_Ip, 9001); // connection to socket clientSocket.Connect("192.168.1.52", 9001);

                //AsynchronousClient.StartClient();

                if (clientSocket.Connected)
                {
                    msg("Client Started");
                    //label1.Text = "Client Socket Program - Server Connected ...";
                    _isConnected = true;
                }
                else
                {
                    MessageBox.Show("Client Can't Start the socket Connection");
                }                            
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client Can't Start the socket Connection, Global exception: {0}", ex.Message);
            }            
           
        }      

        public void msg(string mesg)
        {
            //richTextBox1.Text = richTextBox1.Text + Environment.NewLine + " >> " + mesg;
        }

        // string for Download video
        public void S_Download(int ThreadCount)
        {
            try
            {
                string _Code = "DV";
                ThreadCount = count;
                int threadID = (int)AppDomain.GetCurrentThreadId();
                int managedThreadId = Thread.CurrentThread.ManagedThreadId;

                DateTime time = DateTime.Now;
                long _CuurentTime = (time.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
                string _CameraName = txt_CameraName.Text;
                string _DeviceName = txt_DeviceName.Text;

                string _StartTime = dtp_StartTime.Text;
                string _EndTime = dateTimePicker2.Text;
                DateTime enteredDateS = DateTime.ParseExact(_StartTime, format, CultureInfo.InvariantCulture);
                DateTime enteredDateE = DateTime.ParseExact(_EndTime, format, CultureInfo.InvariantCulture);
                long _sTimeStamp = (enteredDateS.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
                long _eTimeStamp = (enteredDateE.ToUniversalTime().Ticks - 621355968000000000) / 10000000;

                if (_sTimeStamp < _eTimeStamp && _CuurentTime > _eTimeStamp)
                {
                    //DV | 10.0.0.225 | 80 | admin | Securens$#2018|0|61618|KITCHEN|1535445000|1535448599|Client_1|BQ002
                    D_String = _Code + "|" + _Ip + "|" + _Port + "|" + _UserName + "|" + _Password + "|" + _LoginType + "|" +
                          iMqPort + "|" + _CameraName + "|" + _sTimeStamp + "|" + _eTimeStamp + "|" + _ClientName + "|" +
                          _DeviceName;

                    NetworkStream serverStream = clientSocket.GetStream();
                    // byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox2.Text + "$");
                    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(D_String);
                    serverStream.Write(outStream, 0, outStream.Length);

                    serverStream.Flush();
                    byte[] inStream = new byte[10025];

                    int bytesRead = serverStream.Read(inStream, 0, inStream.Length);
                    //serverStream.Read(inStream, 0, clientSocket.ReceiveBufferSize);
                    string returndata = Encoding.ASCII.GetString(inStream, 0, bytesRead);
                    returndata = returndata.Trim('\0');

                    switch (returndata)
                    {
                        case "":
                            MessageBox.Show("Can't get video file, Please try again......");
                            this.Invoke((MethodInvoker)delegate  // close the form on the forms thread
                            {
                                this.Close();
                            });
                            break;
                        case "Video Can't Find":
                            MessageBox.Show("Can't get video file, Please try again......");
                            this.Invoke((MethodInvoker)delegate  // close the form on the forms thread
                            {
                                this.Close();
                            });
                            break;
                        case "Video Can't Download":
                            MessageBox.Show("Can't Download video file, Please try again......");
                            this.Invoke((MethodInvoker)delegate  // close the form on the forms thread
                            {
                                this.Close();
                            });
                            break;
                        case "User Can not connected":
                            MessageBox.Show("User Can't login, Please try again......");
                            this.Invoke((MethodInvoker)delegate  // close the form on the forms thread
                            {
                                this.Close();
                            });
                            break;
                        default:
                            Download_Path = returndata;
                            var myList = new List<string>(Download_Path.Split('|'));
                            string str_uiRecHandle = myList[0];
                            string str_DownloadPath = myList[1]; //Download_Path.Substring(8, Download_Path.Length - 8);
                                                                 //msg(str_DownloadPath);

                            arry_BtnClick[ThreadCount] = DownloadBtn_Click;
                            _n[ThreadCount] = threadID;
                            m[ThreadCount] = Int32.Parse(str_uiRecHandle);

                            this.Invoke((MethodInvoker)delegate  // close the form on the forms thread
                            {
                                this.Close();
                                _frm_SaveChannel.get_Path(str_DownloadPath);
                            });

                            S_Percentage(Int32.Parse(str_uiRecHandle));
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Enter the valid Date & Time");
                    this.Invoke((MethodInvoker)delegate  // close the form on the forms thread
                    {
                        this.Cursor = Cursors.Default; // Waiting / hour glass 
                    });
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Connection Errors");
                MessageBox.Show("Client Can't Start the socket Connection, Global exception: {0}", ex.Message);
            }                     
        }            

        // string for percentage of video download
        public void S_Percentage(int str_uiRecHandle)
        {
            try
            {
                string _Code = "CV";
                int threadID = (int)AppDomain.GetCurrentThreadId();
                int managedThreadId = Thread.CurrentThread.ManagedThreadId;

                P_String = _Code + "|" + _Ip + "|" + _Port + "|" + _UserName + "|" + _Password + "|" + _LoginType + "|" +
                          iMqPort + "|" + str_uiRecHandle; // + "|"  + _ClientName;

                NetworkStream serverStream = clientSocket.GetStream();
                // byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox2.Text + "$");
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(P_String);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                byte[] inStream = new byte[10025];

                int bytesRead = serverStream.Read(inStream, 0, inStream.Length);
                // serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                string returndata = Encoding.ASCII.GetString(inStream, 0, bytesRead);
                string str_ReturnData = returndata.Trim('\0');
                var myreturndata = new List<string>(str_ReturnData.Split('|'));
                string str_Ui = myreturndata[0];
                string str_Per = myreturndata[1];

                if (str_Per != "100")
                {
                    _Percentage = str_Per;
                    Int32.TryParse(_Percentage, out DownloadPer);
                    _Percentage2 = _Percentage + "|" + DownloadBtn_Click;
                    _frm_SaveChannel.get_Percentage(_Percentage2);
                    S2_Percentage();
                }
                else
                {
                    _Percentage2 = str_Per + "|" + DownloadBtn_Click;
                    _frm_SaveChannel.get_Percentage(_Percentage2);
                    //Thread.CurrentThread.Abort();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Connection Errors");
                MessageBox.Show("Client Can't Start the socket Connection, Global exception: {0}", ex.Message);
            }
        }

        public void S2_Percentage()
        {
            try
            {
                string _Code = "CV";
                int threadID = (int)AppDomain.GetCurrentThreadId();
                int managedThreadId = Thread.CurrentThread.ManagedThreadId;

                int counts = 0;
                foreach (int i in _n ?? Enumerable.Empty<int>())
                {
                    int _threadId = i;
                    if (threadID == _threadId)
                    {
                        uihandle = m[counts].ToString();
                        ret_btnClick = arry_BtnClick[count];
                        break;
                    }
                    counts++;
                }

                P_String = _Code + "|" + _Ip + "|" + _Port + "|" + _UserName + "|" + _Password + "|" + _LoginType + "|" +
                          iMqPort + "|" + uihandle; // + "|"  + _ClientName;

                NetworkStream serverStream = clientSocket.GetStream();
                // byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox2.Text + "$");
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(P_String);
                serverStream.Write(outStream, 0, outStream.Length);

                serverStream.Flush();
                byte[] inStream = new byte[10025];

                int bytesRead = serverStream.Read(inStream, 0, inStream.Length);
                //serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                string returndata = Encoding.ASCII.GetString(inStream, 0, bytesRead);
                string str_ReturnData = returndata.Trim('\0');
                var myreturndata = new List<string>(str_ReturnData.Split('|'));
                string str_Ui = myreturndata[0];
                string str_Per = myreturndata[1];


                if (str_Per != "100")
                {
                    int j = 0;
                    foreach (int i in m ?? Enumerable.Empty<int>())
                    {
                        int _UiId = i;
                        if (Int32.Parse(str_Ui) == _UiId)
                        {
                            ret_btnClick = arry_BtnClick[count];
                            break;
                        }
                        j++;
                    }
                    _Percentage = "";
                    _Percentage = returndata;
                    Int32.TryParse(_Percentage, out DownloadPer);
                    _Percentage2 = str_Per + "|" + ret_btnClick;

                    _frm_SaveChannel.get_Percentage(_Percentage2);
                    S2_Percentage();
                }
                else
                {
                    int k = 0;
                    foreach (int i in m ?? Enumerable.Empty<int>())
                    {
                        int _UiId = i;
                        if (Int32.Parse(str_Ui) == _UiId)
                        {
                            ret_btnClick = arry_BtnClick[count];
                            break;
                        }
                        k++;
                    }
                    _Percentage2 = str_Per + "|" + ret_btnClick;
                    _frm_SaveChannel.get_Percentage(_Percentage2);
                    //Thread.CurrentThread.Abort();
                }
            }
            catch (Exception ex)
            {
               //MessageBox.Show("Connection Errors");
               MessageBox.Show("Client Can't Start the socket Connection, Global exception: {0}", ex.Message);
            }
           
        }
       
        //btn Download Video
        private void btn_DownoladVideo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor; // Waiting / hour glass 
            T[ThreadCount] = new Thread(() => S_Download(ThreadCount));
            T[ThreadCount].Start();
        }

        // btn close
        private void lab_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lab_Close_MouseEnter(object sender, EventArgs e)
        {
            lab_Close.ForeColor = System.Drawing.ColorTranslator.FromHtml("#f26222");
            lab_Close.BackColor = System.Drawing.Color.WhiteSmoke;
        }
        private void lab_Close_MouseLeave(object sender, EventArgs e)
        {
            lab_Close.ForeColor = System.Drawing.Color.WhiteSmoke;
            lab_Close.BackColor = System.Drawing.ColorTranslator.FromHtml("#f26222");
        }

    }
}
