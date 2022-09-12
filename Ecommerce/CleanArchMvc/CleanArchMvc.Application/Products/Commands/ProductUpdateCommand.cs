using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Commands
{
    public class ProductUpdateCommand : ProductCreateCommand
    {
        public int Id { get; set; }

        public ProductUpdateCommand(int id)
        {
            Id = id;
        }
    }
}
