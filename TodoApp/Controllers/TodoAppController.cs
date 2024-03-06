using BLLTodo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelTodo;
using Newtonsoft.Json;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoAppController : ControllerBase
    {
        [HttpGet("[Action]", Name = "GetTodo")]
        public ActionResult GetTodo()
        {
            try
            {
                BLTodo bLTodo = new BLTodo();
                List<TodoModel> user = bLTodo.GetTodoList();
                if (user == null || user.Count == 0)
                    return NoContent();
                return Ok(JsonConvert.SerializeObject(user));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
