using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageScroller
{  

    class cls_dbConnection
    {
        cls_CompIp cls_CompIp = new cls_CompIp(); // class file declare for using function

        string db_Server;
        string db_Name;
        string db_UserID;
        string db_Password;
        private MySqlConnection connect;
      
       
        // DataBase Connection
        public void db_connection()
        {
            try
            {
                Get_DataBaseDetail();
                MySqlConnectionStringBuilder myCSB = new MySqlConnectionStringBuilder();
                myCSB.Server = db_Server;
                myCSB.Database = db_Name;
                myCSB.UserID = db_UserID;
                myCSB.Password = db_Password;
                connect = new MySqlConnection(myCSB.ConnectionString);
                connect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open mysql connection !" + ex.Message);
            }
        }

        // Get TextFile For Data Base
        private void Get_DataBaseDetail()
        {
            string txtFileName = "DataBaseConnection.txt";
            string ExeLoaction = System.Reflection.Assembly.GetEntryAssembly().Location; ;
            string txtFilePath = Path.GetDirectoryName(ExeLoaction); // Folder path
            string txtpath = txtFilePath + "\\" + txtFileName;
            try
            {
                if (File.Exists(txtpath))
                {
                    using (StreamReader sr = new StreamReader(txtpath))
                    {
                        while (sr.Peek() >= 0)
                        {
                            string ss = sr.ReadLine();
                            string[] txtsplit = ss.Split(';');

                            //now loop through   array
                            db_Server = txtsplit[0];
                            db_Name = txtsplit[1];
                            db_UserID = txtsplit[2];// user id
                            db_Password = txtsplit[3]; // password
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
        }


        #region Select
        // Select ---------------------------------------------------------------------------------------------------------------------
        // Gat Project name list view fill --- frm_SaveChannel
        public List<string> Get_lvProjectName(ref List<string> list_ProjectName)
        {
            cls_CompIp.Get_ipAddress(out string myIP); // Computer Ip adddress

            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT Project_name FROM project_detail WHERE computer_IP = '" + myIP + "' ORDER BY Project_name ASC";
            cmd.Connection = connect;
            MySqlDataReader ChannelReder = cmd.ExecuteReader();
            while (ChannelReder.Read())
            {
                list_ProjectName.Add(ChannelReder["Project_name"].ToString());               
            }
            ChannelReder.Close();
            connect.Close();
            return list_ProjectName;
        }

        // Gat Tag Type cmobo box fill 
        public List<string> Get_CmbTagType(ref List<string> list_TagType)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT TagType_name FROM tag_type ORDER BY TagType_name ASC";
            cmd.Connection = connect;
            MySqlDataReader ChannelReder = cmd.ExecuteReader();
            while (ChannelReder.Read())
            {
                list_TagType.Add(ChannelReder["TagType_name"].ToString());
            }
            ChannelReder.Close();
            connect.Close();
            return list_TagType;
        }

        // Get ScrollIndex from Db ------ImageScrollerForm
        public int Get_ScrollIndex(ref int scrollIndex, string cp_ID)
        {
            try
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT Scroll_Index FROM project_detail Where Project_ID = '" + cp_ID + "'";
                cmd.Connection = connect;
                MySqlDataReader cChannelReder = cmd.ExecuteReader();

                while (cChannelReder.Read())
                {
                    string SIndex;
                    SIndex = cChannelReder.GetString("Scroll_Index");
                    scrollIndex = Int32.Parse(SIndex);
                }
                cChannelReder.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
            return scrollIndex;
        }

        // Get Tag Reason cmobo box fill ---- frm_Popoup
        public List<string> Get_CmbTagReason(ref List<string> list_TagReason)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT TagReason_name FROM tag_reason ORDER BY TagReason_name ASC";
            cmd.Connection = connect;
            MySqlDataReader ChannelReder = cmd.ExecuteReader();
            while (ChannelReder.Read())
            {
                list_TagReason.Add(ChannelReder["TagReason_name"].ToString());
                //cmb_TagReason.Items.Add(ChannelReder["TagReason_name"].ToString());
            }
            ChannelReder.Close();
            connect.Close();         
            return list_TagReason;
        }
        #endregion


        #region Insert
        // Insert-----------------------------------------------------------------------------------------------------------------------
        // Insert Project name 
        public void Insert_ProjectName(string cp_Name, string myIP, string ProjectType, int Scroll_Index)
        {
            try
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO project_detail(Project_name,computer_IP,Project_Type, Scroll_Index) " +
                    "values('" + cp_Name + "','" + myIP + "','" + ProjectType + "', '" + Scroll_Index + "')";
                cmd.Connection = connect;
                MySqlDataReader ChannelReder = cmd.ExecuteReader();
                connect.Close();
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Insert Tag Reson in db ---- frm_Popoup
        public void Insert_TagReson(string TagReason_Others)
        {
            try
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO tag_reason(TagReason_name) values(@TagReason_name)";
                cmd.Parameters.AddWithValue("@TagReason_name", TagReason_Others);
                cmd.Connection = connect;
                MySqlDataReader Channel = cmd.ExecuteReader();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region Update  
        // Update----------------------------------------------------------------------------------------------------------------------
        // Update ScrollIndex from Db ------ImageScrollerForm
        public void Update_ScrollIndex(int scrollIndex, string cp_ID)
        {
            try
            {
                int _scrollIndex = scrollIndex;
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "UPDATE project_detail SET Scroll_Index='" + scrollIndex + "' WHERE 	Project_ID = '" + cp_ID + "'";

                cmd.Connection = connect;
                MySqlDataReader RRChannel = cmd.ExecuteReader();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        #endregion


        #region Delete
        // Delete-----------------------------------------------------------------------------------------------------------------------
        // Delete Project --- frm_SaveChannel
        public void Delete_Project(string SelectProject_Name)
        {
            try
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "DELETE FROM project_detail WHERE Project_name = '" + SelectProject_Name + "' ";
                cmd.Connection = connect;
                MySqlDataReader cChannelReder = cmd.ExecuteReader();
                cChannelReder.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
        #endregion
    }


}
