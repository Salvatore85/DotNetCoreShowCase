using AutoMapper;
using CoreShowCase.Api.Models;
using CoreShowCase.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShowCase.Api.Controllers
{
    [Route("api/user")]
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

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult GetUser(int userId)
        {
            try
            {
                var user = Repository.GetUser(userId);

                if (user == null)
                {
                    return NotFound();
                }

                if (!Repository.UserExists(userId))
                {
                    return NotFound();
                }

                var userResult = Mapper.Map<UserDTO>(user);
                return Ok(userResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "A problem occured while handeling your request.");
            }
        }
    }
}
