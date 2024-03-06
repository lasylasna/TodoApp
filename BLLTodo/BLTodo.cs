using DALTodo;
using ModelTodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLTodo
{
    public class BLTodo
    {
   //     public TodoModel GetTodo()
      //  {
      //      try
       //     {
//TodoModel dLvisitor = TodoModel.ToObject(new DLTodo().GetTodo());
        //        return dLvisitor;
        //    }
        //    catch
         //   {
          //      throw;
          //  }
      //  }

        public List<TodoModel> GetTodoList()
        {
            try
            {
                dLTodo dLTodo = new dLTodo();
                return dLTodo.GetTodoList();     
            
            }
            catch
            {
                throw;
            }
        }
    }
}
