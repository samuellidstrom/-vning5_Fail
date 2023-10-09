namespace Uppgift5_Garage
{
    public class UserInterface
    {
        //public UserInterface()
        //{

            
        //}

        public void MainMenu()
        {
            Console.WriteLine("Main Menu:");

            Console.WriteLine("1. List All Parked Vehicles");
            Console.WriteLine("2. Lista fordonstyper - Visar hur många som finns av varje sort");
            Console.WriteLine("3. Lägga till fordon");
            Console.WriteLine("4. Ta bort fordon");
            Console.WriteLine("5. Sätta en kapacitet när nytt garage skapas");
            Console.WriteLine("6. Lägg till 6 stycken fordon automatiskt");
            Console.WriteLine("7. Sök efter ett fordon via registreringsnummer (ska funka att blanda versaler/små bokstäver");
            Console.WriteLine("8. Sök efter fordon utifrån en egenskap eller flera");
            Console.WriteLine("9. Få bekräftelse på att det gått bra eller dåligt (exempel att ett fordonparkerats mm)");
        }


        public void PrintVehicle(string message)
        {
            
        }
        public void GetInput(string message)
        {
            
        }



    }
}