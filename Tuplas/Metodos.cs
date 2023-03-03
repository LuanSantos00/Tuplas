public sealed class Metodos
{
    public static void MonteSeuNome((string primeiroNome, string segundoNome) nome)
        => Console.WriteLine($"{nome.primeiroNome} {nome.segundoNome}");
}
