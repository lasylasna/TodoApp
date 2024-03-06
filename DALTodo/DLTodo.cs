using Microsoft.Data.SqlClient;
using ModelTodo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DALTodo
{
    public class dLTodo
    {
        SqlConnection con = new SqlConnection(DLSettings.DbConnectionString);

        public List<TodoModel> GetTodoList()
        {
            List<TodoModel> todoList = new List<TodoModel>();

            try
            {
                con.Open();

                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM notes";
                    Console.WriteLine(command.CommandText);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TodoModel todo = new TodoModel();

                            // Assuming TodoModel has properties, adjust the indices accordingly
                            if (!reader.IsDBNull(0))
                                todo.id = (int)reader[0];

                            if (!reader.IsDBNull(1))
                                todo.description = (string?)reader[1];


                            // Add other properties similarly

                            todoList.Add(todo);
                            Console.WriteLine($"Todo ID: {reader}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, throw, etc.)
            }
            finally
            {
                con.Close();
            }

            return todoList;
        }

    }
}
