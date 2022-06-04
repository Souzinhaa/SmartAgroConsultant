﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InMemoryEFCore.Models;
using InMemoryEFCore.DataContext;
using InMemoryEFCore.Utils;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryEFCore.Controllers
{
    [Route("smartagro/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private UserLoginDBContext _context;

        public UserLoginController(UserLoginDBContext context)
        {
            _context = context;
        }

            // GET api/userLogin
            [HttpGet]
            public ActionResult<UserReturnModel> Get(string name, string senha)
            {
                try {

                    senha = Utils.ExtensionsMethods.DecodeBase64(senha);

                    if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(senha))
                        return BadRequest();
                    else
                    {
                        UserLoginModel userLogin = new UserLoginModel();
                        UserLoginModel userLoginTeste = new UserLoginModel();

                        userLogin.name = name;
                        userLogin.senha = senha;
                    
                        userLoginTeste = _context.UserLogin.FirstOrDefault(usert => usert.name == name);
                    if (userLogin.senha == userLoginTeste.senha)
                    {
                        return new UserReturnModel(userLoginTeste.id, userLoginTeste.name);
                    }
                    else 
                    {
                        return Unauthorized();
                    }
                    
                    }
                    }
                catch (Exception e) {
                    Console.WriteLine(e);
                }
                return Unauthorized();
            }

            // GET api/userLogin/1
            [HttpGet("{id}")]
            public ActionResult<UserLoginModel> Get(int id)
            {
                return _context.UserLogin.FirstOrDefault(usert => usert.id == id);
            }

            [HttpPost]
            public async Task<ActionResult<UserLoginModel>> Post(UserLoginModel user)
            {
                _context.UserLogin.Add(user);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(Get), new { user.id }, user);
            }

    }
}
