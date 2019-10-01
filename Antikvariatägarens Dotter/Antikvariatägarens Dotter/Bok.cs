using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_Dotter
{
    class Bok
    {

        public int price = 0;
        string[] nameArray = { "ett", "två", "tre", "fyra" };
        string name; //Bokens namn
        int rarity = 0;
        string[] categoryArray = { "Cat1", "Cat2", "Cat3" };
        string category;
        int actualValue;
        bool cursed;
        Random generator = new Random(); // Ny random generator

    
        public Bok()
        {
            rarity = generator.Next(1, 4);
            if (rarity == 1)
            {
                actualValue = generator.Next(20, 101); // Sätt ett pris på boken
                IsCursed(0); //chansen att boken är cursed blir liten
            }
            else if (rarity == 2)
            {
                actualValue = generator.Next(100, 301); // Sätt ett pris på boken
                IsCursed(10); // Chansen ökar desto mer värdefull boken är
            }
            else if (rarity == 3)
            {
                actualValue = generator.Next(300, 1001); // Sätt ett pris på boken
                IsCursed(25);
            }
        }

        public void PrintInfo()
        {
            GetName();
            GetCategory();
            //skriv ut namn
            if (name == null)
            {
                Console.WriteLine("Name: Unknown");
            }
            else
            {
                Console.WriteLine("Name: " + name);
            }

            //skriv ut rarity
            if (rarity == 0)
            {
                Console.WriteLine("Rarity: Unknown");
            }
            else
            {
                Console.WriteLine("Rarity: " + rarity.ToString());
            }


            if (category == null)
            {
                Console.WriteLine("Category: Unknown");
            }
            else
            {
                Console.WriteLine("Categorý: " + category);
            }

            if (price == 0)
            {
                Console.WriteLine("Price: Unknown");
            }else
            {
                Console.WriteLine("Price: " + price);

            }

        }

        public int Evaluate()
        {
            float rättPris;
            int i;
            rättPris = (actualValue * rarity);
            i = generator.Next(1, 3);
            if (i == 1)
            {
                rättPris = (rättPris * .5f);
            }
            else if (i == 2)
            {
                rättPris = (rättPris * 1.5f);

            }
            price = (int) rättPris;
            Console.WriteLine("The price is about " + price);
            return price;
        }

        public string GetCategory()
        {
            // temporär int som ranomiseras och sedan kopplas till ett värde i en array för alla kategorier
            // kategorin sätts sedan till ett alternativ och returneras
            int i;
            i = generator.Next(0, categoryArray.Length);
            category = categoryArray[i];
            return category;
        }

        public string GetName()
        {
            int i;
            i = generator.Next(0, nameArray.Length);
            name = nameArray[i];
            return name;
        }

        public bool IsCursed(int a) // Avgör om boken är cursed eller inte
        {
            int i = a + generator.Next(0, 101); // Genererar ett nummer mellan 0 och 100, + a som ökar chansen för att boken blir cursed
            if (i >= 80) // Om i är mindre eller lika med 3 kommer boken vara cursed
            {
                cursed = true;
                return true; // Returnerar IsCursed == true
            }
            else // Annars så händer saker >:D
            {
                cursed = false;
                return false; // Returnerar IsCursed == false, det var allt.
            }
        }

    }
}
