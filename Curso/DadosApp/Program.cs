using System;

public class DadosApp
{
    static void Main(string[] args)
    {
        Dados(); 
    }

    public static void Dados()
    {
        //Variaveis de campo

        long cpf = 0;
        DateTime data;
        float renda;
        char estadocivil;
        int dependentes;

        string? strnome;
        string? strcpf;
        string? strdata;
        string? strrenda;
        string? strestadocivil;
        string? strdependentes;

        //ler nome
        do
        {
            Console.Write("Insira seu nome: ");
            strnome = Console.ReadLine();
            if (strnome != null && strnome != "" && strnome.Length >= 5)
            {
                break;
            }
            Console.WriteLine("Nome deve ter no minimo 5 caracteres");
            Console.WriteLine(" ");
        } while (true);


        //ler cpf
        do
        {
            Console.Write("Digite o cpf (11 digitos): ");
            strcpf = Console.ReadLine();
            if (strcpf != null && strcpf != "" && strcpf.Length == 11)
            {
                if (!long.TryParse(strcpf, out cpf))
                {
                    Console.WriteLine("Cpf invalido");
                    continue;
                }

                break;
            }
            Console.WriteLine("Cpf deve ter 11 digitos");
            Console.WriteLine(" ");
        } while (true);


        //ler data
        while (true)
        {
            Console.Write("Digite a data de nascimento (DD/MM/AAAA) : ");
            strdata = Console.ReadLine();
            if (strdata == null || strdata == "")
            {
                Console.WriteLine("Data nao pode ser vazia");
                continue;
            }
            if (!DateTime.TryParse(strdata, out data))
            {
                Console.WriteLine("Data informada invalida");
                continue;
            }

            DateTime hoje = DateTime.Now;
            if ((hoje.Year - data.Year) < 18)
            {
                Console.WriteLine("Usuario menor de 18 anos");
                continue;
            }
            break;
        }

        //ler renda
        while (true)
        {
            Console.Write("Digite sua renda: ");
            strrenda = Console.ReadLine();
            if (strrenda == null || strrenda == "")
            {
                Console.WriteLine("Valor de renda nao pode estar vazio");
                continue;
            }
            if (!float.TryParse(strrenda, out renda))
            {
                Console.WriteLine("Valor de renda invalido");
                continue;
            }
            break;
        }

        //ler estado civil
        while (true)
        {
            Console.Write("Estado Civil ( C / S / V / D): ");
            strestadocivil = Console.ReadLine();
            if (strestadocivil == null || strestadocivil == "")
            {
                Console.WriteLine("Estado Civil nao pode estar vazio");
                continue;
            }
            if (strestadocivil.Length > 1 ||
                (strestadocivil.ToLower() != "c" &&
                strestadocivil.ToLower() != "s" &&
                strestadocivil.ToLower() != "v" &&
                strestadocivil.ToLower() != "d"))
            {
                Console.WriteLine("Estado Civil invalido");
                continue;
            }
            estadocivil = char.Parse(strestadocivil);
            break;
        }

        //ler dependentes
        while (true)
        {
            Console.Write("Digite o numero de dependentes (Entre 0 e 10): ");
            strdependentes = Console.ReadLine();
            if (strdependentes == null || strdependentes == "")
            {
                Console.WriteLine("Dependentes nao pode estar vazio");
                continue;
            }
            if (!int.TryParse(strdependentes, out dependentes))
            {
                Console.WriteLine("Valor de dependentes invalido");
                continue;
            }
            break;
        }

        //exibição
        Console.Clear();
        Console.WriteLine("Nome: " + strnome);
        Console.WriteLine("CPF: " + cpf.ToString("F0"));
        Console.WriteLine("Data de nascimento: " + data.ToShortDateString());
        Console.WriteLine("Renda mensal: " + renda.ToString("C2"));
        Console.WriteLine("Estado civil: " + estadocivil);
        Console.WriteLine("Dependentes: " + dependentes.ToString());
        Console.WriteLine("");
    }
}