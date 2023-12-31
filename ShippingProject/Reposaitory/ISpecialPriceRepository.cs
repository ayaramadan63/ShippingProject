﻿using ShippingProject.DTO;
using ShippingProject.Models;

namespace ShippingProject.Reposaitory
{
    public interface ISpecialPriceRepository
    {

        List<Special_Price_Trader> GetAll();
        Special_Price_Trader GetById(string Id);
        void Add(Special_Price_Trader sp);
        void Update(string id, UpdateSpecialViewModel sp);
        void Delete(string Id);
        void Save();
    }
}
