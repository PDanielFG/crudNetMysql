using crudMysqlNet;
using Microsoft.EntityFrameworkCore;


//Puente entre la tabla que creamos en la bd y la clase que creamos 
//Estas son las tablas que existen en mi modelo
//Mapea con la clase Ejemplo, que tiene los atributos y la estructura de la tabla
namespace ControlConjuntoServer.Server.Data
{
    public class ApplicationDbContext : DbContext       // :DbContext, indica que es una clase DbContext
    {
        //Constructor 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        //Referencia la tabla de la bd
        public DbSet<Ejemplo> Ejemplos { get; set; }



    }
}
