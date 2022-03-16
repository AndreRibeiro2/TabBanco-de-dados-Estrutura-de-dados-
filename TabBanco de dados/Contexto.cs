using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TabBanco_de_dados.Entidades;

namespace TabBanco_de_dados
{
    public class Contexto : DbContext
    {
        public Contexto (DbContextOptions<Contexto> option) : base(option) { } 

        public DbSet <usuario> USUARIOS { get; set; }
    }
}
