﻿using ShippingProject.Models;

namespace ShippingProject.Reposaitory
{
    public interface IBranches
    {
        List<Branches> GetBranches();
        Branches GetBranches(string id);

        void Insert(Branches Branch);
        void Update(string id, Branches Branch);
        void Delete(string id);
        void Save();
    }
}
