public class Funcionario
{
    private string nome;
    private string email;
    private int idade;
    private string cpf;

    public Funcionario(string nome_, string email_, int idade_, string cpf_)
    {
        SetNome(nome_);
        SetEmail(email_);
        SetIdade(idade_);
        SetAnalisarCpf(cpf_);
       
    }

    public void SetNome(string nomeFun)
    {
        nome = nomeFun;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetEmail(string emailFun)
    { 
        email = emailFun;
    }

    public string GetEmail()
    { 
     return email;
    }
    public void SetIdade(int idadeFun)
    {
        idade = idadeFun;
    }

    public int GetIdade()
    {
        return idade;
    }

    public void SetAnalisarCpf(string fun_cpf)
    {
        fun_cpf = fun_cpf.Replace(".", "");
        fun_cpf = fun_cpf.Replace("-", "");

        int soma1 = 0;
        int multiplica1 = 10;
        int resto;
        int digito;

        if (fun_cpf.Length != 11)
            throw new Exception("CPF deve ter 11 dígitos!");


        for (int i = 0; i < 9; i++)

        {
            int numero = int.Parse(fun_cpf[i].ToString());
            soma1 += numero * multiplica1;
            multiplica1--;

        }
        resto = soma1 % 11;

        if (resto < 2)
        {
            digito = 0;
        }
        else
        {
            digito = 11 - resto;
        }
        if (digito != int.Parse(fun_cpf[9].ToString()))
            throw new Exception("CPF inválido!");

        int soma2 = 0;
        int multiplica2 = 11;
        int resto2;
        int digito2;

        for (int i = 0; i < 10; i++)
        {
            int numero2 = int.Parse(fun_cpf[i].ToString());
            soma2 += numero2 * multiplica2;
            multiplica2--;
        }
        resto2 = soma2 % 11;

        if (resto2 < 2)
        {
            digito2 = 0;
        }
        else
        {
            digito2 = 11 - resto2;
        }
        if (digito2 != int.Parse(fun_cpf[10].ToString()))
            throw new Exception("CPF inválido!");

        cpf = fun_cpf;

    }

    public string GetCpf()
    {
        return cpf;
    }

}
