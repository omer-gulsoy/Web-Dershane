﻿using data.Concrate;
using entity.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
	public class HomeController : Controller
	{
		Context Context = new Context();
		public IActionResult Index()
		{
			ViewBag.Blog = Context.Blogs.ToList();
			ViewBag.Testimonial = Context.Testimonials.ToList();
			ViewBag.Teacher = Context.Teachers.ToList();
			ViewBag.Lesson=Context.Lessons.ToList();
			return View();
		}
	}
}
