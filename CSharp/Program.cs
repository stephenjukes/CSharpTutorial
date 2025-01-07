using CSharp.Sololearn;
using CSharp.Exercism;

namespace CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // SOLOLEARN

            // Printing Text

            // PrintingText.Run();

            // EXERCISM

            //Leap.Run(1901);
            //Leap.Run(1900);
            //Leap.Run(2000);
            //Leap.Run(2004);

            var theHarrowingScourge = new Tyranid("The Harrowing Scourge");
            var theBoundingMenace = new Tyranid("The Bounding Menace");
            var theLurkingProwler = new Tyranid("The Lurking Prowler");

            var tyranids = new Tyranid[] { theHarrowingScourge, theBoundingMenace, theLurkingProwler };

            foreach (var tyranid in tyranids)
            {
                Console.WriteLine(tyranid.Summary());
            }

            theBoundingMenace.Attack(theLurkingProwler);

            foreach (var tyranid in tyranids)
            {
                Console.WriteLine(tyranid.Summary());
            }
        }
    }
}
