using Microsoft.EntityFrameworkCore;
using ShippingProject.DTO;
using ShippingProject.Models;

namespace ShippingProject.Reposaitory
{
    public class TraderRepository : ITraderRepository
    {

        ShippingContext db;
        public TraderRepository(ShippingContext db)
        {
            this.db = db;
        }

        public void Add(Trader trader)
        {
            db.Traders.Add(trader);
            Save();
        }

      

        public List<GetAllTraderViewModel> GetAll()
        {
            return db.Traders.Include(x => x.city).Include(x => x.Governates).Include(x => x.branches)
                .Select(t => new GetAllTraderViewModel() { 
                  ID= t.ID,
                Name = t.Name,
                Address = t.Address,
                Branch_Name = t.branches.Name,
                City_Name = t.city.Name,
                Governate_Name = t.Governates.Name,
                Email = t.Email,
                Password = t.Password,
                Per_Rejected_order = t.Per_Rejected_order,
                Phone = t.Phone,
                IsDeleted= t.IsDeleted,
                Id_Branch= t.Id_Branch,
                Id_Governate= t.Id_Governate,
                Id_City = t.Id_City,
                }).ToList();
        }

        public Trader GetById(string Id)
        {
            var res = db.Traders.Include(x => x.city).Include(x => x.Governates).Include(x => x.branches)
                .Where(t => t.ID == Id)
                .Select(t => new Trader
                {
                    Name = t.Name,
                    Address = t.Address,
                    ID = t.ID,
                    Email = t.Email,
                    Password = t.Password,
                    Per_Rejected_order = t.Per_Rejected_order,
                    Phone = t.Phone,
                    IsDeleted = t.IsDeleted,
                    Id_Branch = t.Id_Branch,
                    Id_Governate = t.Id_Governate,
                    Id_City = t.Id_City,

                }).FirstOrDefault();
            return res;
        }
        public void Save()
        {
            db.SaveChanges();
        }


        //public void Delete(string Id)
        //{
        //    var deletedItem = GetById(Id);
        //    deletedItem.IsDeleted = true;
        //    Save();

        //}

        //public void Update(UpdateTraderViewModel trader)
        //{
        //    var traderbyid = GetById(trader.Id);
        //    traderbyid.Address = trader.Address;
        //    traderbyid.Email = trader.Email;
        //    traderbyid.Per_Rejected_order = trader.Per_Rejected_order;
        //    traderbyid.Id_Branch = trader.Id_Branch;
        //    traderbyid.Id_Governate = trader.Id_Governate;
        //    traderbyid.Id_City = trader.Id_City;
        //    traderbyid.Password = trader.Password;
        //    traderbyid.Phone = trader.Phone;


        //    //db.Traders.Update(traderbyid);
        //    Save();
        //}

        public void Update(string id, Trader trader )
        {


           var exitstingdata = db.Traders.Local.FirstOrDefault(e => e.ID == id);

            if (exitstingdata != null)

            {

                db.Entry(exitstingdata).State = EntityState.Detached;

            }


            db.Traders.Update(trader);
            Save();
        }


    }
}
