using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelTodo
{
    public class TodoModel
    {
        public int id { get; set; }
        public string? description { get; set; }

        public TodoModel() { }

        public TodoModel(int id, string? description)
        {
            this.id = id;
            this.description = description;
        }
        public static TodoModel ToObject(DataRow drtodo)
        {
            try
            {
                TodoModel obj = new TodoModel();
                obj.id = Convert.ToInt32(drtodo["id"]);
                obj.description = drtodo["description"].ToString();
                return obj;

            }catch  
            {
                throw;
            }
        }
        public static List<TodoModel> ToList(DataTable dtpur)
        {
            try
            {
                List<TodoModel> objs = new List<TodoModel>();
                foreach (DataRow dr in dtpur.Rows)
                {
                    objs.Add(TodoModel.ToObject(dr));
                }
                return objs;
            }
            catch
            {
                throw;
            }
        }
    
    }
}
