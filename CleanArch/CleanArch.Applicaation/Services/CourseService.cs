﻿using CleanArch.Applicaation.Interfaces;
using CleanArch.Applicaation.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Applicaation.Services
{
    public class CourseService:ICourseService
    {
        private ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;


        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                courseViewModel.Name,
                courseViewModel.Description,
                courseViewModel.ImageUrl                
                );
            _bus.SendCommand(createCourseCommand);
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
