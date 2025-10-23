using System.Security.Cryptography.X509Certificates;

public class Cliente: Pessoa
{
    public string sexo;
    private string cpf_;
    public Cliente(int id_, string nome_, string cpf, string sexo_)
    {
        id_pessoa = id_;
        nome = nome_;
        sexo = sexo_;
        cpf_ = cpf;
        SetCpf(cpf);
    }

    public void SetCpf(string cpf)
    {
        Validar.SetAnalisarCpf(cpf);
    }

    public string GetCpf()
    {
        return cpf_;
    }
}