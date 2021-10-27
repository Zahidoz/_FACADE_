namespace _FACADE_
{
    class Authorize
    {
        public void CheckUser()
        {
            Console.WriteLine("Chek User"); 
        }
    }
    class Caching
    {
        public void Cache()
        {
            Console.WriteLine("Cache");
        }
    }
    class Logging
    {
        public void Log()
        {
            Console.WriteLine("Log");
        }
    }
    class Validation
    {
        public void Validate()
        {
            Console.WriteLine("Validate");
        }
    }


    class CrossCuttingConcerns
    {
        public Authorize Authorize { get; set; }
        public Caching Caching { get; set; }
        public Logging Logging { get; set; }
        public Validation Validation { get; set; }
       
        public CrossCuttingConcerns(Authorize _authorize, Caching _caching, Logging _logging, Validation _validation)
        {
            Authorize = _authorize;
            Caching = _caching;
            Logging = _logging;
            Validation = _validation;
        }
        public void UseAll()
        {
            Authorize.CheckUser();
            Logging.Log();
            Validation.Validate();
            Caching.Cache();
            DoSomething();
        }
        public void DoSomething()
        {
            Console.WriteLine("Do Something");
        }

    }

    public class Program
    {
        static void Main()
        {
            CrossCuttingConcerns cross  = new CrossCuttingConcerns(new Authorize(), new Caching(), new Logging(), new Validation());

            cross.UseAll();
        }
    }
}