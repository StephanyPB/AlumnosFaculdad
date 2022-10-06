namespace AlumnosFaculdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personaTotal = 0;
            int personaPasan = 0;
            int personaAbandonan = 0;
            int personaRepitiendio = 0;
            int cantidadAulas = 0;


            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"año {i+1}");
                //Personas que ingresan
                Random personaEntran = new Random();
                int personaAleatoria = personaEntran.Next(265, 325);
                //personaAleatoria = personaAleatoria * 25;
                personaTotal = personaAleatoria;

                Console.WriteLine("Ingresan: " + personaAleatoria);    
                //Cantidad de aulas para el total de lso que ingresan
                cantidadAulas = personaAleatoria / 35;
                Console.WriteLine("Cantidad de Aulas: "+ cantidadAulas);

                //Personas que pasan aleatoriamente
                Random PersonasPasanAleatorio = new Random();
                personaPasan = PersonasPasanAleatorio.Next(1, personaAleatoria);

                Console.WriteLine("Pasan: " + personaPasan);
                personaTotal -= personaPasan;
                //Repiten

                Random personaRepitenRamdom = new Random(); 
                personaRepitiendio = personaRepitenRamdom.Next(1, personaTotal);

                Console.WriteLine("Repiten: " + personaRepitiendio);


                personaTotal -= personaRepitiendio;

                Console.WriteLine("Abandonan: " +personaTotal);

                Console.WriteLine("");
            }
        }
    }
}