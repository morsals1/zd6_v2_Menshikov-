using System;

namespace zd6_v2_Menshikov
{
    public class RoadWork
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double MassPerSquareMeter { get; set; }
        public string Material { get; set; }
        public string Contractor { get; set; }

        public RoadWork(double width, double length, double massPerSquareMeter, string material, string contractor)
        {
            Width = width;
            Length = length;
            MassPerSquareMeter = massPerSquareMeter;
            Material = material ?? throw new ArgumentNullException(nameof(material));
            Contractor = contractor ?? throw new ArgumentNullException(nameof(contractor));
        }

        public double CalculateQuality()
        {
            return (Width * Length * MassPerSquareMeter) / 1000;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Ширина: {Width} м, Длина: {Length} м, Масса на кв. метр: {MassPerSquareMeter} кг, Материал: {Material}, Подрядчик: {Contractor}");
        }

        public override string ToString()
        {
            return $"Ширина: {Width} м, Длина: {Length} м, Масса на кв. метр: {MassPerSquareMeter} кг, Материал: {Material}, Подрядчик: {Contractor}";
        }
    }
}