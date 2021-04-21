using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFlashDrives
{
    class VerificationMechanism
    {
        async static public void Check()
        {//Метод проверки черного списка
            await Task.Run(async () =>
            {

                DateTime time = DateTime.Now;

                string con = "USER ID = CONTROLLER; PASSWORD=1234; DATA SOURCE = localhost:1521/XE; Persist Security Info=True;";

                OracleConnection connection = new OracleConnection(con);
                connection.Open();

                string sql = "SELECT USERS_ID FROM ISSUE WHERE TIME_TAKE<'" + time.ToString() + "'";
                OracleCommand command = new OracleCommand(sql, connection);
                command.CommandType = CommandType.Text;

                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                string[] id = new string[table.Rows.Count];
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    id[i] = table.Rows[i][0].ToString();


                    string sql_c = "SELECT * FROM BLACK_LIST WHERE USERS_ID='" + id[i] + "'";
                    OracleCommand command_c = new OracleCommand(sql_c, connection);
                    command_c.CommandType = CommandType.Text;
                    OracleDataAdapter adapter_c = new OracleDataAdapter(command_c);
                    DataTable table_c = new DataTable();
                    adapter_c.Fill(table_c);

                    if (table_c.Rows.Count < 1)
                    {
                        string del = id[i];
                        string sql_del = "INSERT INTO BLACK_LIST (USERS_ID) VALUES('" + del + "')";
                        OracleCommand command_del = new OracleCommand(sql_del, connection);
                        command_del.CommandType = CommandType.Text;
                        if (command_del.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Произошла ошибка добавления в черный списсок");
                        }

                    }
                }
                connection.Close();
                await Task.Delay(60000);

                Check();

            });
        }
    }
}
