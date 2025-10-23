public class Plano
{
    public int id;
    public string descricao;
    private double valorSugerido;


    public Plano(int id_, string descricao_, double valorSugerido_)
    {
        id = id_;
        descricao = descricao_;
        SetValorSugerido(valorSugerido_);
    }
    public void SetValorSugerido(double valorSugerido_)
    {
        if (valorSugerido_ < 0)
        {
            throw new Exception("Valor invalido");
        }
        else
        {
            valorSugerido = valorSugerido_;

            if (valorSugerido_ > 0)
            {
                valorSugerido = valorSugerido_;
            }
            else
            {
                throw new Exception("Valor invalido");

            }

        }
        
    }
    public double GetValorSugerido()
    {
        return valorSugerido;
    }
}