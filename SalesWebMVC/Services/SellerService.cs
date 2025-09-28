﻿using SalesWEBMvc.Models;
using SalesWEBMVC.Models;
using SalesWEBMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing.Tree;
using SalesWEBMvc.Services.Exceptions;
namespace SalesWEBMvc.Services
{
    public class SellerService
    {
        private readonly SalesWEBMVCContext _context;

        public SellerService(SalesWEBMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() // lista todos os seller
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj) // Recebe um seller para inserção
        {
          //  obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if(!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id não existe");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException ex)
            {
                throw new DbConcurrencyException(ex.Message);
            }
        }



    }
}
