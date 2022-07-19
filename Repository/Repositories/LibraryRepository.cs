﻿using Domain.Models;
using Repository.Data;
using Repository.Repositories.Exceptoin;
using Repository.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class LibraryRepository : IRepository<Library>
    {
        public void Create(Library data)
        {
            try
            {
                if (data is null) throw new NotFoundException("Data Not Found");

                AppDbContext<Library>.datas.Add(data);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(Library data)
        {
            throw new NotImplementedException();
        }

        public Library Get(Predicate<Library> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll(Predicate<Library> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Library data)
        {
            throw new NotImplementedException();
        }
    }
}
