using System;
using System.Collections.Generic;
using System.Linq;
using mvcLearn.Models;

namespace mvcLearn.Services
{
	public class InMemoryRestaurantData : IRestaurantData
	{
		public InMemoryRestaurantData()
		{
			_restaurant = new List<Restaurant>
			{
				new Restaurant {
					Id = 1,
					Name = "Pizza"
				},
				new Restaurant {
					Id = 2,
					Name = "Burger"
				}

			};


        }

        public IEnumerable<Restaurant> GetAll()
        {
			return _restaurant.OrderBy(r => r.Name);
        }

        List<Restaurant> _restaurant;
    }
}

