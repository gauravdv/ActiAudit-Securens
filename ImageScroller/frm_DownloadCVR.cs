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
        int Last_Percentage;
        Thread T;
        string str_uiRecHandle;
     
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
        string _ClientName = "Client_1";
        string format = "dd/MM/yyyy HH:mm:ss";

        public static string Download_Path;
        public static string _Percentage;

        public frm_DownloadCVR(frm_SaveChannel frm_SaveChannel)
        {
            InitializeComponent();
            _frm_SaveChannel = frm_SaveChannel;
        }    

        private void frm_DownloadCVR_Load(object sender, EventArgs e)
        {
           // lab_Progress.Hide();
            //lab_Progress.Enabled = false;
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
                MessageBox.Show("Connection Errors");
                this.Close();
                //MessageBox.Show("Client Can't Start the socket Connection, Global exception: {0}", ex.Message);
            }            
           
        }      

        public void msg(string mesg)
        {
            //richTextBox1.Text = richTextBox1.Text + Environment.NewLine + " >> " + mesg;
        }

        // string for Download video
        public void S_Download()
        {
            try
            {
                string _Code = "DV";
                //DV | 10.0.0.225 | 80 | admin | Securens$#2018|0|61618|KITCHEN|1535445000|1535448599|Client_1|BQ002
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
                    //serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                    string returndata = Encoding.ASCII.GetString(inStream, 0, bytesRead);
                    // string returndata = System.Text.Encoding.ASCII.GetString(inStream);
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
                            string lab_msg = "Download Progress please Wait..... " + 0 + " % ";
                            SetControlPropertyThreadSafe(label1, "Text", lab_msg);
                            //lab_Progress.Enabled = true;
                            Download_Path = returndata;

                            var myList = new List<string>(Download_Path.Split('|'));
                            str_uiRecHandle = myList[0];
                            string str_DownloadPath = myList[1]; //Download_Path.Substring(8, Download_Path.Length - 8);
                            msg(str_DownloadPath);
                            _frm_SaveChannel.get_Path(str_DownloadPath);
                            S_Percentage();
                            break;
                    }

                   
                    //else
                    //{
                    //    string lab_msg = "Download Progress please Wait..... " + 0 + " % ";
                    //    SetControlPropertyThreadSafe(label1, "Text", lab_msg);
                    //    //lab_Progress.Enabled = true;
                    //    Download_Path = returndata;

                    //    var myList = new List<string>(Download_Path.Split('|'));
                    //    str_uiRecHandle = myList[0];
                    //    string str_DownloadPath = myList[1]; //Download_Path.Substring(8, Download_Path.Length - 8);
                    //    msg(str_DownloadPath);
                    //    _frm_SaveChannel.get_Path(str_DownloadPath);
                    //    S_Percentage();
                    //}
                }
                else
                {
                    //lab_Progress.Enabled = false;
                    MessageBox.Show("Enter the valid Date & Time");
                    this.Invoke((MethodInvoker)delegate  // close the form on the forms thread
                    {
                        this.Cursor = Cursors.Default; // Waiting / hour glass 
                    });
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Connection Errors");
                this.Invoke((MethodInvoker)delegate  // close the form on the forms thread
                {                    
                    this.Cursor = Cursors.Default; // Waiting / hour glass 
                    this.Close();
                });
               
                //MessageBox.Show("Client Can't Start the socket Connection, Global exception: {0}", ex.Message);
            }
        }            

        // string for percentage of video download
        public void S_Percentage()
        {
            try
            {
                //Thread Per = new Thread(S_Percentage);
                string _Code = "CV";
                P_String = _Code + "|" + _Ip + "|" + _Port + "|" + _UserName + "|" + _Password + "|" + _LoginType + "|" +
                          iMqPort + "|" + str_uiRecHandle; ; // + "|"  + _ClientName;
                
                if (clientSocket.Connected)
                {
                    NetworkStream serverStream = clientSocket.GetStream();
                    // byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox2.Text + "$");
                    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(P_String);
                    serverStream.Write(outStream, 0, outStream.Length);

                    serverStream.Flush();
                    byte[] inStream = new byte[10025];

                    int bytesRead = serverStream.Read(inStream, 0, inStream.Length);
                    //serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                    string returndata = System.Text.Encoding.ASCII.GetString(inStream, 0, bytesRead);
                    string str_ReturnData = returndata.Trim('\0');
                  
                    string lab_msg;
                    //if (Last_Percentage != Int32.Parse(returndata))
                    //{
                        switch (returndata)
                        {
                            case "Erroer in Video Download":
                                lab_msg = "Download Progress please Wait..... " + str_ReturnData + " % ";
                                SetControlPropertyThreadSafe(label1, "Text", lab_msg);
                                break;
                            default:
                                if (str_ReturnData != "100")
                                {
                                    lab_msg = "Download Progress please Wait..... " + str_ReturnData + " % ";
                                    SetControlPropertyThreadSafe(label1, "Text", lab_msg);
                                    _Percentage = returndata;
                                    Int32.TryParse(_Percentage, out DownloadPer);
                                    Last_Percentage = Int32.Parse(returndata) ;
                                    S_Percentage();
                                }
                                else
                                {
                                    lab_msg = "Download Progress please Wait..... " + str_ReturnData + " % ";
                                    SetControlPropertyThreadSafe(label1, "Text", lab_msg);
                                    this.Invoke((MethodInvoker)delegate  // close the form on the forms thread
                                    {
                                        this.Close();
                                    });
                                }
                                break;
                        }

                        //if ("Erroer in Video Download" == str_ReturnData)
                        //{
                        //    string lab_msg = "Download Progress please Wait..... " + str_ReturnData + " % ";
                        //    SetControlPropertyThreadSafe(label1, "Text", lab_msg);
                        //}
                        //else
                        //{
                        //    if (str_ReturnData != "100")
                        //    {
                        //        string lab_msg = "Download Progress please Wait..... " + str_ReturnData + " % ";
                        //        SetControlPropertyThreadSafe(label1, "Text", lab_msg);
                        //        _Percentage = returndata;
                        //        Int32.TryParse(_Percentage, out DownloadPer);
                        //        S_Percentage();
                        //    }
                        //    else
                        //    {
                        //        string lab_msg = "Download Progress please Wait..... " + str_ReturnData + " % ";
                        //        SetControlPropertyThreadSafe(label1, "Text", lab_msg);
                        //        this.Invoke((MethodInvoker)delegate  // close the form on the forms thread
                        //        {
                        //            this.Close();
                        //        });
                        //    }

                        //}

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Error in video download try again.........");
                    //}
                }
                else
                {
                    MessageBox.Show("Client Can't Start the socket Connection");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Errors");
                this.Close();
                //MessageBox.Show("Client Can't Start the socket Connection, Global exception: {0}", ex.Message);
            }
        }
      
        //btn Download Video
        private void btn_DownoladVideo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor; // Waiting / hour glass 
            T = new Thread(S_Download);
            T.Start();
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

        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);
        public static void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                (SetControlPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }

    }
}
