﻿using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk.common
{
    internal class Mysql
    {
        public static MySqlConnection DBconnection;

        #region 전역 데이터베이스 연결
        public static void DB_Connection()
        {
            if (DBconnection == null)
            {
                MySqlConnectionStringBuilder connStringBuilder = new MySqlConnectionStringBuilder
                {
                    Server = "kiosk.mysql.database.azure.com",
                    Port = 3306,
                    Database = "kiosk",
                    UserID = "youngjin",
                    Password = "admin123456789;"
                };

                DBconnection = new MySqlConnection(connStringBuilder.ConnectionString);
                DBconnection.Open();
            }
        }
        #endregion

        #region MySqlHelper.GetConnection(); 을 쓰면 db 연결
        public static MySqlConnection GetConnection()
        {
            if (DBconnection == null)
            {
                DB_Connection();
            }

            return DBconnection;
        }
        #endregion
    }

    #region KioskPanel.cs
    internal class ItemInsert
    {
        private MySqlConnection mysql = Mysql.GetConnection();
        private MySqlDataReader reader = null;
        private string sql = null;

        string itemName = null;
        int price = 0;
        string content = null;

        #region 아이템 찾기 및 버튼 생성
        public List<Button> CheckItem()
        {
            List<Button> itemlist = new List<Button>();
            try
            {
                sql = "select * from itemtable";
                MySqlCommand cmd = new MySqlCommand(sql, mysql);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    itemName = reader.GetString("itemName");
                    price = reader.GetInt32("price");
                    content = reader.GetString("content");

                    Button button = new Button();
                    button.Text = itemName;
                    button.Name = itemName;
                    button.Tag = new { itemName, price, content };

                    itemlist.Add(button);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                reader.Close();
            }
            return itemlist;
        }
        #endregion

        #region 아이템 DB 담기

        public void InsertItem(string itemName, int price, string content)
        {
            try
            {
                sql = "insert into kiosktest(itemName, payment, content, regdate) values (@itemName, @price, @content, now())";
                MySqlCommand cmd = new MySqlCommand(sql, mysql);
                cmd.Parameters.AddWithValue("@itemName", itemName);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        #endregion
    }
    #endregion
}
