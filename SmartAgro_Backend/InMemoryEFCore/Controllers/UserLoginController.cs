using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemoryEFCore.Models;
using InMemoryEFCore.DataContext;
using InMemoryEFCore.Utils;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryEFCore.Controllers
{
    [Route("smartagro/")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private UserLoginDBContext _context;

        public UserLoginController(UserLoginDBContext context)
        {
            _context = context;
        }

            // GET api/userLogin
            [HttpGet("login")]
            public ActionResult<UserDefModel> Get(string name, string senha)
            {
                try {

                    if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(senha))
                        return BadRequest();
                    
                    senha = ExtensionsMethods.DecodeBase64(senha);

                    UserLoginModel userLogin = new UserLoginModel();             

                    userLogin = _context.UserLogin.FirstOrDefault(usert => usert.name == name);

                    if (userLogin != null && senha == userLogin.senha) {
                        UserDefModel user = _context.UserDef.FirstOrDefault(usert => usert.id == userLogin.id);
                        user.login = true;
                        _context.SaveChangesAsync();
                        return user;
                    }

                }
                catch (Exception e) 
                {
                    Console.WriteLine(e);
                }

                return Unauthorized();
            }

            [HttpGet("logout")]
            public ActionResult<UserDefModel> GetLogout(string id, string nome)
            {
                try
                {
                    if (!String.IsNullOrEmpty(id) || !String.IsNullOrEmpty(nome))
                    {
                        int idInt = Int32.Parse(ExtensionsMethods.DecodeBase64(id));
                        nome = ExtensionsMethods.DecodeBase64(nome);

                        UserDefModel user = _context.UserDef.FirstOrDefault(usert => usert.id == idInt);

                        if (user != null && user.nome == nome) {
                            user.login = false;
                            _context.SaveChangesAsync();
                            return Ok();
                        }

                        return Unauthorized();
                    }
                } catch(Exception e)
                {
                    Console.WriteLine(e);
                }

                return BadRequest();
            }

                // GET api/userLogin/1
                [HttpGet("user/{id}")]
            public ActionResult<UserLoginModel> Get(int id)
            {
                return _context.UserLogin.FirstOrDefault(usert => usert.id == id);
            }

            [HttpPost("new")]
            public async Task<ActionResult<UserLoginModel>> Post(UserLoginModel user)
            {
                _context.UserLogin.Add(user);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(Get), new { user.id }, user);
            }

            //Farm
            [HttpGet("farm/{id}")]
            public ActionResult<FarmModel> GetFarm(string id)
            {
                try
                {
                    
                    if(id != null) { 
                        int idUser = Int32.Parse(ExtensionsMethods.DecodeBase64(id));

                        UserDefModel user = _context.UserDef.FirstOrDefault(usert => usert.id == idUser);

                        Console.WriteLine("Usuario logado: " + user.login);

                        if (user.login) { 
                            FarmModel farm = _context.FarmUser.FirstOrDefault(farmt => farmt.userId == idUser);
                            if (farm != null)
                                return farm;
                            else
                                return NotFound();
                        }

                        return Unauthorized();
                    }
            }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                return BadRequest();
            }

    }
}
