public class Funcionario
{
    public string nome;
    public string email;
    private string cpfun;

    public Funcionario(string nome_, string email_, string cpf_)
    {
        nome = nome_;
        email = email_;
        cpfun = cpf_;
        SetAnalisarCpf(cpf_);
    }
    public void SetAnalisarCpf(string cpf)
    {

        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        if (cpf.Length == 11)
        {
            int soma1 = 0;
            int multiplicar = 10;
            int resto;
            int digito;


            for (int i = 0; i < 9; i++)
            {
                soma1 += (cpf[i] - '0') * multiplicar;  // Converte char para int eficientemente
                multiplicar--;  // diminuir para próximo 9 8 7 6...
            }

        resto = soma1 % 11;

            //calcular  digito

            if (resto < 2)
            {
                digito = 0;
            }
            else 
            {
                digito = 11 - resto;
            }
            if (digito != (cpf[9] - '0'))
                throw new Exception("CPF inválido!");
        }
        int soma2 = 0;
        int multiplicar2 = 11;
        int resto2;
        int digito2;
        for ( int i = 0; i <10; i++)
        {
            soma2 += (cpf[i] - '0') * multiplicar2;  // Converte char para int eficientemente
            multiplicar2--;  // diminuir para próximo 9 8 7 6...
        }
        resto2 = soma2 % 11;

        //calcular o segundo digito
        if(resto2 < 2)
        {
            digito2 = 0;
        }
        else
        {
            digito2 = 11 - resto2;
        }
        if (digito2 != (cpf[10] - '0'))
            throw new Exception("CPF inválido!");

        cpfun = cpf;
    }
}