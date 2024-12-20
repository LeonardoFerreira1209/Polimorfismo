using Polimorfismo.Objetos.Interfaces;

namespace Polimorfismo.Objetos;

/// <summary>
/// Objeto que representa um Vendedor.
/// </summary>
public class Vendedor : Funcionario, IFerias
{
    public Vendedor(
        string nome,
        decimal salarioHora
        )
    {
        Nome = nome;
        Cargo = "Vendedor";
        SalarioHora = salarioHora;
    }

    /// <summary>
    /// Calculo de sálario.
    /// </summary>
    /// <returns></returns>
    public override decimal CalcularSalario()
        => SalarioHora * 168;

    /// <summary>
    /// Reotorna quantos dias de ferias.
    /// </summary>
    /// <returns></returns>
    public string DiasDeFerias()
    {
        return $"O {nameof(Vendedor)} tem 15 dia de férias.";
    }
}
