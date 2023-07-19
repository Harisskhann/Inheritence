namespace first
{
    class Plane
    {
        public int Year;
        public string Number;

        public void getSpecs()
        {
            Console.Write("Please Enter plane year = ");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter plane Number = ");
            Number = Convert.ToString(Console.ReadLine());

        }

    }

    class AirBlue : Plane
    {
        public string Company;
        public string Model;
        public string Color;


        public void getAirBlue()
        {
            Console.Write("Please Enter plane Comapny = ");
            Company = Convert.ToString(Console.ReadLine());

            Console.Write("Please Enter plane Model = ");
            Model = Convert.ToString(Console.ReadLine());

            Console.Write("Please Enter plane Color = ");
            Color = Convert.ToString(Console.ReadLine());
        }

        public void displayAirBlue()
        {
            Console.WriteLine("I am " + Company);
            Console.WriteLine("My Model is " + Model);
            Console.WriteLine("My Manufacturing Year is " + Year);
            Console.WriteLine("My Registration number is " + Number);
            Console.WriteLine("My Color is " + Color);

        }

    }

    class PIA : Plane
    {

        public string features;
        public float engineCapacity;
        public string pioletsCapacity;
        public int pessengerSeats;
        public string condition;
        public short Speed;

        public void getplane()
        {
            Console.Write("Enter plane Features (AWD or 4WD) = ");
            features = Convert.ToString(Console.ReadLine());


            Console.Write("Enter plane Engine Capacity = ");
            engineCapacity = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter plane piolet capacity = ");
            pioletsCapacity = Convert.ToString(Console.ReadLine());

            Console.Write("Enter plane pessenger seats = ");
            pessengerSeats = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter plane condition = ");
            condition = Convert.ToString(Console.ReadLine());

            Console.Write("Enter plane Top Speed = ");
            Speed = Convert.ToInt16(Console.ReadLine());

        }

        public void displayplane()
        {
            Console.WriteLine("I am PIA");
            Console.WriteLine("My Manufacturing year is " + Year);
            Console.WriteLine("My Registration Number is " + Number);
            Console.WriteLine("My Feature is That i am " + features);
            Console.WriteLine("My Engine Capacity is " + engineCapacity + "L");
            Console.WriteLine("My pioletsCapacity is " + pioletsCapacity);
            Console.WriteLine("i have pessengerSeats " + pessengerSeats);
            Console.WriteLine("My condition is " + condition);
            Console.WriteLine("My Top Speed is " + Speed + " Km/hr");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var airblue = new AirBlue();

            airblue.getSpecs();
            airblue.getAirBlue();
            airblue.displayAirBlue();


            var pia = new PIA();

            pia.getSpecs();
            pia.getplane();
            pia.displayplane();

        }

    }

}