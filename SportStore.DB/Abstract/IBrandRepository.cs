using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStore.Domain.Entities;

namespace SportStore.DB.Abstract
{
    public interface IBrandRepository
    {
        IList<Brand> GetAll();
    }
}
