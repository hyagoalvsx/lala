public class Funcionario: Pessoa
{
    private string cpf;
    public static double mediaSalarial;


    public Funcionario(string nome_, string email_, string fun_cpf)
    {
        nome = nome_;
        email = email_;
        SetAnalisarCpf(fun_cpf);
    }


    public void SetAnalisarCpf(string fun_cpf)
    {
        Validar.SetAnalisarCpf(fun_cpf);
        cpf = fun_cpf;
    }
     
    public string GetCpf()
    {
        return cpf;
    }

}