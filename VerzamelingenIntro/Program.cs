namespace VerzamelingenIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4]; // array van strings met een vaste lengte van 4 elementen, je hoeft geen elementen toe te voegen, je kan ze leeg laten en later invullen
            names[0] = "Donovan";
            names[1] = "Saad";
            names[2] = "Arnt";
            names[3] = "Jaimey";

            // string[] names = ["Donovan", "Saad", "Arnt", "Jaimey"]; // hetzelfde als hierboven, korter geschreven
            // string[] names = { "Donovan", "Saad", "Arnt", "Jaimey"}; // ook hetzelfde als hierboven, maar met accolades
            // let op: dit kan enkel bij declaratie


            // i mag hier ook gebruikt worden, index is een beetje duidelijker
            for (int index = 0; index < names.Length; index++)
            {
                string nameAtPositionOfIndex = names[index];
                Console.WriteLine(names[index]);
            }

            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // deze for lussen zijn hetzelfde


        }
        public static void PrintNames(string[] names) 
        {
        }
    }
}
