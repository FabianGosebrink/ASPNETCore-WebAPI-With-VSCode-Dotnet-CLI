using System.Collections.Generic;
using DotnetcliWebApi.Entities;
using DotnetcliWebApi.Models;

namespace DotnetcliWebApi.Repositories
{
    public interface IFoodRepository
    {
        FoodItem GetSingle(int id);
        void Add(FoodItem item);
        void Delete(int id);
        FoodItem Update(int id, FoodItem item);
        ICollection<FoodItem> GetAll(QueryParameters queryParameters);
        int Count();

        bool Save();
    }
}
