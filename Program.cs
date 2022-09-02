static void p1001(){
    int a, b, x;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    x = a + b;
    Console.Write("X = {0}\n", x);
}

static void p1002(){
    double area, raio;
    raio = Convert.ToDouble( Console.ReadLine() );
    //  area = 3.14159 * (raio * raio);
    area = 3.14159 * Math.Pow(raio, 2.0);
    Console.Write("A={1}, raio={0}\n", area.ToString("0.0000"), raio);
}
  
static void p1003(){
    int a, b, soma;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    soma = a + b;
    Console.Write("SOMA = {0}\n", soma);
}

static void p1005(){
    double a, b, media;

    a = Convert.ToDouble(Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());
    media = (a*3.5 + b*7.5) / ( 3.5 + 7.5 );
    Console.Write("MEDIA = {0}\n", media.ToString("0.00000"));
}
    int prog;
    Console.Clear();

    do{
        Console.Write("\nGerenciador de programas:\n");
        Console.Write("\n\t| 0 para sair |\nDigite o programa desejado: ");
        prog = Convert.ToInt32(Console.ReadLine());

        switch( prog ){
            case 1001:  p1001();    break;
            case 1002:  p1002();    break;
            case 1003:  p1003();    break;
            case 1005:  p1005();    break;
            case 0:     Console.Write("\nObrigado por utilizar nosso Software\n");    break;
            default:    Console.Write("\nOpção Inválida\n");    break;            
        }
    }while( prog != 0 ); 
       
    

    