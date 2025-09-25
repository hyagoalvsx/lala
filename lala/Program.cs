/*Carro car = new Carro("9XWHE21JX24060831");

try
{
    Carro car = new Carro("9OPBHE21JX24060831");
    car.SetChassi("9OPBHE21JX24060831");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//testando commit no git e github novamente2
//editando pelo github
*/
/*try
{
    Carro c1 = new Carro("9OPBHE21JX24060831");
    Console.WriteLine(c1.SetChassi);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/

try
{
    Carro carro = new Carro(1, "Fiat", "Uno", "LSJKHI5", 87451, "9XWHE21JX24060831");
    Console.WriteLine(carro.GetChassi());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}
