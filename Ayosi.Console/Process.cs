namespace ConsoleApp1
{
    public class Process
    {
        private readonly IPersonService _personService;

        public Process(IPersonService personService)
        {
            _personService = personService;
        }
        public void GetPersonServiceName()
        {
            _personService.GetName();
        }
    }
}
