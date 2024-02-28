using Microsoft.EntityFrameworkCore;
using ServiceOffre.Entities;

namespace ServiceOffre
{
    public class ServiceOffreDbContext : DbContext/*Heriter a partir DbContext*/
    {
        //Surchager le constructeur par defaut du DbContext
        public ServiceOffreDbContext(DbContextOptions<ServiceOffreDbContext> options) : base(options)
        {
            
        }

        public DbSet<Offre> Offre { get; set; } //représente une table dans la base donnée

    }
}
