namespace EjercicioGato
{
    public abstract class Gato
    {
     public Gato()
     {
        
     }
        public decimal Peso { get; set; }
        public string Tamaño { get; set; }
        public string color { get; set; }
        public string Nombre { get; set; }

        public void Comer()
        {

        }

        public  void Comer(int cantidad)
        {

        }


        public void Correr()
        {

        }
         public void Correr(decimal distancia)
        {

        }
        public abstract void Jugar();

        public void Jugar(string juguete)
        {

        }
    }
    
}