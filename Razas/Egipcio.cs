using EjercicioGato.Razas;

namespace EjercicioGato
{
    public class Egipcio : Gato,IMamifero
    {
        public void BuscarPresa()
        {
          Console.WriteLine("El gato Egipcio busca sus presas");
        }


        public override void Jugar()
        {
            Console.WriteLine("El gato Egipcio juega con su pelota");
        }

        public void TenerHijo()
        {
            Console.WriteLine("El gato Egipcio tiene hijos");
        }
    }
}