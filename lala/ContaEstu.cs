public class ContaEstu:ContaB
{
    public double limiteChequeEspecial;
    private string cpf_;
    public string nomeInstituicao;
    public override void Sacar(double sacar)
    {
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