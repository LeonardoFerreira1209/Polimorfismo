using Polimorfismo.Objetos.Interfaces;

namespace Polimorfismo.Objetos;

/// <summary>
/// Classe abstrata de Funcionario.
/// </summary>
public abstract class Funcionario
{
    /// <summary>
    /// Nome.
    /// </summary>
    public string Nome { get; set; }

    /// <summary>
    /// Cargo do funcionario.
    /// </summary>
    public string Cargo { get; set; }

    /// <summary>
    /// Salario hora.
    /// </summary>
    public decimal SalarioHora { get; set; }

    /// <summary>
    /// Valor de bonificação.
    /// </summary>
    public decimal Bonificacao { get; set; }

    /// <summary>
    /// Assinatura de função de calculo de sálario.
    /// </summary>
    /// <returns></returns>
    public abstract decimal CalcularSalario();

    /// <summary>
    /// Soma o salario mais a bonificacação.
    /// </summary>
    /// <returns></returns>
    public virtual decimal CalcularBonificacao()
    {
        return CalcularSalario() + Bonificacao;
    }
}
