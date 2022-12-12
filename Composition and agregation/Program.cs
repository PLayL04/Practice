using comp;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer1 = new Customer()
        {
            FullName = "Вася",
            GentleRate = 80
        };
        Customer customer2 = new Customer()
        {
            FullName = "Ваня",
            GentleRate = 16
        };
        Customer customer3 = new Customer()
        {
            FullName = "Петр",
            GentleRate = 62
        };

        GentleSmartphone smartphone1 = new GentleSmartphone()
        {
            SerialNumber = 1,
        };
        GentleSmartphone smartphone2 = new GentleSmartphone()
        {
            SerialNumber = 2,
        };
        GentleSmartphone smartphone3 = new GentleSmartphone()
        {
            SerialNumber = 3,
        };

        Transformator transformator1 = new Transformator()
        {
            Number = 1,
        };
        Transformator transformator2 = new Transformator()
        {
            Number = 2,
        };
        Transformator transformator3 = new Transformator()
        {
            Number = 3,
        };

        List<Customer> customers = new List<Customer>();
        customers.Add(customer1);
        customers.Add(customer2);
        customers.Add(customer3);


        Factory factory = new Factory();
        factory.customers = customers;
        factory.smartphones.Add(smartphone1);
        factory.smartphones.Add(smartphone2);
        factory.smartphones.Add(smartphone3);
        factory.transformators.Add(transformator1);
        factory.transformators.Add(transformator2);
        factory.transformators.Add(transformator3);

        factory.SaleSmartphone();


        Console.ReadLine();
    }
}