using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemoryEFCore.Models;
using InMemoryEFCore.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryEFCore.Controllers
{
    [Route("smartagro/image")]
    [ApiController]
    public class ImageController
    {
        private ImageDBContext _context;

        public ImageController(ImageDBContext context)
        {
            _context = context;
        }

        // GET api/stateImage/1git 
        [HttpGet("state/{id}")]
        public ActionResult<ImageModel> GetState(int id)
        {
            return _context.StateImage.FirstOrDefault(usert => usert.id == id);   
        }

        [HttpGet("cultivars/{id}")]
        public ActionResult<ImageModel> GetCultivars(int id)
        {
            return _context.CultivarsImage.FirstOrDefault(usert => usert.id == id);
        }
    }
}
