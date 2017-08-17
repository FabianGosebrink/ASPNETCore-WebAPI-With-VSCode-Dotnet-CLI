using System.Collections.Generic;
using DotnetcliWebApi.Entities;

namespace DotnetcliWebApi.Repositories
{
    public interface IFoodRepository
    {
        FoodItem GetSingle(int id);
        void Add(FoodItem item);
        void Delete(int id);
        FoodItem Update(int id, FoodItem item);
        ICollection<FoodItem> GetAll();
        int Count();

        bool Save();
    }
}
