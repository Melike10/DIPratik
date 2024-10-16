﻿using DIPratik.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIPratik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly ITeacher _teacher;
        public ClassRoomController(ITeacher teacher)
        {
            _teacher = teacher;
        }
        [HttpGet]
        public IActionResult GetTeacher()
        {
            _teacher.GetInfo();

            return Ok();
        }
    }
}
