namespace InterfaceSegregation
{
    public class Developer : IWorkTeamActivities, IDevelopActivities
    {
        public Developer()
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

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
        }
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
    }
}