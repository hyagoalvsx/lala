public class ContaB
{
    public string numConta;
    public int agencia;
    public string titular;
    protected double saldo;

    public virtual void Sacar(double sacar)
    { 
        saldo -= sacar;
    }

    public virtual void Depositar(double depo)
    {
        saldo += depo;
    }
}