using System.Collections.Generic;
using System.Linq;

namespace MaturitaDatabaseEdit
{
    public class BikeRepository
    {
        private MyContext _database = new MyContext();

        public List<Bike> SelectAll()
        {
            return this._database.Bike.ToList();
        }

        public void Insert(Bike bike)
        {
            this._database.Bike.Add(bike);
            this._database.SaveChanges();
        }

        public void Delete(Bike bike)
        {
            this._database.Bike.Remove(bike);
            this._database.SaveChanges();
        }

        public Bike FindBike(int id)
        {
            return this._database.Bike.Find(id);
        }
    }
}
