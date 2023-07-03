using Microsoft.EntityFrameworkCore;
using ShippingProject.Models;

namespace ShippingProject.Reposaitory
{
    public class CitiesReposaitory : ICities
    {
        private readonly ShippingContext _shippingContext;

        public CitiesReposaitory(ShippingContext shippingContext)
        {
            _shippingContext = shippingContext;
        }
        public void Delete(string id)
        {
            var data = GetCities(id);
            data.IsDeleted = true;
            Save();

        }

        public List<Cities> GetCities()
        {
            return _shippingContext.Cities.Where(n => n.IsDeleted == false).ToList();
        }

        public Cities GetCities(string id)
        {
            return _shippingContext.Cities.FirstOrDefault(n => n.Id == id);
        }

        public void Insert(Cities City)
        {
            _shippingContext.Cities.Add(City);
            Save();
        }

        public void Save()
        {
            _shippingContext.SaveChanges();
        }

        public void Update(string id, Cities City)
        {
            _shippingContext.Cities.Update(City);
            Save();
        }
    }
}
