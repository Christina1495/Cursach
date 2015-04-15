﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;

namespace Cursach
{
    class BD
    {
        string userName;
        public string UserName
        { get { return userName; } }

        string userID;
        public string UserID
        { get { return userID; } }

        string resortCB;
        public string ResortCB
        { get { return resortCB; } }

        string condition = "SELECT * FROM Tour";
        public string Condition
        { get { return condition; } }

        public void Сreate()
        {
            //SQLiteConnection.CreateFile("base.sqlite");//Создание бд
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            ///Создание таблиц
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Resort (id_resort INTEGER PRIMARY KEY, Name TEXT)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Customer (id_customer INTEGER PRIMARY KEY, FIO TEXT, email TEXT, password TEXT)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Hotel (id_hotel INTEGER PRIMARY KEY, hotel_name TEXT)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Tour (id_tour INTEGER PRIMARY KEY, tour_name TEXT, price INTEGER, duration INTEGER, dateS INTEGER, dataE INTEGER, id_resort INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Tour_Hotel (id_tour_hotel INTEGER PRIMARY KEY, id_tour INTEGER, id_hotel INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Excursion (id_excursion INTEGER PRIMARY KEY, exc_name TEXT, description_exc TEXT, duration_exc INTEGER, price_exc INTEGER, marks INTEGER, id_resort INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Discount (id_discount INTEGER PRIMARY KEY, id_resort INTEGER, name_tour TEXT, description TEXT, prices INTEGER, discount INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Customer_Tour (id_CusTour INTEGER PRIMARY KEY, id_customer INTEGER, id_tour INTEGER, prices INTEGER, contract INTEGER, date_contract INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Tour_Excursion (id_tour_excursion INTEGER PRIMARY KEY, price_TourExc INTEGER, id_excursion INTEGER, id_CusTour INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Date_Tour (id_datetour INTEGER PRIMARY KEY, amount INTEGER, date TEXT, id_tour INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Bank_Customer (id_bank_customer INTEGER PRIMARY KEY, data_price TEXT, sum_contract INTEGER, id_custour INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("DROP TABLE Tour", connection);
            ///
            connection.Open();
            //create.ExecuteNonQuery();
            connection.Close();
        }

        public void Discount()
        {
            ///Заполнение табл. Предложений
            Parser p = new Parser();
            string container = p.getRequest("http://www.riviera-sochi.ru/offers/");
            string Block = p.Block(container, "//div[@class='center_block']");
            string Text = "";
            p.STOP = false;
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("DELETE FROM 'Discount'", connection);
            command.ExecuteNonQuery();
            while (p.STOP == false)
            {
                Block = p.Block1(Block, "entry", "entry");
                p.Shares(p.BLOCK_WORK);
                if (p.NAME != "")
                {
                    SQLiteCommand sql = new SQLiteCommand(connection);
                    sql.CommandText = @"SELECT id_resort FROM Resort WHERE Name = '" + p.RESORT + "'";
                    SQLiteDataReader reader = sql.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        Text = record["id_resort"].ToString();
                    }
                    command = new SQLiteCommand("INSERT INTO 'Discount' ('id_resort', 'name_tour', 'description', 'prices', 'discount') VALUES ('" + Text + @"', '" + p.NAME + @"', '" + p.DESCRIPTION + "', '" + p.PRICE + "', '" + p.DISCOUNT + "');", connection);
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        public void Excursion()
        {
            Parser p = new Parser();
            string container = p.getRequest("http://www.riviera-sochi.ru/excursions");
            string Block = p.Block(container, "//div[@class='center_block']");
            string Text = "";
            p.STOP = false;
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("DELETE FROM 'Excursion'", connection);
            command.ExecuteNonQuery();
            ///Заполнение табл. Экскурсии
            while (p.STOP == false)
            {
                Block = p.Block1(Block, "bottom", "excursion_thumb");
                p.Excursions(p.BLOCK_WORK);
                SQLiteCommand sql = new SQLiteCommand(connection);
                sql.CommandText = @"SELECT id_resort FROM Resort WHERE Name = '" + p.RESORT_EX + "'";
                SQLiteDataReader reader = sql.ExecuteReader();
                foreach (DbDataRecord record in reader)
                {
                    Text = record["id_resort"].ToString();
                }
                command = new SQLiteCommand("INSERT INTO 'Excursion' ('exc_name', 'description_exc', 'duration_exc', 'price_exc', 'id_resort') VALUES ('" + p.NAME_EX + @"', '" + p.DESCRIPTION + @"', '" + p.DURATION_EX + "', '" + p.PRICE_EX + "', '" + Text + "');", connection);
                command.ExecuteNonQuery();
            }
            ///
            connection.Close();
        }

        public void Resort()
        {
            Parser p = new Parser();
            string container = p.getRequest("http://www.riviera-sochi.ru/resorts/");
            string Block = p.Block(container, "//div[@class='center_block']");
            string s = "";
            p.STOP = false;
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            ///Заполнение табл. Курорт
            while (p.STOP == false)
            {
                Block = p.Block1(Block, "hotels_selector", "<h4>");
                p.Resort_(p.BLOCK_WORK);
                s = p.NAME_RES;
                SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Resort' ('Name') VALUES ('" + s + @"');", connection);
                command.ExecuteNonQuery();
            }
            ///
            connection.Close();
        }

        public void Tour()
        {
            ///Заполнение табл. Тур и Тур_Отель
            Parser p = new Parser();
            string container = p.getRequest("http://www.riviera-sochi.ru/tours/");
            string Block = p.Block(container, "//div[@class='entry']");
            int i = 0;
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("DELETE FROM 'Tour'", connection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("DELETE FROM 'Tour_Hotel'", connection);
            command.ExecuteNonQuery();
            while (p.STOP == false)
            {
                i++;
                string Text = "";
                Block = p.Block1(Block, "bottom", "<a");
                p.Tour(p.BLOCK_WORK);
                string URL = "http://www.riviera-sochi.ru/tours/" + p.ID;
                container = p.getRequest(URL);
                p.Check(container);
                SQLiteCommand sql = new SQLiteCommand(connection);
                sql.CommandText = @"SELECT id_resort FROM Resort WHERE Name = '" + p.RESORT.Trim() + "'";
                SQLiteDataReader reader = sql.ExecuteReader();
                foreach (DbDataRecord record in reader)
                {
                    Text = record["id_resort"].ToString();
                }
                command = new SQLiteCommand("INSERT INTO 'Tour' ('id_tour', 'tour_name', 'price', 'duration', 'dateS', 'dataE', 'id_resort') VALUES ('" + p.ID + @"', '" + p.NAME + @"', '" + p.PRICE + @"', '" + p.DURATION + @"', '" + p.DATE + @"', '" + p.DATE_END + @"', '" + Text + @"');", connection);
                command.ExecuteNonQuery();
                string[] hotel = p.HOTEL.Split(',');
                for (int j = 0; j < hotel.GetLength(0)-1; j++)
                {
                    SQLiteCommand sql1 = new SQLiteCommand(connection);
                    sql1.CommandText = @"SELECT id_hotel FROM Hotel WHERE hotel_name = '" + hotel[j].Trim() + @"'";
                    SQLiteDataReader reader1 = sql1.ExecuteReader();
                    foreach (DbDataRecord record in reader1)
                    {
                        Text = record["id_hotel"].ToString();
                    }
                    command = new SQLiteCommand("INSERT INTO 'Tour_Hotel' ('id_tour', 'id_hotel') VALUES ('" + p.ID + @"', '" + Text + @"');", connection);
                    command.ExecuteNonQuery();
                }                
            }
            connection.Close();
        }

        public void Hotel()
        {
            Parser p = new Parser();
            string container = p.getRequest("http://www.riviera-sochi.ru/hotels/top");
            p.Hotels_(container);
            string s = p.HOTELS;
            string[] arr = s.Split(',');
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            ///Заполнение табл. Отели
            SQLiteCommand command = new SQLiteCommand("DELETE FROM 'Hotel'", connection);
            command.ExecuteNonQuery();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                command = new SQLiteCommand("INSERT INTO 'Hotel' ('hotel_name') VALUES ('" + arr[i] + @"');", connection);
                command.ExecuteNonQuery();
            }
            ///
            connection.Close();
        }

        public void Registration(string FIO, string email, string password)
        {
            //<--FormRegistration +
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");            
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Customer' ('FIO', 'email', 'password') VALUES ('" + FIO + @"', '" + email + @"',  '" + password + @"');", connection);
            command.ExecuteNonQuery(); 
            connection.Close();
        }

        public string Authorization(string email, string password)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Customer WHERE email = '" + email + "'";
            SQLiteDataReader reader = sql.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                if (password.Trim() == record["password"].ToString())
                {
                    userID = record["id_customer"].ToString();
                    userName = record["FIO"].ToString();
                    return "ok";
                }
                else
                {
                    return "ne ok";
                }
            }
            connection.Close();
            return null;
        }

        public void ResortComboBox()
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Resort";
            SQLiteDataReader reader = sql.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                resortCB += record["Name"].ToString() + ",";
            }
            resortCB = resortCB.Remove(resortCB.Length - 1, 1);
            connection.Close();
        }

        bool whereB = false;
        public void Con(string Text)
        {
            string where = " WHERE ";
            string and = " AND ";
            if (Text != "")
            {
                if (whereB != true)
                {
                    condition += where + Text;
                    whereB = true;
                }
                else
                {
                    condition += and + Text;
                }
            }
        }

        string conditionResort;
        string conditionDateS;
        string conditionDateE;
        string conditionPriceMin;
        string conditionPriceMax;
        string conditionDurationMin;
        string conditionDurationMax;

        public void UserRequestsTour(string Resort, string dateS, string dateE, string priceMin, string priceMax, string DurationMin, string DurationMax)
        {
            condition = "SELECT * FROM Tour";
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            if(Resort != "")
            {
                SQLiteCommand sql = new SQLiteCommand(connection);
                sql.CommandText = @"SELECT * FROM Resort WHERE Name = '" + Resort + @"'";
                SQLiteDataReader reader = sql.ExecuteReader();
                foreach (DbDataRecord record in reader)
                {
                    conditionResort = "id_resort = " + record["id_resort"].ToString();
                }
            }
            else
            {
                conditionResort = "";
            }
            Con(conditionResort);
            connection.Close();
            int index = 0;
            string[] dm = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            if (dateS != "")
            {                
                for(int i = 0; i < 12; i++)
                {
                    if (dm[i] == dateS)
                    {
                        index = i;
                    }
                }
                conditionDateS = "dateS > " + index.ToString();
            }
            else
            {
                conditionDateS = "";
            }
            Con(conditionDateS);
            if (dateE != "")
            {
                for (int i = 0; i < 12; i++)
                {
                    if (dm[i] == dateE)
                    {
                        index = i + 2;
                    }
                }
                conditionDateE = "dateS < " + index.ToString();
            }
            else
            {
                conditionDateE = "";
            }
            Con(conditionDateE);
            if (priceMin != "")
            {
                conditionPriceMin = "price > " + priceMin;
            }
            else
            {
                conditionPriceMin = "";
            }
            Con(conditionPriceMin);
            if (priceMax != "")
            {
                conditionPriceMax = "price < " + priceMax;
            }
            else
            {
                conditionPriceMax = "";
            }
            Con(conditionPriceMax);
            if (DurationMin != "")
            {
                conditionDurationMin = "duration > " + DurationMin;
            }
            else
            {
                conditionDurationMin = "";
            }
            Con(conditionDurationMin);
            if (DurationMax != "")
            {
                conditionDurationMax = "duration < " + DurationMax;
            }
            else
            {
                conditionDurationMax = "";
            }
            Con(conditionDurationMax);
        }

    }
}