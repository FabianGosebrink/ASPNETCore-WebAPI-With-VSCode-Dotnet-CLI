using System;

namespace DotnetcliWebApi.Dtos
{
    public class FoodItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public DateTime Created { get; set; }
    }
}
