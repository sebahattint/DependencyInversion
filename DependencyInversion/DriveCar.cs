namespace DependencyInversion
{
    class DriveCar
    {
        public void Drive(ICar car)
        {
            car.Drive();
        }
    }
}
