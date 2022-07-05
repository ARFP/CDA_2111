using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServerExample
{
    public class Car
    {
        public static List<Car> getCars()
        {
            return new List<Car>()
            {
                new Car() { Brand = "Ford", Model = "KA", Color = "rouge" },
                new Car() { Brand = "Porsche", Model = "Taican", Color = "Noir" },
                new Car() { Brand = "Fiat", Model = "Multipla", Color = "Jaune poussin" }
            };
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}
