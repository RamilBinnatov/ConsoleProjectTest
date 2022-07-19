using System;


namespace Repository.Repositories.Exceptoin
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }
    }
}
