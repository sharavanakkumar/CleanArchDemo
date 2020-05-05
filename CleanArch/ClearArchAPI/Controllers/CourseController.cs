using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Applicaation.Interfaces;
using CleanArch.Applicaation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ClearArchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        private CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel courseViewModel)
        {
            return Ok(courseViewModel);
        }
    }
}
