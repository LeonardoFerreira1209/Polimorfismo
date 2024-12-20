using Polimorfismo.Objetos;

var vendedor = new Vendedor(
    "Lucas", 60
);

vendedor.Bonificacao = 3000;

Console.WriteLine(
    $"Instância criada vendedor: {vendedor.Nome}, Sálario mensal: {vendedor.CalcularSalario():N2}, Calculo com a Bonificacao {vendedor.CalcularBonificacao():N2}"
);

Console.WriteLine(vendedor.DiasDeFerias());

var gerente = new Gerente(
    "Diego", 100
);

gerente.Bonificacao = 5000;

Console.WriteLine(
    $"Instância criada gerente: {gerente.Nome}, Sálario mensal: {gerente.CalcularSalario():N2}, Calculo com a Bonificacao {gerente.CalcularBonificacao():N2}"
);

Console.WriteLine(gerente.DiasDeFerias());