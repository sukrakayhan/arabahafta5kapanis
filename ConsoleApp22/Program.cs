using ConsoleApp22;

List<Car> cars = new List<Car>(); //Arabaları saklamak için liste.
while (true)
{
    Console.WriteLine("Araba üretmek istiyor musunuz?(e -h)");
    string userInput = Console.ReadLine().ToLower();
    if ("e" == userInput)
    {
        //Araba nesnesini üretiyoruz.
        Car car = new Car();
        car.ProductionDate = DateTime.Now; //Arabanın üretim tarihi nesne oluşturulduğunda tanımlanıyor.
        Console.Write("Arabanın markasını girin:");
        car.Brand = Console.ReadLine();
        Console.Write("Arabanın modelini girin:");
        car.Model = Console.ReadLine();
        Console.Write("Arabanın rengini giriniz:");
        car.Color = Console.ReadLine();
        Console.Write("Arabanın seri numarasını giriniz:");
        car.SerialNumber = Console.ReadLine();
    CarDoor: Console.WriteLine("Arabanın kapı sayısını giriniz:");
        try
        {
            car.NumberOfDoors = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Lütfen sayı giriniz.");
            goto CarDoor;
        }
        cars.Add(car);
        Console.WriteLine("Araba başarıyla üretildi.");
    }

    else if ("h" == userInput)
    {
        Console.WriteLine("Üretilen arabalar:");
        foreach (Car car in cars)
        {
            Console.WriteLine($"Arabanın Markası: {car.Brand} Modeli: {car.Model} Seri Numarası: {car.SerialNumber} " +
                $"Rengi: {car.Color} Kapı Sayısı: {car.NumberOfDoors}");
        }
        Console.WriteLine("Programdan çıkılıyor.");
        break;
    }
    else
        Console.WriteLine("Geçerisiz bir giriş yaptınız.");
}