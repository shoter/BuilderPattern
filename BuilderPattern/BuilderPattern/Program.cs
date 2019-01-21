using BuilderPattern.Chairs;
using BuilderPattern.Optionals;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var workplace = WorkplaceBuilder
                .Begin()
                .SetChair(new BlackChair())
                .SetADesk(DeskType.Executive, 100, 150, 100)
                .AddOptional(new Flower("Yellow"))
                .Build();


            workplace.Describe();

            var inMiddle = WorkplaceBuilder
                .Begin()
                .SetChair(new NormalChair());

            inMiddle.SetADesk(DeskType.Computer, 100, 120, 99)
                .AddOptional(new Photo("John Doe"))
                .AddOptional(new Photo("John Doe"))
                .AddOptional(new Photo("John Doe"))
                .Build()
                .Describe();

            inMiddle.SetADesk(DeskType.Corner, 50, 50, 99)
                .Build()
                .Describe();



            Console.ReadKey();
        }
    }
}
