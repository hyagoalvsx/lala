public class Funcionario
{
    public string nome;
    public string email;
    private string cpf;

    public Funcionario(string nome_, string email_, string cpf_)
    {
        nome = nome_;
        email = email_;
        cpf = cpf_;
    }
    public void SetAnalisarCpf(string cpf)
    {



        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        if (cpf.Length == 11)
        {
            int digito = 0;
            int valoresDigito = 10;
            int soma = 0 ;
            int resto = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * valoresDigito --;
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else if (resto >=2)
            {
                digito = 11 - resto;
                throw new Exception("CPF inválido!");
            }
            cpf =  cpf + resto.ToString();
        }
    }
}