/*Carro car = new Carro("9XWHE21JX24060831");

try
{
    Carro car = new Carro("9OPBHE21JX24060831");
    car.SetChassi("9OPBHE21JX24060831");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//testando commit no git e github novamente2
//editando pelo github
*/
/*try
{
    Carro c1 = new Carro("9OPBHE21JX24060831");
    Console.WriteLine(c1.SetChassi); 
    Carro carro = new Carro(1,"TOYOTA", "COROLA","HYA1694", "641561458", "9XWHE21JX24060831");

    Carro carro2 = new Carro(2,"TOYOTA", "COROLA","PP5PKS", "641561458", "9XWHE21JX24060831");
    Console.WriteLine(carro2.GetPlaca());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/

try
{
Funcionario f = new Funcionario("Hyago","hyago2158@gmail.com",19, "037.685.752-84");
    f.SetAnalisarCpf("037.685.752-84");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

/*try
{
    Funcionario f = new Funcionario("Hyago", 19, "037.685.752-84");
    Console.WriteLine($"O nome do funcionario é {f.GetNome()}, tem a idade de {f.GetIdade()} e seu cpf é: {f.GetCpf()}");


    Console.WriteLine("");

    Funcionario f2 = new Funcionario("Vilma", 55, "749.881.662-87");
    Console.WriteLine($"O nome do funcionario é {f2.GetNome()}, tem a idade de {f2.GetIdade()} e seu cpf é: {f2.GetCpf()}");

    Console.WriteLine("");

    Funcionario f3 = new Funcionario("Weslley", 17, "037.684.758-84");
    Console.WriteLine($"O nome do funcionario é {f2.GetNome()}, tem a idade de {f2.GetIdade()} e seu cpf é: {f2.GetCpf()}");

}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


/*try
{

    Funcionario f = new Funcionario();

    Console.WriteLine("Bem vindo a empresa!");

    int opc;
    do
    {
        Console.WriteLine("\nMenu inicial cadastro");
        Console.WriteLine("1 - Cadastrar funcionario");
        Console.WriteLine("2 - Cadastrar CPF do funcionario");
        Console.WriteLine("3 - Cadastrar idade do funcionario");
        Console.WriteLine("4 - Visualizar informações cadastrada do funcionario");
        Console.WriteLine("0 - SAIR ");
        Console.Write("\nEscolha sua opção: ");
        opc = Convert.ToInt32(Console.ReadLine());



        if (opc == 1)
        {
            Console.Write("Digite o nome do funcionario: ");
            string nome = Console.ReadLine();
            f.SetNome(nome);
        }
        else if (opc == 2)
        {
            Console.Write($"Digite o CPF do {f.GetNome()}: ");
            string cpf = Console.ReadLine();
            // Console.WriteLine($"\nCPF de {f.GetNome()} cadastrado com sucesso!");
            f.SetAnalisarCpf(cpf);
        }
        else if (opc == 3)
        {
            Console.Write($"\nDigite o idade do {f.GetNome()}: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"\n{f.GetNome()} tem {f.GetIdade()} anos , cadastrado com sucesso!");
            f.SetIdade(idade);
        }
        else if (opc == 4)
        {
            Console.WriteLine($"nome: {f.GetNome()}");
            Console.WriteLine($"idade: {f.GetIdade()}");
            Console.WriteLine($"cpf: {f.GetCpf()}");
        }
        else if (opc == 0)
        {
            Console.WriteLine("Encerrando o programa! ");
        }
        else
        {
            Console.WriteLine("Opção Invalida!");
        }

    } while (opc != 0);
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/
//123.456.789-09
//037.685.752-84