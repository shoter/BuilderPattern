using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Chairs;
using BuilderPattern.Optionals;

namespace BuilderPattern
{
    public sealed class WorkplaceBuilder : IWorkplaceBuilder, INeedsAnChair, INeedsAnDesk, INeedsAnOptional 
    {
        private List<IOptional> optionals = new List<IOptional>();
        private DeskType deskType;
        private int width, length, height;
        private IChair chair;
        private string employeeName;

        private WorkplaceBuilder()
        {

        }

        private WorkplaceBuilder(WorkplaceBuilder other)
        {
            this.optionals = other.optionals.Clone();
            this.deskType = other.deskType;
            this.width = other.width;
            this.height = other.height;
            this.length = other.length;
            this.chair = other.chair;
            this.employeeName = other.employeeName;
        }




        public INeedsAnOptional AddOptional(IOptional optional)
        {
            this.optionals.Add(optional);
            return new WorkplaceBuilder(this);
        }

        public IWorkplace Build()
        {
            var workplace = new Workplace(chair, deskType, width, length, height)
            {
                EmployeeName = this.employeeName
            };

            foreach (var opt in optionals)
                workplace.AddOptional(opt);

            return workplace;
        }

        public INeedsAnOptional SetADesk(DeskType deskType, int width, int length, int height)
        {
            this.deskType = deskType;
            this.width = width;
            this.height = height;
            this.length = length;
            return new WorkplaceBuilder(this);
        }

        public INeedsAnDesk SetChair(IChair chair)
        {
            this.chair = chair;
            return new WorkplaceBuilder(this);
        }

        public INeedsAnOptional SetEmployeeName(string employeeName)
        {
            return new WorkplaceBuilder(this);
        }

        public static IWorkplaceBuilder Begin()
        {
            return new WorkplaceBuilder();
        }
    }
}
