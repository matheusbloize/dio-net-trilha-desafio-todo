using Microsoft.EntityFrameworkCore;
using DIO_NET_TODO_ENTITY.Models;

namespace DIO_NET_TODO_ENTITY.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}