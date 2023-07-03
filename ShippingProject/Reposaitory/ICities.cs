using ShippingProject.Models;

namespace ShippingProject.Reposaitory
{
    public interface ICities
    {
        List<Cities> GetCities();
        Cities GetCities(string id);

        void Insert(Cities city);
        void Update(string id, Cities City);
        void Delete(string id);
        void Save();
    }
}
