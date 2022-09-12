using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category : Entity 
    {
        public ICollection<Product> Products { get; private set; }


        public Category(string name)
        {
            ValidateDomain(name);
            Id = new Random().Next(100, 100000);
        }

        public void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name.Name is Required");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name , too short , minimum 3 characters");

            Name = name; 
        }
    }
}
