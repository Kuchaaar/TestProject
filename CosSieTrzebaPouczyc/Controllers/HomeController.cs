using CosSieTrzebaPouczyc.Models;
using Microsoft.AspNetCore.Mvc;

namespace CosSieTrzebaPouczyc.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost("post")]
        public string TestPost([FromBody] TestModel model)
        {
            return model.ToString();
        }
        /*
        Postman
            {
                "Id":10,
                "TestEnum":"Enum1"
            }
        */

        [HttpPost("post1param")]
        public string TestPostString([FromBody] string id)
        {
            return $"{id}";
        }
        /*
                Postman
                    "test"
        */
        [HttpGet("get")]
        public string TestGet(string id)
        {
            return id;
        }
        /*
         http://localhost:4200/get?id=test
        */

    }
}
