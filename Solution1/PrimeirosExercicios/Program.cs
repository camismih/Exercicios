namespace PrimeirosExercicios;

class Program
{
    /*public static double Somar(double num1, double num2) => num1 + num2;
    public static double Subtrair(double num1, double num2) => num1 - num2;
    public static double Multiplicar(double num1, double num2) => num1 * num2;
    public static double Dividir(double num1, double num2)
    {
        if(num2 == 0)
        {
            Console.WriteLine("Erro!! divisão por zero não é permitida!");
            return 0;
        }
else
        {
            return num1 / num2;
        }
    }
    public static double Media(double num1, double num2)
    {
        double soma = Somar(num1, num2);
        return Dividir(soma, 2);
    }*/
    static void Main()
    {
        /*Console.WriteLine("Digite seu nome");
        var nome = Console.ReadLine();
        Console.WriteLine($"Seja bem-vindo/A! {nome}"); */
        /*var nome = "Vince";
        var sobreNome = "Vancinni";
        Console.WriteLine($"Perdeu a memória, foi? Seu Nome é: {nome} E seu sobrenome é {sobreNome}");*/
        /*Console.WriteLine("--- Calculadora Simples ---");
        Console.Write("Por favor, digite o primeiro número");
        double valor1 = double.Parse(Console.ReadLine());
        Console.Write("Agora, digite o segundo número: ");
        double valor2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nAnalisando os números {valor1} e {valor2}");
        Console.WriteLine("-------------------------------------");
        double resultadoSoma = Somar(valor1, valor2); 
        double resultadoSubtracao = Subtrair(valor1, valor2);
        double resultadoMultiplicacao = Multiplicar(valor1, valor2);
        double resultadoDivisao = Dividir(valor1, valor2);
        double resultadoMedia = Media(valor1, valor2);
        Console.WriteLine($"Soma: {resultadoSoma}");
        Console.WriteLine($"Subtração: {resultadoSubtracao}");
        Console.WriteLine($"Multiplicação: {resultadoMultiplicacao}");
        Console.WriteLine($"Divisão: {resultadoDivisao}");
        Console.WriteLine($"Média: {resultadoMedia}");*/
        Console.WriteLine("--- Contador de Caracteres ---");
        Console.Write("Por favor, digite uma frase ou palavra: ");
        var textoDigitado = Console.ReadLine();
        var textoSemEspaços = textoDigitado.Replace(" ", "");
        int quantidadeCaracteres = textoSemEspaços.Length;
        Console.WriteLine($"\nA quantidade de caracteres digitados foi: {quantidadeCaracteres}");
    }
}