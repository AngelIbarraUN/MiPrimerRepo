using EjercicioGato.Razas;

namespace EjercicioGato
{
    public class Persa : Gato, IMamifero
    {
        public void BuscarPresa()
        {
            Console.WriteLine("El gato Persa busca sus presas");
        }


        public override void Jugar()
        {
            Console.WriteLine("El gato Persa juega con su pelota");
        }

        public void TenerHijo()
        {
            Console.WriteLine("El gato Persa tiene hijos");
        }
    }
}