namespace proj.Models
{
    public class Car
    {
        public Car(int id,string name,int price)
        {
            Name = name;
            Price = price;
            Id = id;
        }
        public string Name;
        public int Price;
        public int Id;

    }
}
