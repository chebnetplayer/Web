namespace proj.Models
{
    public class CarManagerSingleTone
    {
        private static readonly Carmanager _carmanager=new Carmanager();
        public static Carmanager Carmanager => _carmanager;
    }
}
