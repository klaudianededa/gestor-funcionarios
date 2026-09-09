using System.Text.Json.Serialization;

namespace GestorFuncionarios.API.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DepartamentoEnum
{
    RH,
    Financeiro,
    Compras,
    Atendimento,
    Zeladoria
}