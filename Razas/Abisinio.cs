namespace EjercicioGato.Razas
{
    public class Abisinio : Gato,IMamifero
    {
        public void BuscarPresa()
        {
            Console.WriteLine("El gato Abisinio busca sus presas");
        }


        public override void Jugar()
        {
            Console.WriteLine("El gato Abisinio juega con su pelota");
        }

        public void TenerHijo()
        {
            Console.WriteLine("El gato Abisinio tiene hijos");
        }
    }
}