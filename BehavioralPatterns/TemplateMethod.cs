namespace BehavioralPatterns
{
    public class House
    {
        public void Build()
        {
            BuildFoundation();
            BuildWalls();
            BuildRoof();
        }

        protected void BuildFoundation()
        {
            throw new NotImplementedException();
        }
        protected virtual void BuildWalls()
        {
            throw new NotImplementedException();
        }
        protected virtual void BuildRoof()
        {
            throw new NotImplementedException();
        }
    }
    public class BlockedHouse : House
    {

    }
    public class WoodenHouse : House
    {

    }
}
