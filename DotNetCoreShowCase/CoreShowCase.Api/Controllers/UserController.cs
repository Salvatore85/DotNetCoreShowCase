using AutoMapper;
using CoreShowCase.Api.Entities;
using CoreShowCase.Api.Models;
using CoreShowCase.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShowCase.Api.Controllers
{
    [Route("api/users")]
    public class UserController : Controller
    {
        private ICSCRepository Repository;

        public UserController(ICSCRepository repository)
        {
            Repository = repository;
        }

        [HttpGet(Name = "GetUsers")]
        public IActionResult GetUsers()
        {
            var userEntities = Repository.GetUsers();
            var result = Mapper.Map<IEnumerable<UserDTO>>(userEntities);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var user = Repository.GetUser(id);

                if (user == null)
                {
                    return NotFound();
                }

                if (!Repository.UserExists(id))
                {
                    return NotFound();
                }

                var userResult = Mapper.Map<UserDTO>(user);
                return Ok(userResult);
            }
            catch (Exception)
            {
                return StatusCode(500, "A problem occured while handeling your request.");
            }
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody]UserCreationDTO newUser)
        {
            if (newUser == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var finalUser = Mapper.Map<User>(newUser);

            Repository.CreateUser(finalUser);

            if (!Repository.Save())
            {
                return StatusCode(500, "A problem happened while handeling your request.");
            }

            var createdUser = Mapper.Map<UserDTO>(finalUser);

            //return CreatedAtAction("GetUsers", createdUser);
            return CreatedAtRoute("GetUser", new { id = createdUser.Id }, createdUser);
        }
    }
}
