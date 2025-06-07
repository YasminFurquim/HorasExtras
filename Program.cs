Console.Clear();


Console.WriteLine("--- Cálculo de Salário Mensal ---\n");


 Console.Write("Digite o valor do salário por hora (R$): ");
 decimal salarioHora = Convert.ToDecimal(Console.ReadLine());


 Console.Write("Digite o total de horas trabalhadas no mês: ");
 int horasTrabalhadasMes = Convert.ToInt32(Console.ReadLine());


 Console.Write("Digite o total de horas extras no mês: ");
 int horasExtrasMes = Convert.ToInt32(Console.ReadLine());


decimal salarioNormal = CalcularSalarioNormal(salarioHora, horasTrabalhadasMes);
decimal ganhoExtra = CalcularGanhoExtra(salarioHora, horasExtrasMes);

 Console.WriteLine("\nSalário referente às horas normais: R$ " + salarioNormal.ToString("N2"));

Console.WriteLine();
 Console.WriteLine("Valor ganho a mais com horas extras: R$ " + ganhoExtra.ToString("N2"));
    

static decimal CalcularSalarioNormal(decimal salarioHora, int horasNormais)

{
 return salarioHora * horasNormais;
}

static decimal CalcularGanhoExtra(decimal salarioHora, int horasExtras)


{
    decimal adicionalHoraExtra = salarioHora * 0.4m;

return (salarioHora + adicionalHoraExtra) * horasExtras - salarioHora * horasExtras;      
}