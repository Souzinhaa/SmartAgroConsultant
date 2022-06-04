using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemoryEFCore.Models;
using InMemoryEFCore.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryEFCore.Controllers
{
    [Route("smartagro/[controller]")]
    [ApiController]
    public class StateImageController
    {
        private StateImageDBContext _context;

        public StateImageController(StateImageDBContext context)
        {
            _context = context;
        }

        // GET api/stateImage/1
        [HttpGet("{id}")]
        public ActionResult<StateImageModel> Get(int id)
        {
            return _context.StateImage.FirstOrDefault(usert => usert.id == id);   
        }
    }
}
