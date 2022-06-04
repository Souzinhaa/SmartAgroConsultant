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
                        UserDefModel user = GetUserLogin(userLogin.id);
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

                        UserDefModel user = GetUserLogin(idInt);

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
            [HttpPost("user/new")]
            public async Task<ActionResult<UserDefModel>> Post(NewUserModel nUser)
            {

                //Console.WriteLine(_context.UserDef.Count());
                
                UserDefModel user = new UserDefModel();
                user.id = _context.UserDef.Count()+1;


                user.nome = nUser.nome;
                user.email = nUser.email;
                user.visibilidade = true;
                user.login = true;

                UserLoginModel lUser = new UserLoginModel();
                lUser.id = user.id;
                lUser.name = nUser.nomeUsuario;
                lUser.senha = nUser.senha;
                

                _context.UserDef.Add(user);
                _context.UserLogin.Add(lUser);
            
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetUserLogin), new { user.id }, user);
            }

            //Farm
            [HttpGet("farm/{id}")]
            public ActionResult<FarmModel> GetFarm(string id)
            {
                try
                {
                    if(id != null) { 
                        int idUser = Int32.Parse(ExtensionsMethods.DecodeBase64(id));

                        if (GetUserSession(idUser)) { 
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
            [HttpPost("farm/new")]
            public async Task<ActionResult<FarmModel>> PostFarm(FarmModel farm)
            {
                try
                {
                    if (farm != null)
                    {

                        if (farm.id != null)
                        {

                            if (GetUserSession(farm.id)) {

                                _context.FarmUser.Add(farm);

                                await _context.SaveChangesAsync();

                                return CreatedAtAction(nameof(GetFarm), new { farm.id }, farm);
                            }

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

            public UserDefModel GetUserLogin(int idUser)
            {
                UserDefModel user = _context.UserDef.FirstOrDefault(uset => uset.id == idUser);

                if (user != null)
                    return user;

                return null;
            }

            public bool GetUserSession(int idUser)
            {
                UserDefModel user = _context.UserDef.FirstOrDefault(uset => uset.id == idUser);

                return user.login;
            }

    }
}
