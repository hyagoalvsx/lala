using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

public class Carro
{
    public int id;
    public string marca;
    public string modelo;
    public string placa;
    public int renavam;
    public string chassi;

    public Carro(int id_, string marca_, string modelo_, string placa_, int renavam_, string chassi_)
    {
        id = id_;
        marca = marca_;
        modelo = modelo_;
        placa = placa_;
        renavam = renavam_;
        chassi = chassi_;

        ValidarChassi(chassi_);
    }

    public Carro(string chassi_)

    {
        chassi = chassi_;
        ValidarChassi(chassi_);

    }
    public bool ValidarChassi(string chassi_)
    {
            //chassi = chassi.ToUpper();
           //if (chassi.Length == 17 && !chassi.Contains("O")&& !chassi.Contains("I") && !chassi.Contains("Q"))
           //codigo acima pode ser usado tbm nessa situação
           
        chassi = chassi.ToUpper();

        if (chassi_.Length != 17)
        {
            throw new Exception("Numero de chassi invalido.");
        }

        if (chassi_.Contains("I") || chassi_.Contains("Q") || chassi_.Contains("O"))
        {
            
            throw new Exception("A letra do chassi é invalido.");
        }
        return true;

    }
}
//testando novamente
