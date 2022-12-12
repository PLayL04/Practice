namespace comp
{
    internal class Factory
    {
        public List<GentleSmartphone> smartphones { get; set; } = new List<GentleSmartphone>();
        public List<Transformator> transformators { get; set; } = new List<Transformator>();
        public List<Customer> customers { get; set; }
        public void SaleSmartphone()
        {
            foreach (Customer customer in customers)
            {

                GentleSmartphone smartphone_temp = new GentleSmartphone();
                Transformator transformator_temp = new Transformator();

                if (customer.Smartphone == null)
                {
                    if (customer.GentleRate >= TactileSensor.Sensivity / 1.5 & customer.GentleRate <= TactileSensor.Sensivity * 2)
                    {
                        customer.Smartphone = smartphones.FirstOrDefault();
                        smartphone_temp = customer.Smartphone;
                        smartphones.Remove(smartphone_temp);
                        Console.WriteLine("Смартфон под номером {0} был подарен {1}", smartphone_temp.SerialNumber, customer.FullName);
                    }
                    else if (customer.GentleRate >= TactileSensor.Sensivity / 2 / 1.5 & customer.GentleRate < TactileSensor.Sensivity / 1.5)
                    {
                        customer.Smartphone = smartphones.FirstOrDefault();
                        customer.TransformModule = transformators.FirstOrDefault();
                        smartphone_temp = customer.Smartphone;
                        transformator_temp = customer.TransformModule;
                        smartphones.Remove(smartphone_temp);
                        transformators.Remove(transformator_temp);
                        TransformatorType.ChoDelaet h = (TransformatorType.ChoDelaet)1;

                        Console.WriteLine("Смартфон под номером {0} и трансформатор {1} под номером {2} был подарен {3}", smartphone_temp.SerialNumber, h, transformator_temp.Number, customer.FullName);
                    }
                    else if (customer.GentleRate > TactileSensor.Sensivity * 2 & customer.GentleRate <= TactileSensor.Sensivity * 2 * 2)
                    {
                        customer.Smartphone = smartphones.FirstOrDefault();
                        customer.TransformModule = transformators.FirstOrDefault();
                        smartphone_temp = customer.Smartphone;
                        transformator_temp = customer.TransformModule;
                        smartphones.Remove(smartphone_temp);
                        transformators.Remove(transformator_temp);
                        TransformatorType.ChoDelaet h = (TransformatorType.ChoDelaet)0;

                        Console.WriteLine("Смартфон под номером {0} и трансформатор {1} под номером {2} был подарен {3}", smartphone_temp.SerialNumber, h, transformator_temp.Number, customer.FullName);
                    }
                    else
                        Console.WriteLine("{0} слишком нежный или недостаточно нежный", customer.FullName);
                }
            }
            smartphones.Clear();
            transformators.Clear();
        }
    }
}
