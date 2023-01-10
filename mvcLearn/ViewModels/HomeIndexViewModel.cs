using System;
using System.Collections.Generic;
using mvcLearn.Models;

namespace mvcLearn.ViewModels
{
	public class HomeIndexViewModel
	{

		public IEnumerable<Restaurant> Restaurent { get; set; }
		public string CurrentMessage { get; set; }
	}
}

