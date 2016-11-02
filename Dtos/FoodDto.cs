using System;

namespace AspNetWebapiCore.Dtos
{
    public class FoodDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public DateTime Created { get; set; }
    }
}
