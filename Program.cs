// Comentário = escreva o que necessitar.
// Variável = espaço reservado na memória do computador.

//  inteiro = int
//  real    = double ou decimal
double salario, dia;

dia = 10;

//  Para escrever na tela = Console.Write("Texto");
Console.Write("Digite o salario: ");

//  Para ler um valor = Console.ReadLine();
salario = Convert.ToDouble( Console.ReadLine() ) ;

Console.Write("O salario digitado é = R$ {1}, vou receber no dia {0}", dia, salario.ToString("0.00"));

