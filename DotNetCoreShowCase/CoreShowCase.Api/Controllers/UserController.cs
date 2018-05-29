using CoreShowCase.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShowCase.Api.Controllers
{
    public class UserController : Controller
    {
        private ICSCRepository Repository;

        public UserController(ICSCRepository repository)
        {
            Repository = repository;
        }
    }
}
