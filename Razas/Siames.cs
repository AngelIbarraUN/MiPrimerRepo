
using EjercicioGato;
using EjercicioGato.Razas;

public class Siames : Gato,IMamifero
{
    public Siames() 
    {
        
    }

    public void BuscarPresa()
    {
        Console.WriteLine("El gato Siames busca sus presas");
    }


    public override void Jugar()
    {
        Console.WriteLine("El gato siames juega con su pelota");
    }

    public void TenerHijo()
    {
        Console.WriteLine("El gato siames tiene hijos");
    }
    
}