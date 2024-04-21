float salary = 0, increase = 0;
int restart = 0;

do
{
    Console.Clear();
    Console.WriteLine("ESTE PROGRAMA IRÁ MOSTRAR A PORCENTAGEM DE AUMENTO DO SALARIO INFORMADO");
    Console.Write("Qual o antigo salário? \nR$");
    salary = int.Parse(Console.ReadLine());

    do
    {
        Console.WriteLine();
        Console.Write("Qual o salário atual com aumento? \nR$");
        increase = int.Parse(Console.ReadLine());
        
        if (increase < salary)
        {
            Console.WriteLine("O salário com o aumento, precisa ser maior que o antigo salário.");
        }

        Console.WriteLine($"O aumento é de {Math.Round(((increase / salary) * 100) - 100)}%");
    } while (increase < salary);

    Console.WriteLine("deseja realizar um novo cálculo?");
    Console.WriteLine("1 - SIM");
    Console.WriteLine("2 - NÃO");
    restart = int.Parse(Console.ReadLine());
} while (restart == 1);