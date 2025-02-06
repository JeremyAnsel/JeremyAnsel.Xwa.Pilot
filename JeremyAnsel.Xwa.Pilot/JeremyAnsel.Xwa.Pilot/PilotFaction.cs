namespace JeremyAnsel.Xwa.Pilot
{
    public sealed class PilotFaction
    {
        public int TotalMissionsPlayedCount { get; set; }

        public int Team { get; set; }

        public PilotMissionDirectory MissionDirectoryId { get; set; }

        public int[] MissionDescriptionIds { get; set; } = new int[7];

        public int M0048 { get; set; }

        public int[] AwardsCount1 { get; set; } = new int[6];

        public int[] M0064 { get; set; } = new int[6];

        public int[] AwardsCount2 { get; set; } = new int[6];

        public int[] M0094 { get; set; } = new int[6];

        public int[] KalidorCrescentPoints { get; set; } = new int[4];

        public int Score { get; set; }

        public int BonusScore { get; set; }

        public int TotalScore { get; set; }

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
