using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IRentalService rentalService = new RentalManager(new EfRentalDal());
            Console.WriteLine(rentalService.Add(new Rental { CarId = 8, CustomerId = 12, RentalId = 6, RentDate = new DateTime(2021, 02, 20), ReturnDate = new DateTime(2021, 02, 25) }).Message);
 
        }
    }
}
