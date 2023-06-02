namespace InterfaceSegregation
{
<<<<<<< Updated upstream
    public class Tester : IWorkTeamActivities, ITestActivities
=======
    public class Tester : IWorkTeamActivities, ITestActitivities
>>>>>>> Stashed changes
    {
        public Tester()
        {
        }

        public void Plan() 
        {
            throw new ArgumentException();
        }

        public void Comunicate() 
        {
            throw new ArgumentException();
        }

        public void Test() 
        {
            throw new ArgumentException();
        }
    }
}