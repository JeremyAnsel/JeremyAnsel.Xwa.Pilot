namespace JeremyAnsel.Xwa.Pilot
{
    public sealed class PilotObjectStats
    {
        public int[] TotalScorePerMissionType { get; } = new int[3];

        public int[] TotalMissionsPlayedCountPerMissionType { get; } = new int[3];

        public int[] TotalKillsPerMissionType { get; } = new int[3];

        public int[] TotalFriendliesKilledPerMissionType { get; } = new int[3];

        public int[,] KillsPerCraftPerMissionType { get; } = new int[512, 3];

        public int[,] KillsSharedPerCraftPerMissionType { get; } = new int[512, 3];

        public int[,] KillsAssistsPerCraftPerMissionType { get; } = new int[512, 3];

        public int[,] KillsFullOnPlayerRatingPerMissionType { get; } = new int[25, 3];

        public int[,] KillsSharedOnPlayerRatingPerMissionType { get; } = new int[25, 3];

        public int[,] KillsAssistOnPlayerRatingPerMissionType { get; } = new int[25, 3];

        public int[,] KillsFullOnAIRatingPerMissionType { get; } = new int[6, 3];

        public int[,] KillsSharedOnAIRatingPerMissionType { get; } = new int[6, 3];

        public int[,] KillsAssistOnAIRatingPerMissionType { get; } = new int[6, 3];

        public int[] NumOfSpecialCraftInspectedPerMissionType { get; } = new int[3];

        public int[] EnergyWeaponsHitsPerMissionType { get; } = new int[3];

        public int[] EnergyWeaponsFiredPerMissionType { get; } = new int[3];

        public int[] WarheadsHitsPerMissionType { get; } = new int[3];

        public int[] WarheadsFiredPerMissionType { get; } = new int[3];

        public int[] TotalCraftLossesPerMissionType { get; } = new int[3];

        public int[] LossesByCollisionsPerMissionType { get; } = new int[3];

        public int[] LossesByStarshipsPerMissionType { get; } = new int[3];

        public int[] LossesByMinesPerMissionType { get; } = new int[3];

        public int[,] KilledByPlayerRatingPerMissionType { get; } = new int[25, 3];

        public int[,] KilledByAIRatingPerMissionType { get; } = new int[6, 3];
    }
}
