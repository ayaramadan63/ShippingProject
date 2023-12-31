﻿using Microsoft.EntityFrameworkCore;
using ShippingProject.Models;

namespace ShippingProject.Reposaitory
{

    public class BranchesRepo : IBranches
    {
        private readonly ShippingContext _shippingContext;

        public BranchesRepo(ShippingContext shippingContext)
        {
            _shippingContext = shippingContext;
        }
        public void Delete(string id)
        {
            var data = GetBranches(id);
            data.IsDeleted = true;
            Save();

        }

        public List<Branches> GetBranches()
        {
            return _shippingContext.Branches.Where(n=>n.IsDeleted==false).ToList();
        }

        public Branches GetBranches(string id)
        {
            return _shippingContext.Branches.FirstOrDefault(n=>n.Id==id);
        }

        public void Insert(Branches Branch)
        {
            _shippingContext.Branches.Add(Branch);
            Save();
        }

        public void Save()
        {
            _shippingContext.SaveChanges();
        }

        public void Update(string id, Branches Branch)
        {
            _shippingContext.Branches.Update(Branch);
            Save();
        }
    }
}
