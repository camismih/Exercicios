namespace PrimeirosExercicios;
using System.Globalization;

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

    /*public static bool ValidarPlaca(string placa)
    {
        if (string.IsNullOrEmpty(placa)) { return false; }
       placa = placa.ToUpper();
        if (placa.Length != 7) { return false; }
        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i])) { return false; }
        }
        for(int i = 3; i <7; i++)
        {
            if (!char.IsDigit(placa[i])){ return false; }
        }
        return true;

    } */
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
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
        /*Console.WriteLine("--- Contador de Caracteres ---");
        Console.Write("Por favor, digite uma frase ou palavra: ");
        var textoDigitado = Console.ReadLine();
        var textoSemEspaços = textoDigitado.Replace(" ", "");
        int quantidadeCaracteres = textoSemEspaços.Length;
        Console.WriteLine($"\nA quantidade de caracteres digitados foi: {quantidadeCaracteres}");*/

        /*Console.WriteLine("--- Validador de Placa Veicular (Padrão Antigo) ---");
        Console.Write("Digite a placa (ex: ABC1234): ");
        var placaDigitada = Console.ReadLine();
        if(ValidarPlaca(placaDigitada))
        {
            Console.WriteLine("\nA placa é VÁLIDA!");
        }
        else
        {
            {
                Console.WriteLine("\nA placa é INVÁLIDA!");
            }
        }*/
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine("--- Exibindo a Data Atual em Vários Formatos ---");
        string formatoCompleto = dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, 'as' hh:mm:ss");
        Console.WriteLine($"\n1. Formato completo: {formatoCompleto}");
        string formatoDataNumerica = dataAtual.ToString("dd/MM/yyyy");
        Console.WriteLine($"2. Apenas a data: {formatoDataNumerica}");
        string formatoHora24 = dataAtual.ToString("HH:mm:ss");
        Console.WriteLine($"3. Apenas a hora (24h): {formatoHora24}");
        string formatoMesExtenso = dataAtual.ToString("dd 'de' MMMM 'de' yyyy");
        Console.WriteLine($"4. Data com mês por extenso: {formatoMesExtenso}");
    }
}