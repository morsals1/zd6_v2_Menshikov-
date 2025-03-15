using System;

namespace zd6_v2_Menshikov
{
    public class AdvancedRoadWork : RoadWork
    {
        public int StrengthCoefficient { get; set; }
        public string WeatherCondition { get; set; }
        public string Supervisor { get; set; } 
        public DateTime CompletionDate { get; set; } 

        public AdvancedRoadWork(double width, double length, double massPerSquareMeter, string material, string contractor, int strengthCoefficient, string weatherCondition, string supervisor, DateTime completionDate)
            : base(width, length, massPerSquareMeter, material, contractor)
        {
            StrengthCoefficient = strengthCoefficient;
            WeatherCondition = weatherCondition ?? throw new ArgumentNullException(nameof(weatherCondition));
            Supervisor = supervisor ?? throw new ArgumentNullException(nameof(supervisor));
            CompletionDate = completionDate;
        }

        public new double CalculateQuality()
        {
            double baseQuality = base.CalculateQuality(); // Базовая формула качества
            double qualityWithCoefficient;

            if (StrengthCoefficient >= 5 && StrengthCoefficient <= 8)
            {
                qualityWithCoefficient = baseQuality * 1.1; // Qp = Q * 1.1
            }
            else if (StrengthCoefficient == 3 || StrengthCoefficient == 4 || StrengthCoefficient == 9 || StrengthCoefficient == 10)
            {
                qualityWithCoefficient = baseQuality * 1.6; // Qp = Q * 1.6
            }
            else
            {
                qualityWithCoefficient = baseQuality * 1.9; // Qp = Q * 1.9
            }

            return qualityWithCoefficient;
        }

        public override string ToString()
        {
            return base.ToString() + $", Коэффициент прочности: {StrengthCoefficient}, Погодные условия: {WeatherCondition}, Надзирающий: {Supervisor}, Дата завершения: {CompletionDate.ToShortDateString()}, Качество с учетом коэффициента: {CalculateQuality()}";
        }

        public void DisplayAdvancedInfo()
        {
            Console.WriteLine(this.ToString());
        }
    }
}