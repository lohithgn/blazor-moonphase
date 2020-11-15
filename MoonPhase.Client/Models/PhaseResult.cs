using System;

namespace MoonPhase.Client.Models
{
    public class PhaseResult
        {
            public PhaseResult(string name, string emoji, double daysIntoCycle, Earth.Hemispheres hemisphere,
                DateTime moment)
            {
                Name = name;
                Emoji = emoji;
                DaysIntoCycle = daysIntoCycle;
                Hemisphere = hemisphere;
                Moment = moment;
            }

            public string Name { get; }
            public string Emoji { get; set; }
            public double DaysIntoCycle { get; set; }
            public Earth.Hemispheres Hemisphere { get; set; }
            public DateTime Moment { get; }
            public double Visibility
            {
                get
                {
                    const int FullMoon = 15;
                    const double halfCycle = Moon.TotalLengthOfCycle / 2;

                    var numerator = DaysIntoCycle > FullMoon
                        // past the full moon, we want to count down
                        ? halfCycle - (DaysIntoCycle % halfCycle)
                        // leading up to the full moon
                        : DaysIntoCycle;

                    return numerator / halfCycle * 100;
                }
            }

            public override string ToString()
            {
                var percent = Math.Round(Visibility, 2);
                return $"The Moon for {Moment} is {DaysIntoCycle} days\n" +
                       $"into the cycle, and is showing as \"{Name}\"\n" +
                       $"with {percent}% visibility, and a face of {Emoji} from the {Hemisphere.ToString().ToLowerInvariant()} hemisphere.";
            }
        }
}
