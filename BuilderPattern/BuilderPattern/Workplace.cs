using BuilderPattern.Chairs;
using BuilderPattern.Optionals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Workplace : IWorkplace
    {
        public IChair Chair { get; internal set; }
        public DeskType DeskType { get; internal set; }
        public int DeskWidth { get; internal set; }
        public int DeskLength { get; internal set; }
        public int DeskHeight { get; internal set; }
        public List<IOptional> optionals = new List<IOptional>();
        public IEnumerable<IOptional> Optionals => optionals;
        public string EmployeeName = string.Empty;

        public Workplace(IChair chair, DeskType deskType, int deskWidth, int deskLength, int deskHeight)
        {
            Chair = chair;
            DeskType = deskType;
            DeskWidth = deskWidth;
            DeskLength = deskLength;
            DeskHeight = deskHeight;
        }

        public Workplace AddOptional(IOptional optional)
        {
            this.optionals.Add(optional);
            return this;
        }

        public void Describe()
        {
            Console.WriteLine($"Chair: {Chair.Name} ( {Chair.Height} cm)");
            Console.WriteLine($"{DeskType.ToString()} Desk ( {DeskWidth}x{DeskLength}x{DeskHeight} cm)");
            if (Optionals.Any())
            {
                Console.WriteLine("Optionals: ");

                foreach (var optional in Optionals)
                {
                    Console.WriteLine(optional.Name);
                }
            }

            if(string.IsNullOrWhiteSpace(EmployeeName) == false)
            {
                Console.WriteLine($"Workplace was prepared for {EmployeeName}");
            }
            Console.WriteLine();
        }
    }
}
