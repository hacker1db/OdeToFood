using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {

        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }

    public class InMemoryRestaurantData : IRestaurantData
{   
   List<Restaurant> restaurants;
    public InMemoryRestaurantData()
    {
        restaurants = new List<Restaurant>()
        // remmber add , at end of each of new item in the list otherwise stuff wont display!
        {
        new Restaurant { Id = 1, Name = "Davids Indian Food", Location="Oregon", Cuisine=CuisineType.Indian},
        new Restaurant { Id = 2, Name = "Davids Pizza", Location="Seattle", Cuisine=CuisineType.Italian},
        new Restaurant { Id = 3, Name = "Davids Mexican Food", Location="Hawaii", Cuisine=CuisineType.Mexican},
        };
    }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null )
        {
            return from r in restaurants
            where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
            orderby r.Name
            select r;
        }
    }

}

