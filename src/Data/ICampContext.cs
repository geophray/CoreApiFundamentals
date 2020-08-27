using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public interface ICampContext : IDisposable
    {
        DbSet<Camp> Camps { get; set; }
        int SaveChanges();
        void MarkAsModified(Camp camp);
    }
}
