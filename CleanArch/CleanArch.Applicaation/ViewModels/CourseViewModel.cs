using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Applicaation.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> courses { get; set; }
    }
}
