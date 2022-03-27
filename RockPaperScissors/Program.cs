using System;

namespace RockPaperScissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random  random = new Random();
            string[] rockPaperScissors = { "ROCK", "PAPER", "SCISSORS" };
           
            //Console.WriteLine(pick);
            bool playAgain = true;
            bool validatePick = true;
            string pickYou;
            bool validateResponse = false;


            while (playAgain)
            {
                string pickRandom = rockPaperScissors[random.Next(0, 3)];
                ValidatePick(rockPaperScissors, out validatePick, out pickYou);
                while (validatePick)
                {
                    ValidatePick(rockPaperScissors, out validatePick, out pickYou);
                }

                switch (pickRandom)
                {
                    case "ROCK":
                        {
                            if (pickYou == "PAPER")
                            {
                                Console.WriteLine($"You won! You: {pickYou}; Opponent: {pickRandom}");
                            }
                            else if (pickYou == "ROCK")
                            {
                                Console.WriteLine($"It is a tie! You: {pickYou}; Opponent: {pickRandom}");

                            }
                            else
                            {
                                Console.WriteLine($"You lost. You: {pickYou}; Opponent: {pickRandom}");
                            }
                            break;
                        }
                    case "PAPER":
                        {
                            if (pickYou == "SCISSORS")
                            {
                                Console.WriteLine($"You won! You: {pickYou}; Opponent: {pickRandom}");
                            }
                            else if (pickYou == "PAPER")
                            {
                                Console.WriteLine($"It is a tie! You: {pickYou}; Opponent: {pickRandom}");

                            }
                            else
                            {
                                Console.WriteLine($"You lost. You: {pickYou}; Opponent: {pickRandom}");
                            }
                            break;
                        }
                    case "SCISSORS":
                        {
                            if (pickYou == "ROCK")
                            {
                                Console.WriteLine($"You won! You: {pickYou}; Opponent: {pickRandom}");
                            }
                            else if (pickYou == "SCISSORS")
                            {
                                Console.WriteLine($"It is a tie! You: {pickYou}; Opponent: {pickRandom}");

                            }
                            else
                            {
                                Console.WriteLine($"You lost. You: {pickYou}; Opponent: {pickRandom}");
                            }
                            break;
                        }


                }

                Console.WriteLine("Play again (Y/N)?");
                string response; 
                bool yesno = false;
                playAgain = ValidateYesNo(playAgain, out response, out yesno);
                while (yesno == false)
                {
                    playAgain = ValidateYesNo(playAgain, out response, out yesno);
                }
            }

        }

        private static bool ValidateYesNo(bool playAgain, out string response, out bool yesno)
        {
            response = Console.ReadLine();
            response = response.ToUpper();
            if (response == "Y")
            {
                playAgain = true;
                yesno = true;
            }
            else if (response == "N")
            {
                playAgain = false;
                yesno = true;
            }
            else
            {
                Console.WriteLine("Invalid Entry, try again (Y/N)");
                yesno = false;
            }

            return playAgain;
        }

        private static void ValidatePick(string[] rockPaperScissors, out bool validatePick, out string pickYou)
        {
            Console.WriteLine("Enter your pick (\"ROCK\", \"PAPER\" OR \"SCISSORS\"");
            pickYou = Console.ReadLine();
            pickYou = pickYou.ToUpper();
            int index = Array.IndexOf(rockPaperScissors, pickYou);
            if (index > -1)
            {
                validatePick = false;
            }
            else
            {
                validatePick = true;
            }
        }
    }
}
