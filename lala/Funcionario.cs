public class Funcionario
{
    public string nome;
    public string email;
    private string cpf;
    public static double mediaSalarial;


    public Funcionario(string nome_, string email_, string fun_cpf)
    {
        nome = nome_;
        email = email_;
        cpf = fun_cpf;
        SetCpf(fun_cpf);
    }

    public void SetCpf(string fun_cpf)
    {
        Validar.SetAnalisarCpf(fun_cpf);
        cpf = fun_cpf;
    }
     
    public string GetCpf()
    {
        return cpf;
    }

}



