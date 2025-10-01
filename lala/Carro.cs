using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

public class Carro
{
    public int id;
    public string marca;
    public string modelo;
    private string placa;
    public string renavam;
    private string chassi;

   

    public Carro(string chassi_)

    {
        SetChassi(chassi_);
        chassi = chassi_;

    }

    public void SetPlaca(string placaCarro)
    {
        placaCarro = placaCarro.ToUpper();

        if (placaCarro.Length == 7)
        {
            
            bool placaAntiga = char.IsLetter(placaCarro[0]) &&
                          char.IsLetter(placaCarro[1]) &&
                          char.IsLetter(placaCarro[2]) &&
                          char.IsDigit(placaCarro[3]) &&
                          char.IsDigit(placaCarro[4]) &&
                          char.IsDigit(placaCarro[5]) &&
                          char.IsDigit(placaCarro[6]);
            
            bool placaMercosul = char.IsLetter(placaCarro[0]) &&
                                char.IsLetter(placaCarro[1]) &&
                                 char.IsLetter(placaCarro[2]) &&
                                  char.IsDigit(placaCarro[3]) &&
                                  char.IsLetter(placaCarro[4]) &&
                                  char.IsDigit(placaCarro[5]) &&
                                  char.IsDigit(placaCarro[6]);

            if (placaAntiga == true || placaMercosul == true)
            {
                placa = placaCarro;
            }
            else
            {
                throw new Exception("Placa inválida.");
            }

        }
        else
        {
            throw new Exception("Placa inválida. \n" +
            "Quantidade de caracteres errada.");
        }
    }

    public string GetPlaca()
    {
        return placa;
    }
    public void SetChassi(string chassi_)
    {
        chassi_ = chassi_.ToUpper();

        if (chassi_.Length == 17 && !chassi_.Contains("O") && !chassi_.Contains("I") && !chassi_.Contains("Q"))
        {
            chassi_ = chassi_;
        }
        else
        {
            throw new Exception("Numero de chassi invalido.");
        }
 
    }

    public string GetChassi()
    { 
        return chassi; 
    }

    public Carro(int id_, string marca_, string modelo_, string placa_, string renavam_, string chassi_)
    {
        SetChassi(chassi_);
        id = id_;
        marca = marca_;
        modelo = modelo_;
        placa = placa_;
        renavam = renavam_;
        chassi = chassi_;


    }
}


    
   /* public bool ValidarChassi(string chassi_)
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
   */