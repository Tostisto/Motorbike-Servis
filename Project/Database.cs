using Microsoft.Data.Sqlite;
using System.ComponentModel;
using System.Configuration;

namespace Project
{
    public class Database
    {
        public static string sqlConnection = ConfigurationManager.AppSettings["cs"];

        public static async Task insert<T>(T obj)
        {
            string tableName = obj.GetType().Name;

            List<string> tableProperty = new List<string>();
            List<string> tableValue = new List<string>();

            foreach (var property in obj.GetType().GetProperties())
            {
                if (property.Name == "Id")
                {
                    continue;
                }

                if (property.PropertyType == typeof(string))
                {
                    tableProperty.Add(property.Name);
                    tableValue.Add("'" + property.GetValue(obj).ToString() + "'");
                }
                else
                {
                    tableProperty.Add(property.Name);
                    tableValue.Add(property.GetValue(obj).ToString());
                }
            }

            string prop = "", values = "";

            bool first = true;
            foreach (string p in tableProperty)
            {
                if (first)
                {
                    prop += p;
                    first = false;
                }
                else
                {
                    prop += $", {p}";
                }
            }

            first = true;
            foreach (string v in tableValue)
            {
                if (first)
                {
                    values += v;
                    first = false;
                }
                else
                {
                    values += $", {v}";
                }
            }

            string insert = $"insert into {tableName} ({prop}) values({values})";


            using (SqliteConnection conn = new SqliteConnection(sqlConnection))
            {
                conn.Open();

                using (SqliteCommand cmd = new SqliteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = insert;
                    await cmd.ExecuteNonQueryAsync();
                }
                conn.Close();
            }
        }

        public static async Task initDatabase()
        {
            using (SqliteConnection connection = new SqliteConnection(sqlConnection))
            {
                connection.Open();

                using (SqliteCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = await File.ReadAllTextAsync("Assets/create.sql");
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public static BindingList<T> select<T>()
        {
            BindingList<T> list = new BindingList<T>();

            string tableName = typeof(T).Name;

            string select = $"select * from {tableName}";

            using (SqliteConnection conn = new SqliteConnection(sqlConnection))
            {
                using (SqliteCommand cmd = new SqliteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = select;

                    conn.Open();

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T obj = (T)Activator.CreateInstance(typeof(T));

                            foreach (var property in obj.GetType().GetProperties())
                            {
                                if (property.PropertyType == typeof(string))
                                {
                                    property.SetValue(obj, reader[property.Name].ToString());
                                }
                                else if (property.PropertyType == typeof(int))
                                {
                                    property.SetValue(obj, int.Parse(reader[property.Name].ToString()));
                                }
                                else if (property.PropertyType == typeof(float))
                                {
                                    property.SetValue(obj, float.Parse(reader[property.Name].ToString()));
                                }
                            }

                            list.Add(obj);
                        }
                    }
                    conn.Close();
                }
            }
            return list;
        }

        
        public static async Task Update<T>(T obj)
        {
            int objectID = (int)obj.GetType().GetProperty("Id").GetValue(obj);

            foreach (var property in obj.GetType().GetProperties())
            {
                if (property.Name == "Id")
                {
                    continue;
                }

                using (SqliteConnection conn = new SqliteConnection(sqlConnection))
                {
                    conn.Open();

                    using (SqliteCommand cmd = new SqliteCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = $"update {obj.GetType().Name} set {property.Name} = $value where Id = $id";
                        cmd.Parameters.AddWithValue("$value", property.GetValue(obj));
                        cmd.Parameters.AddWithValue("$id", objectID);
                        await cmd.ExecuteNonQueryAsync();
                    }
                    conn.Close();
                }
            }
        }


        public static BindingList<T> SpecificSelect<T>(string where)
        {
            BindingList<T> list = new BindingList<T>();

            string tableName = typeof(T).Name;

            string select = $"select * from {tableName} where {where};";

            using (SqliteConnection conn = new SqliteConnection(sqlConnection))
            {
                using (SqliteCommand cmd = new SqliteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = select;

                    conn.Open();

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T obj = (T)Activator.CreateInstance(typeof(T));

                            foreach (var property in obj.GetType().GetProperties())
                            {
                                if (property.PropertyType == typeof(string))
                                {
                                    property.SetValue(obj, reader[property.Name].ToString());
                                }
                                else if (property.PropertyType == typeof(int))
                                {
                                    property.SetValue(obj, int.Parse(reader[property.Name].ToString()));
                                }
                                else if (property.PropertyType == typeof(float))
                                {
                                    property.SetValue(obj, float.Parse(reader[property.Name].ToString()));
                                }
                            }

                            list.Add(obj);
                        }
                    }
                    conn.Close();
                }
            }

            return list;
        }

    }
}
