using CleanArch.Applicaation.Interfaces;
using CleanArch.Applicaation.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Applicaation.Services
{
    public class CourseService:ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                courses = _courseRepository.GetCourses()
            };
        }
    }
}
