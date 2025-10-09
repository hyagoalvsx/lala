using System.Security.Cryptography.X509Certificates;

public class Cliente
{
    public int id;
    public string nome;
    public DateTime dataNasc;
    public string sexo;
    private string cpf_;
    public Cliente(int id_, string nome_, string cpf, string sexo_)
    {
        id = id_;
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