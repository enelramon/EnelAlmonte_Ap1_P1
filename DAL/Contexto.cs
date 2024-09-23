using EnelAlmonte_Ap1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace EnelAlmonte_Ap1_P1.DAL;

public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
{
    public DbSet<Registros> Registros { get; set; }
}
