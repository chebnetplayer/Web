using System.Collections.Generic;
using System.Linq;

namespace proj.Models
{
    public class Carmanager
    {

        public int count => Cars.Count;
        public List<Car> Cars=new List<Car>();

        public void Add(Car car)
        {
            Cars.Add(car);
        }

        public Car GetCarById(int id)
        {
            return Cars.SingleOrDefault(i => i.Id == id);
        }

        public void ChangePrice(int carId, int newPrice)
        {
            Cars.First(i => i.Id==carId).Price = newPrice;
        }
           
    }
}
