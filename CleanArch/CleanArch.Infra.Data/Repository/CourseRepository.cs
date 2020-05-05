﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private MyDBContext _ctx;

        public CourseRepository(MyDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Course course)
        {
            _ctx.courses.Add(course);
            _ctx.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.courses;
        }
    }
}
