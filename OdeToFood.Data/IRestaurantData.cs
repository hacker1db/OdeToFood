using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
{   
   readonly List<Restaurant> restaurants;
    public InMemoryRestaurantData()
    {
        restaurants = new List<Restaurant>();
        new Restaurant { Id = 1, Name = "Davids Indian Food", Location="Oregon", Cuisine=CuisineType.Indian};
        new Restaurant { Id = 2, Name = "Davids Pizza", Location="Seattle", Cuisine=CuisineType.Italian};
        new Restaurant { Id = 3, Name = "Davids Mexican Food", Location="Hawaii", Cuisine=CuisineType.Mexican};
        

    }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                orderby r.Name
                select r;
        }
    }

}

