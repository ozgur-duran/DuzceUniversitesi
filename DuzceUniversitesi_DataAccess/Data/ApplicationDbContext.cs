using DuzceUniversitesi_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuzceUniversitesi_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options ) :base (options)
        {

        }

        public DbSet<Fakulte>Fakulteler { get; set; }
        public DbSet<AkademikPersonel>AkademikPersoneller{ get; set; }
        public DbSet<Duyuru>Duyurular{ get; set; }
        public DbSet<Admin>Adminler { get; set; }

    }
}
