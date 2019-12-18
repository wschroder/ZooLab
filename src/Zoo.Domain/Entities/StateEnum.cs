using Zoo.Common;

namespace Zoo.Domain.Entities
{
    public class StateEnum: BaseEnum
    {
        public static StateEnum Alabama = new StateEnum("AL", "Alabama");
        public static StateEnum Florida = new StateEnum("FL", "Florida");
        public static StateEnum Georgia = new StateEnum("GA", "Georgia");
        public static StateEnum NewYork = new StateEnum("NY", "New York");
        public static StateEnum NorthCarolina = new StateEnum("NC", "North Carolina");
        public static StateEnum SouthCarolina = new StateEnum("SC", "South Carolina");
        public static StateEnum Tennessee = new StateEnum("TN", "Tennessee");
        public static StateEnum Texas = new StateEnum("TX", "Texas");

        public StateEnum(string name, string description) : base(name, description)
        {
        }
    }
}