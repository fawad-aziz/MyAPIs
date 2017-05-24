using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAPIs.Base.Controllers;

namespace MyAPIs.Controllers
{
    [Produces("application/json")]
    [Route("api/ToDo")]
    public class ToDoController : BaseController
    {
    }
}