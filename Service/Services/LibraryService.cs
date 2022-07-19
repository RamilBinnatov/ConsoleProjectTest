using Domain.Models;
using Repository.Repositories;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    class LibraryService : ILibraryService
    {
        private LibraryRepository _libraryRepository;
        private int _count;
        public LibraryService()
        {
            _libraryRepository = new LibraryRepository();
        }
        public Library Create(Library library)
        {
            library.Id = _count;
            _libraryRepository.Create(library);
            _count++;
            return library;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public Library GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Library Update(int id, Library library)
        {
            throw new NotImplementedException();
        }
    }
}
