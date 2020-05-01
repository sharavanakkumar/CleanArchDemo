using CleanArch.Applicaation.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Applicaation.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
