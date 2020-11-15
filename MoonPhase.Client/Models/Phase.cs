namespace MoonPhase.Client.Models
{
    public class Phase
    {
        public const string NewMoon = "New Moon";
        public const string WaxingCrescent = "Waxing Crescent";
        public const string FirstQuarter = "First Quarter";
        public const string WaxingGibbous = "Waxing Gibbous";
        public const string FullMoon = "Full Moon";
        public const string WaningGibbous = "Waning Gibbous";
        public const string ThirdQuarter = "Third Quarter";
        public const string WaningCrescent = "Waning Crescent";

        public Phase(string name, double start, double end)
        {
            Name = name;
            Start = start;
            End = end;
        }

        public string Name { get; }

        /// <summary>
        /// The days into the cycle this phase starts
        /// </summary>
        public double Start { get; }

        /// <summary>
        /// The days into the cycle this phase ends
        /// </summary>
        public double End { get; }
    }
}
