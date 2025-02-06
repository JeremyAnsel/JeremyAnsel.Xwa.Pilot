namespace JeremyAnsel.Xwa.Pilot
{
    public sealed class PilotObjectStats
    {
        public int[] TotalScorePerMissionType { get; set; } = new int[3];

        public int[] TotalMissionsPlayedCountPerMissionType { get; set; } = new int[3];

        public int[] TotalKillsPerMissionType { get; set; } = new int[3];

        public int[] TotalFriendliesKilledPerMissionType { get; set; } = new int[3];

        public int[,] KillsPerCraftPerMissionType { get; set; } = new int[512, 3];

        public int[,] KillsSharedPerCraftPerMissionType { get; set; } = new int[512, 3];

        public int[,] KillsAssistsPerCraftPerMissionType { get; set; } = new int[512, 3];

        public int[,] KillsFullOnPlayerRatingPerMissionType { get; set; } = new int[25, 3];

        public int[,] KillsSharedOnPlayerRatingPerMissionType { get; set; } = new int[25, 3];

        public int[,] KillsAssistOnPlayerRatingPerMissionType { get; set; } = new int[25, 3];

        public int[,] KillsFullOnAIRatingPerMissionType { get; set; } = new int[6, 3];

        public int[,] KillsSharedOnAIRatingPerMissionType { get; set; } = new int[6, 3];

        public int[,] KillsAssistOnAIRatingPerMissionType { get; set; } = new int[6, 3];

        public int[] NumOfSpecialCraftInspectedPerMissionType { get; set; } = new int[3];

        public int[] EnergyWeaponsHitsPerMissionType { get; set; } = new int[3];

        public int[] EnergyWeaponsFiredPerMissionType { get; set; } = new int[3];

        public int[] WarheadsHitsPerMissionType { get; set; } = new int[3];

        public int[] WarheadsFiredPerMissionType { get; set; } = new int[3];

        public int[] TotalCraftLossesPerMissionType { get; set; } = new int[3];

        public int[] LossesByCollisionsPerMissionType { get; set; } = new int[3];

        public int[] LossesByStarshipsPerMissionType { get; set; } = new int[3];

        public int[] LossesByMinesPerMissionType { get; set; } = new int[3];

        public int[,] KilledByPlayerRatingPerMissionType { get; set; } = new int[25, 3];

        public int[,] KilledByAIRatingPerMissionType { get; set; } = new int[6, 3];
    }
}
