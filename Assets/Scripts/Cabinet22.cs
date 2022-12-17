namespace DefaultNamespace
{
    public class Cabinet22
    {
        public void Init()
        {
            var numberOfPeople = 7;
            
            var Vlad = new Worker
            {
                age = 21,
                department = "qa",
            };
            
            var Sveta = new Worker
            {
                department = "dev",
            };
            
            var vladVacationDays = Vlad.GetVacationDays();
            var svetaVacationDays = Sveta.GetVacationDays();
        }
    }
}