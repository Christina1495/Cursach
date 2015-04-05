using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Cursach
{
    class BD
    {
        public void Сreate()
        {
            //SQLiteConnection.CreateFile("base.sqlite");//Создание бд
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            ///Создание таблиц
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Resort (id_resort INTEGER PRIMARY KEY, Name TEXT)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Customer (id_customer INTEGER PRIMARY KEY, FIO TEXT, email TEXT, password TEXT)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Hotel (id_hotel INTEGER PRIMARY KEY, hotel_name TEXT)", connection);

            ///
            connection.Open();
            //create.ExecuteNonQuery();
            connection.Close();
        }

        public void Resort()
        {
            Parser p = new Parser();
            string container = p.getRequest("http://www.riviera-sochi.ru/resorts/");
            string Block = p.Block(container, "//div[@class='center_block']");
            int i = 1;
            string s = "";
            p.STOP = false;
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            ///Заполнение табл. Курорт
            while (p.STOP == false)
            {
                i++;
                Block = p.Block1(Block, "hotels_selector", "<h4>");
                p.Resort_(p.BLOCK_WORK);
                s = p.NAME_RES;
                SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Resort' ('id_resort', 'Name') VALUES ('" + i + @"', '" + s + @"');", connection);
                command.ExecuteNonQuery();
            }
            ///
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
            //<--FormRegistration
            Parser p = new Parser();
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");            
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Customer' ('FIO', 'email', 'password') VALUES ('" + FIO + @"', '" + email + @"',  '" + password + @"');", connection);
            command.ExecuteNonQuery(); 
            connection.Close();
        }
    }
}
