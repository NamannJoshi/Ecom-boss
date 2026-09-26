using Microsoft.AspNetCore.Mvc;

namespace EcomBoss.Web.Controllers {
    [ApiController]
    [Route("api/users")]
    public class UserController: ControllerBase {
        public readonly List<string> Users = new () {"Lisa", "Pisa", "Sheesha"};

        public UserController() {}

        [HttpGet]
        public ActionResult<List<string>> GetUsers() {
            return this.Ok(this.Users);
        }
    }
}