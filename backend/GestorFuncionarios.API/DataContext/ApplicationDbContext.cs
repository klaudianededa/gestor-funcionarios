using GestorFuncionarios.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GestorFuncionarios.API.DataContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<FuncionarioModel> Funcionarios { get; set; } //criar uma tabela com o nome funcionarios, com a estrutura do funcionariomodel
}