using System;

namespace HiloGame
{
    public class Director
    {

        bool isPlaying = true; 

        Card myCard = new Card(); 
        
        Card nextCard = new Card();

        Card intScore = new Card();

        public Director()
        {
            int current_card = myCard.pick_card ();
        }
        

        public void StartGame()
        {
            while (isPlaying)
            {
                getInput();
                doUpdates();
                getRender();
            }
        }  

        public void getInputs(int current_card)
        {
            Console.WriteLine($"This card is: {current_card}");
            Console.Write("Higher or Lower? [y/n]" );
            string guess_card = Console.ReadLine();
        }  


// Vin. Everything is completed up until the input. Complete the last 2 methods. Text us if you need help. 
        public void doUpdates()
        {

        }
        public void getRender()
        {

        }

    }
}