using Polimorfismo.Objetos.Interfaces;

namespace Polimorfismo.Objetos;

/// <summary>
/// Objeto que representa um Gerente.
/// </summary>
public class Gerente : Funcionario, IFerias
{
    public Gerente(
        string nome,
        decimal salarioHora
        )
    {
        Nome = nome;
        Cargo = "Gerente";
        SalarioHora = salarioHora;
    }

    /// <summary>
    /// Calculo de sálario mais bonus.
    /// </summary>
    /// <returns></returns>
    public override decimal CalcularSalario()
        => SalarioHora * 168 + 500;

    /// <summary>
    /// Sobrescreve o método de calculo de bonificação.
    /// </summary>
    /// <returns></returns>
    public override decimal CalcularBonificacao()
    {
        return base.CalcularBonificacao() * 2;
    }

    /// <summary>
    /// Reotorna quantos dias de ferias.
    /// </summary>
    /// <returns></returns>
    public string DiasDeFerias()
    {
        return $"O {nameof(Gerente)} tem 30 dia de férias.";
    }
}
