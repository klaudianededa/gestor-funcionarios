using GestorFuncionarios.API.DataContext;
using GestorFuncionarios.API.Models;

namespace GestorFuncionarios.API.Service.FuncionarioService;

public class FuncionarioService : IFuncionarioInterface
{
    private readonly ApplicationDbContext _context;
    public FuncionarioService(ApplicationDbContext context)
    {
        _context = context;
    }
    public Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios()
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
    {
        throw new NotImplementedException();
    }
}
