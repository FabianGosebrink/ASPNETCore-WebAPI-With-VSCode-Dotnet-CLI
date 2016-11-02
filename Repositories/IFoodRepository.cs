using System.Collections.Generic;
using AspNetWebapiCore.Models;

namespace AspNetWebapiCore.Repositories
{
    public interface IFoodRepository
    {
        FoodItem GetSingle(int id);
        FoodItem Add(FoodItem item);
        void Delete(int id);
        FoodItem Update(int id, FoodItem item);
        ICollection<FoodItem> GetAll();
        int Count();
    }
}
