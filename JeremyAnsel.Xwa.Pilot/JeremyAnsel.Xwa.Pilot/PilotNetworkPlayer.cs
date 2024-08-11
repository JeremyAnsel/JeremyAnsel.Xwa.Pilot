namespace JeremyAnsel.Xwa.Pilot
{
    public sealed class PilotNetworkPlayer
    {
        public const int FormalNameMaxLength = 14;
        public const int FriendlyNameMaxLength = 14;

        private string _formalName = string.Empty;

        public string FormalName
        {
            get
            {
                return _formalName;
            }

            set
            {
                _formalName = StringHelpers.Limit(value, FormalNameMaxLength) ?? string.Empty;
            }
        }

        private string _friendlyName = string.Empty;

        public string FriendlyName
        {
            get
            {
                return _friendlyName;
            }

            set
            {
                _friendlyName = StringHelpers.Limit(value, FriendlyNameMaxLength) ?? string.Empty;
            }
        }

        public int FlightGroupId { get; set; }

        public int M20 { get; set; }

        public int DirectPlayId { get; set; }

        public int Rating { get; set; }

        public int TotalScore { get; set; }

        public int Kills { get; set; }

        public int KillsShared { get; set; }

        public int M38 { get; set; }

        public int KillsAssist { get; set; }

        public int TotalLosses { get; set; }

        public int M44 { get; set; }

        public int CraftId { get; set; }

        public int WarheadType { get; set; }

        public int BeamType { get; set; }

        public int CounterMeasuresType { get; set; }

        public int CraftsCount { get; set; }

        public int WavesCount { get; set; }

        public int M60 { get; set; }
    }
}
