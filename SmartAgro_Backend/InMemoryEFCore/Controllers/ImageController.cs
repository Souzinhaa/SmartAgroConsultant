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
    public class ImageController : ControllerBase
    {
        private ImageDBContext _context;

        public ImageController(ImageDBContext context)
        {
            _context = context;
        }

        // GET api/stateImage/1git 
        [HttpGet("state/{uf}")]
        public ActionResult<ImageModel> GetState(string uf)
        {
            try{ 
                ImageModel img = _context.StateImage.FirstOrDefault(imgt => imgt.nome == uf);
                if (img != null)
                    return img;
            } catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return BadRequest();   
        }

        [HttpGet("cultivars/{id}")]
        public ActionResult<ImageModel> GetCultivars(int id)
        {
            return _context.CultivarsImage.FirstOrDefault(usert => usert.id == id);
        }
    }
}
