// See https://aka.ms/new-console-template for more information
Console.WriteLine("Piramide");

try
{
    PiramideApp.Piramide piramide = new PiramideApp.Piramide(9);
    piramide.Desenha();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
