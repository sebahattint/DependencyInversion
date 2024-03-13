namespace DependencyInversion
{
    public class Program
    {
        private static Hyundai hyundai;
        private static Toyota toyota;
        static void Main(string[] args)
        {
            //Boylece ust seviye class imiz etkilenmeden, yeni arac tipleri eklenebilir bir yapi kurmus olduk.
            DriveCar driveCar = new DriveCar();
            driveCar.Drive(hyundai);
            driveCar.Drive(toyota);
        }
    }
}
