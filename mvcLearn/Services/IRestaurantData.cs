using System;
using System.Collections.Generic;
using mvcLearn.Models;

namespace mvcLearn.Services
{

    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

}

