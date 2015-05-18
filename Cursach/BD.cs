using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;

namespace Cursach
{
    /// <summary>
    /// Работа с БД
    /// </summary>
    class BD
    {
        /// <summary>
        /// 
        /// </summary>
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

        string city = "";
        public string City
        { get { return city; } }

        string street = "";
        public string Street
        { get { return street; } }

        string house = "";
        public string House
        { get { return house; } }

        string apartment = "";
        public string Apartment
        { get { return apartment; } }

        string postcode = "";
        public string Postcode
        { get { return postcode; } }

        string account = "";
        public string Account
        { get { return account; } }

        string bank = "";
        public string Bank
        { get { return bank; } }

        /// <summary>
        /// Создание таблиц
        /// </summary>
        public void Сreate()
        {
            //SQLiteConnection.CreateFile("base.sqlite");//Создание бд
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            ///Создание таблиц
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Resort (id_resort INTEGER PRIMARY KEY, Name TEXT)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Customer (id_customer INTEGER PRIMARY KEY, FIO TEXT, email TEXT, password TEXT, city TEXT, street TEXT, house TEXT, apartment TEXT, postcode TEXT, account TEXT, bank TEXT)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Hotel (id_hotel INTEGER PRIMARY KEY, hotel_name TEXT)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Tour (id_tour INTEGER PRIMARY KEY, tour_name TEXT, price INTEGER, duration INTEGER, dateS INTEGER, dataE INTEGER, id_resort INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Tour_Hotel (id_tour_hotel INTEGER PRIMARY KEY, id_tour INTEGER, id_hotel INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Excursion (id_excursion INTEGER PRIMARY KEY, exc_name TEXT, description_exc TEXT, duration_exc INTEGER, price_exc INTEGER, marks INTEGER, id_resort INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Discount (id_discount INTEGER PRIMARY KEY, id_resort INTEGER, name_tour TEXT, description TEXT, prices INTEGER, discount INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Customer_Tour (id_CusTour INTEGER PRIMARY KEY, id_customer INTEGER, id_tour INTEGER, prices INTEGER, contract INTEGER, date_contract TEXT, allSum INTEGER, status INTEGER, paid INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Tour_Excursion (id_tour_excursion INTEGER PRIMARY KEY, price_TourExc INTEGER, id_excursion INTEGER, id_CusTour INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Date_Tour (id_datetour INTEGER PRIMARY KEY, amount INTEGER, date TEXT, id_tour INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Bank_Customer (id_bank_customer INTEGER PRIMARY KEY, paid INTEGER, data_price TEXT, id_custour INTEGER)", connection);
            //SQLiteCommand create = new SQLiteCommand("CREATE TABLE Category (id_cat INTEGER PRIMARY KEY, cat_name TEXT)", connection);
            SQLiteCommand create = new SQLiteCommand("CREATE TABLE Stuff (id_stuff INTEGER PRIMARY KEY, id_cat INTEGER ,stuff_name TEXT)", connection);
            //SQLiteCommand create = new SQLiteCommand("DELETE FROM 'Resort'", connection);
            //SQLiteCommand create = new SQLiteCommand("DROP TABLE Bank_Customer", connection);
            //SQLiteCommand create = new SQLiteCommand("DROP TABLE Customer", connection);
            ///
            connection.Open();
            //create.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Заполнение табл. Предложений
        /// </summary>
        public void Discount()
        {
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

        /// <summary> 
        ///Заполнение табл. Экскурсии
        /// </summary>
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
                command = new SQLiteCommand("INSERT INTO 'Excursion' ('exc_name', 'description_exc', 'duration_exc', 'price_exc', 'marks', 'id_resort') VALUES ('" + p.NAME_EX + @"', '" + p.DESCRIPTION + @"', '" + p.DURATION_EX + "', '" + p.PRICE_EX + "', 5, '" + Text + "');", connection);
                command.ExecuteNonQuery();
            }
            ///
            connection.Close();
        }

        /// <summary>
        /// ///Заполнение табл. Курорт
        /// </summary>
        public void Resort()//Не торгать его
        {
            Parser p = new Parser();
            string container = p.getRequest("http://www.riviera-sochi.ru/resorts/");
            string Block = p.Block(container, "//div[@class='center_block']");
            string s = "";
            p.STOP = false;
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
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

        /// <summary>
        /// ///Заполнение табл. Тур и Тур_Отель
        /// </summary>
        public void Tour()
        {
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

        /// <summary>
        /// ///Заполнение табл. Отели
        /// </summary>
        public void Hotel()
        {
            Parser p = new Parser();
            string container = p.getRequest("http://www.riviera-sochi.ru/hotels/top");
            p.Hotels_(container);
            string s = p.HOTELS;
            string[] arr = s.Split(',');
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
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

        /// <summary>
        /// Регистрация
        /// </summary>
        /// <param name="FIO"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void Registration(string FIO, string email, string password)
        {
            //<--FormRegistration +
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");            
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Customer' ('FIO', 'email', 'password') VALUES ('" + FIO + @"', '" + email + @"',  '" + password + @"');", connection);
            command.ExecuteNonQuery(); 
            connection.Close();
        }

        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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
                    connection.Close();
                    return "ok";
                    
                }
                else
                {
                    connection.Close();
                    return "ne ok";
                }
            }
            connection.Close();
            return null;
        }

        /// <summary>
        /// ///Заполнение табл. Клиент
        /// </summary>
        /// <param name="id"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="house"></param>
        /// <param name="apartment"></param>
        /// <param name="postcode"></param>
        /// <param name="account"></param>
        /// <param name="bank"></param>
        public void Customer(string id, string city, string street, string house, string apartment, string postcode, string account, string bank)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("UPDATE Customer SET city = '" + city + "', street = '" + street + "', house = '" + house + "', apartment = '" + apartment + "', postcode = '" + postcode + "', account = '" + account + "', bank = '" + bank + "' WHERE id_customer = '" + id + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Вывод данных на форму оформления договора
        /// </summary>
        /// <param name="id"></param>
        public void FormDog(string id)
        {
            city = "";
            street = "";
            house = "";
            apartment = "";
            postcode = "";
            account = "";
            bank = "";
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Customer WHERE id_customer = '" + id + "'";
            SQLiteDataReader reader = sql.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                city = record["city"].ToString();
                street = record["street"].ToString();
                house = record["house"].ToString();
                apartment = record["apartment"].ToString();
                postcode = record["postcode"].ToString();
                account = record["account"].ToString();
                bank = record["bank"].ToString();
            }
            connection.Close();
        }

        /// <summary>
        /// Вывод данных из табл. Курорт для ComboBox
        /// </summary>
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

        /// <summary>
        /// Составление SQL запроса к табл. Туры - 1
        /// </summary>
        /// <param name="Text"></param>
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

        /// <summary>
        /// Составление SQL запроса к табл. Туры - 2
        /// </summary>
        /// <param name="Resort"></param>
        /// <param name="dateS"></param>
        /// <param name="dateE"></param>
        /// <param name="priceMin"></param>
        /// <param name="priceMax"></param>
        /// <param name="DurationMin"></param>
        /// <param name="DurationMax"></param>
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

        /// <summary>
        /// Оценка Экскурсий
        /// </summary>
        /// <param name="mNew"></param>
        /// <param name="mOld"></param>
        /// <param name="id"></param>
        public void marks(int mNew, string mOld, string id)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("UPDATE Excursion SET marks = '" + Convert.ToString((mNew + Convert.ToInt32(mOld)) / 2) + "'WHERE id_excursion = '" + id + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Заполнение табл. Customer_Tour и Tour_Excursion при оформлении тура
        /// </summary>
        /// <param name="id_customer"></param>
        /// <param name="id_tour"></param>
        /// <param name="contract"></param>
        /// <param name="prices"></param>
        /// <param name="date_contract"></param>
        /// <param name="ExId"></param>
        /// <param name="ExPr"></param>
        /// <param name="allSum"></param>
        public void CustomerTour(string id_customer, string id_tour, string contract, string prices, string date_contract, string ExId, string ExPr, string allSum)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Customer_Tour' ('id_CusTour', 'id_customer', 'id_tour', 'prices', 'contract', 'date_contract', 'allSum', 'status', 'paid') VALUES ('" + contract + @"', '" + id_customer + @"', '" + id_tour + @"', '" + prices + @"', '" + contract + @"', '" + date_contract + @"', '" + allSum + @"', '0', '0');", connection);
            command.ExecuteNonQuery();
            if (ExPr != "")
            {
                string[] ExIdArr = ExId.Split('|');
                string[] ExPrArr = ExPr.Split('|');
                for (int i = 0; i < ExIdArr.GetLength(0) - 1; i++)
                {
                    SQLiteCommand command1 = new SQLiteCommand("INSERT INTO 'Tour_Excursion' ('price_TourExc', 'id_excursion', 'id_CusTour') VALUES ('" + ExPrArr[i] + @"', '" + ExIdArr[i] + @"', '" + contract + @"');", connection);
                    command1.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        /// <summary>
        /// Заполнение Bank_Customer при оплате 
        /// </summary>
        /// <param name="paid"></param>
        /// <param name="date"></param>
        /// <param name="id"></param>
        /// <param name="sum"></param>
        /// <param name="price"></param>
        public void BankCustomer(string paid, string date, string id, string sum, string price)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Bank_Customer' ('paid', 'data_price', 'id_custour') VALUES ('" + paid + @"', '" + date + @"', '" + id + @"');", connection);
            command.ExecuteNonQuery();
            command = new SQLiteCommand("UPDATE Customer_Tour SET paid = '" + sum + "'WHERE id_CusTour = '" + id + "'", connection);
            command.ExecuteNonQuery();
            if(Convert.ToInt32(sum) >= Convert.ToInt32(price))
            {
                command = new SQLiteCommand("UPDATE Customer_Tour SET status = 1 WHERE id_CusTour = '" + id + "'", connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        /// <summary>
        /// Прибыль фирмы по месяцам
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="date"></param>
        /// <param name="idTour"></param>
        public void DateTour(string sum, string date, string idTour)
        {
            bool Update = false;
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Date_Tour WHERE date = '" + date + "' AND id_tour = '" + idTour + "'";
            SQLiteDataReader reader = sql.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                Update = true;
                int summa = Convert.ToInt32(sum) + Convert.ToInt32(record["amount"].ToString());
                SQLiteCommand command = new SQLiteCommand("UPDATE Date_Tour SET amount = '" + summa + "' WHERE id_datetour = '" + record["id_datetour"].ToString() + "'", connection);
                command.ExecuteNonQuery();
            }
            if (Update == false)
            {
                SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Date_Tour' ('amount', 'date', 'id_tour') VALUES ('" + sum + @"', '" + date + @"', '" + idTour + @"');", connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        /// <summary>
        /// Изменение
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="id"></param>
        public void UPDATE(string Text, string id)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("UPDATE " + Text + " WHERE " + id + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Добавление
        /// </summary>
        /// <param name="Text"></param>
        public void INSERT(string Text)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO " + Text + ";", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="id"></param>
        public void DELETE(string Text, string id)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("DELETE FROM " + Text + " WHERE " + id + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
