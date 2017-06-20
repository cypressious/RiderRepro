using ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api")]
    public class ValuesController : Controller
    {
        private readonly Class1 foo;

        public ValuesController(Class1 foo)
        {
            this.foo = foo;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "Foo2 " + foo.Bar;
        }
    }
}