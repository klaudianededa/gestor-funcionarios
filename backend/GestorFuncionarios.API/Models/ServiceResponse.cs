namespace GestorFuncionarios.API.Models;

public class ServiceResponse<T> //<T> pra poder receber qualquer tipo de objeto
{
    public T? Dados { get; set; }
    public string Mensagem { get; set; } = string.Empty;
    public bool Sucesso { get; set; } = true;
}