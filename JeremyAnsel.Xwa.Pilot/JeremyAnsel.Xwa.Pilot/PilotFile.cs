using System.Text;

namespace JeremyAnsel.Xwa.Pilot
{
    public sealed class PilotFile
    {
        public const int NameMaxLength = 14;
        public const int MultiplayerGameNameMaxLength = 32;
        public const int MultiplayerHostNameMaxLength = 32;
        public const int PilotRatingNameMaxLength = 32;
        public const int MissionFileNameMaxLength = 256;

        private string _name = string.Empty;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = StringHelpers.Limit(value, NameMaxLength) ?? string.Empty;
            }
        }

        public int TotalScore { get; set; }

        public int NumHumanPlayersLastMission { get; set; }

        public int M00022_ABD7B4 { get; set; }

        public int Team { get; set; }

        public PilotMissionDirectory MissionDirectoryId { get; set; }

        public int[] MissionDescriptionIds { get; set; } = new int[7];

        private string _multiplayerGameName = string.Empty;

        public string MultiplayerGameName
        {
            get
            {
                return _multiplayerGameName;
            }

            set
            {
                _multiplayerGameName = StringHelpers.Limit(value, MultiplayerGameNameMaxLength) ?? string.Empty;
            }
        }

        private string _multiplayerHostName = string.Empty;

        public string MultiplayerHostName
        {
            get
            {
                return _multiplayerHostName;
            }

            set
            {
                _multiplayerHostName = StringHelpers.Limit(value, MultiplayerHostNameMaxLength) ?? string.Empty;
            }
        }

        public int CurrentRatingPromoPoints { get; set; }

        public int CurrentRatingWorsePromoPoints { get; set; }

        public int NewPromotion { get; set; }

        public int NextPromotionPercent { get; set; }

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

        public int MissionScore { get; set; }

        public int[] KillsFullOnPlayer { get; set; } = new int[8];

        public int[] KillsSharedOnPlayer { get; set; } = new int[8];

        public int[] KillsFullOnFlightGroup { get; set; } = new int[192];

        public int[] KillsSharedOnFlightGroup { get; set; } = new int[192];

        public int[] KillsFullFromPlayer { get; set; } = new int[8];

        public int[] KillsSharedFromPlayer { get; set; } = new int[8];

        public int[] KillsFullFromFlightGroup { get; set; } = new int[192];

        public int[] KillsSharedFromFlightGroup { get; set; } = new int[192];

        public PilotRating[] FlightGroupRating { get; set; } = new PilotRating[192];

        public PilotObjectStats ObjectStats { get; set; } = new PilotObjectStats();

        public PilotMission[] TourOfDutyMissionStatistics { get; set; } = Enumerable.Range(0, 255).Select(t => new PilotMission()).ToArray();

        public PilotMission[] CombatChamberMissionStatistics { get; set; } = Enumerable.Range(0, 255).Select(t => new PilotMission()).ToArray();

        public byte[] CraftKnown { get; set; } = new byte[512];

        public int NewCraftAddedToTechRoom { get; set; }

        public PilotRating PilotRating { get; set; }

        public PilotRank PilotRank { get; set; }

        public int KalidorCresent { get; set; }

        public int TotalMissionsPlayedCount { get; set; }

        public int[] TotalMissionsPlayedCountPerRating { get; set; } = new int[25];

        private string _pilotRatingName = string.Empty;

        public string PilotRatingName
        {
            get
            {
                return _pilotRatingName;
            }

            set
            {
                _pilotRatingName = StringHelpers.Limit(value, PilotRatingNameMaxLength) ?? string.Empty;
            }
        }

        public int EmkayAnnounceNewAward { get; set; }

        public int EmkayAnnounceNewRank { get; set; }

        public int FamilyNewMedal { get; set; }

        public int TacOfficerAnnounceNewRank { get; set; }

        public PilotNetworkPlayer[] NetworkPlayers { get; set; } = Enumerable.Range(0, 8).Select(t => new PilotNetworkPlayer()).ToArray();

        public PilotTeam[] TeamsStatistics { get; set; } = Enumerable.Range(0, 10).Select(t => new PilotTeam()).ToArray();

        public PilotFactionId CurrentFactionId { get; set; }

        public PilotFaction[] FactionStatistics { get; set; } = Enumerable.Range(0, 4).Select(t => new PilotFaction()).ToArray();

        public byte[] EmailsStatus { get; set; } = new byte[100];

        public byte EmailsSortCriterion { get; set; }

        public int CampaignMode { get; set; }

        public int SkipMissionsRemaining { get; set; }

        public int RegionsCount { get; set; }

        private string _missionFileName = string.Empty;

        public string MissionFileName
        {
            get
            {
                return _missionFileName;
            }

            set
            {
                _missionFileName = StringHelpers.Limit(value, MissionFileNameMaxLength) ?? string.Empty;
            }
        }

        public byte[] ProvingGroundsMissionPerPlayer { get; set; } = new byte[8];

        public int MeleeMissionIndex { get; set; }

        public PilotHangar HangarType { get; set; }

        public static PilotFile FromFile(string? fileName)
        {
            if (fileName is null)
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            using var filestream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            return FromStream(filestream);
        }

        public static PilotFile FromStream(Stream? stream)
        {
            if (stream is null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            using var file = new BinaryReader(stream, Encoding.ASCII, true);

            PilotFile pilot = new();

            pilot.Name = StringHelpers.Read(file, NameMaxLength);
            pilot.TotalScore = file.ReadInt32();
            file.BaseStream.Seek(8, SeekOrigin.Current);
            file.ReadInt32();
            pilot.NumHumanPlayersLastMission = file.ReadInt32();
            pilot.M00022_ABD7B4 = file.ReadInt32();
            pilot.Team = file.ReadInt32();
            pilot.MissionDirectoryId = (PilotMissionDirectory)file.ReadInt32();
            ArrayHelpers.ReadInt(file, pilot.MissionDescriptionIds);
            pilot.MultiplayerGameName = StringHelpers.Read(file, MultiplayerGameNameMaxLength);
            pilot.MultiplayerHostName = StringHelpers.Read(file, MultiplayerHostNameMaxLength);
            file.ReadInt32();
            pilot.CurrentRatingPromoPoints = file.ReadInt32();
            pilot.CurrentRatingWorsePromoPoints = file.ReadInt32();
            pilot.NewPromotion = file.ReadInt32();
            pilot.NextPromotionPercent = file.ReadInt32();
            ArrayHelpers.ReadInt(file, pilot.TotalScorePerMissionType);
            ArrayHelpers.ReadInt(file, pilot.TotalMissionsPlayedCountPerMissionType);
            ArrayHelpers.ReadInt(file, pilot.TotalKillsPerMissionType);
            ArrayHelpers.ReadInt(file, pilot.TotalFriendliesKilledPerMissionType);
            ArrayHelpers.ReadInt2(file, pilot.KillsPerCraftPerMissionType);
            ArrayHelpers.ReadInt2(file, pilot.KillsSharedPerCraftPerMissionType);
            ArrayHelpers.ReadInt2(file, pilot.KillsAssistsPerCraftPerMissionType);
            ArrayHelpers.ReadInt2(file, pilot.KillsFullOnPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, pilot.KillsSharedOnPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, pilot.KillsAssistOnPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, pilot.KillsFullOnAIRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, pilot.KillsSharedOnAIRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, pilot.KillsAssistOnAIRatingPerMissionType);
            ArrayHelpers.ReadInt(file, pilot.NumOfSpecialCraftInspectedPerMissionType);
            ArrayHelpers.ReadInt(file, pilot.EnergyWeaponsHitsPerMissionType);
            ArrayHelpers.ReadInt(file, pilot.EnergyWeaponsFiredPerMissionType);
            ArrayHelpers.ReadInt(file, pilot.WarheadsHitsPerMissionType);
            ArrayHelpers.ReadInt(file, pilot.WarheadsFiredPerMissionType);
            ArrayHelpers.ReadInt(file, pilot.TotalCraftLossesPerMissionType);
            ArrayHelpers.ReadInt(file, pilot.LossesByCollisionsPerMissionType);
            ArrayHelpers.ReadInt(file, pilot.LossesByStarshipsPerMissionType);
            ArrayHelpers.ReadInt(file, pilot.LossesByMinesPerMissionType);
            ArrayHelpers.ReadInt2(file, pilot.KilledByPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, pilot.KilledByAIRatingPerMissionType);
            pilot.MissionScore = file.ReadInt32();
            ArrayHelpers.ReadInt(file, pilot.KillsFullOnPlayer);
            ArrayHelpers.ReadInt(file, pilot.KillsSharedOnPlayer);
            ArrayHelpers.ReadInt(file, pilot.KillsFullOnFlightGroup);
            ArrayHelpers.ReadInt(file, pilot.KillsSharedOnFlightGroup);
            ArrayHelpers.ReadInt(file, pilot.KillsFullFromPlayer);
            ArrayHelpers.ReadInt(file, pilot.KillsSharedFromPlayer);
            ArrayHelpers.ReadInt(file, pilot.KillsFullFromFlightGroup);
            ArrayHelpers.ReadInt(file, pilot.KillsSharedFromFlightGroup);
            ArrayHelpers.ReadEnum(file, pilot.FlightGroupRating);

            ReadObjectStats(pilot.ObjectStats, file);

            for (int i = 0; i < pilot.TourOfDutyMissionStatistics.Length; i++)
            {
                ReadMission(pilot.TourOfDutyMissionStatistics[i], file);
            }

            for (int i = 0; i < pilot.CombatChamberMissionStatistics.Length; i++)
            {
                ReadMission(pilot.CombatChamberMissionStatistics[i], file);
            }

            ArrayHelpers.ReadByte(file, pilot.CraftKnown);
            pilot.NewCraftAddedToTechRoom = file.ReadInt32();
            pilot.PilotRating = (PilotRating)file.ReadInt32();
            pilot.PilotRank = (PilotRank)file.ReadInt32();
            pilot.KalidorCresent = file.ReadInt32();
            pilot.TotalMissionsPlayedCount = file.ReadInt32();
            ArrayHelpers.ReadInt(file, pilot.TotalMissionsPlayedCountPerRating);
            pilot.PilotRatingName = StringHelpers.Read(file, PilotRatingNameMaxLength);
            pilot.EmkayAnnounceNewAward = file.ReadInt32();
            pilot.EmkayAnnounceNewRank = file.ReadInt32();
            pilot.FamilyNewMedal = file.ReadInt32();
            pilot.TacOfficerAnnounceNewRank = file.ReadInt32();

            for (int i = 0; i < pilot.NetworkPlayers.Length; i++)
            {
                ReadNetworkPlayer(pilot.NetworkPlayers[i], file);
            }

            for (int i = 0; i < pilot.TeamsStatistics.Length; i++)
            {
                ReadTeam(pilot.TeamsStatistics[i], file);
            }

            pilot.CurrentFactionId = (PilotFactionId)file.ReadInt32();

            for (int i = 0; i < pilot.FactionStatistics.Length; i++)
            {
                ReadFaction(pilot.FactionStatistics[i], file);
            }

            ArrayHelpers.ReadByte(file, pilot.EmailsStatus);
            pilot.EmailsSortCriterion = file.ReadByte();
            pilot.CampaignMode = file.ReadInt32();
            pilot.SkipMissionsRemaining = file.ReadInt32();
            pilot.RegionsCount = file.ReadInt32();
            pilot.MissionFileName = StringHelpers.Read(file, MissionFileNameMaxLength);
            ArrayHelpers.ReadByte(file, pilot.ProvingGroundsMissionPerPlayer);
            pilot.MeleeMissionIndex = file.ReadInt32();
            pilot.HangarType = (PilotHangar)file.ReadByte();

            return pilot;
        }

        private static void ReadObjectStats(PilotObjectStats objectStats, BinaryReader file)
        {
            ArrayHelpers.ReadInt(file, objectStats.TotalScorePerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.TotalMissionsPlayedCountPerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.TotalKillsPerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.TotalFriendliesKilledPerMissionType);
            ArrayHelpers.ReadInt2(file, objectStats.KillsPerCraftPerMissionType);
            ArrayHelpers.ReadInt2(file, objectStats.KillsSharedPerCraftPerMissionType);
            ArrayHelpers.ReadInt2(file, objectStats.KillsAssistsPerCraftPerMissionType);
            ArrayHelpers.ReadInt2(file, objectStats.KillsFullOnPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, objectStats.KillsSharedOnPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, objectStats.KillsAssistOnPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, objectStats.KillsFullOnAIRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, objectStats.KillsSharedOnAIRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, objectStats.KillsAssistOnAIRatingPerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.NumOfSpecialCraftInspectedPerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.EnergyWeaponsHitsPerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.EnergyWeaponsFiredPerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.WarheadsHitsPerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.WarheadsFiredPerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.TotalCraftLossesPerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.LossesByCollisionsPerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.LossesByStarshipsPerMissionType);
            ArrayHelpers.ReadInt(file, objectStats.LossesByMinesPerMissionType);
            ArrayHelpers.ReadInt2(file, objectStats.KilledByPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, objectStats.KilledByAIRatingPerMissionType);
        }

        private static void ReadMission(PilotMission mission, BinaryReader file)
        {
            mission.M00 = file.ReadInt32();
            mission.NumberTimesFlown = file.ReadInt32();
            mission.M08 = file.ReadInt32();
            mission.M0C = file.ReadInt32();
            mission.M10 = file.ReadInt32();
            mission.M14 = file.ReadInt32();
            mission.M18 = file.ReadInt32();
            mission.BestScore = file.ReadInt32();
            mission.BestTime = file.ReadInt32();
            mission.M24 = file.ReadInt32();
            mission.AwardId = file.ReadInt32();
            mission.BestBonus = file.ReadInt32();
        }

        private static void ReadNetworkPlayer(PilotNetworkPlayer player, BinaryReader file)
        {
            player.FormalName = StringHelpers.Read(file, PilotNetworkPlayer.FormalNameMaxLength);
            player.FriendlyName = StringHelpers.Read(file, PilotNetworkPlayer.FriendlyNameMaxLength);
            player.FlightGroupId = file.ReadInt32();
            player.M20 = file.ReadInt32();
            player.DirectPlayId = file.ReadInt32();
            player.Rating = file.ReadInt32();
            player.TotalScore = file.ReadInt32();
            player.Kills = file.ReadInt32();
            player.KillsShared = file.ReadInt32();
            player.M38 = file.ReadInt32();
            player.KillsAssist = file.ReadInt32();
            player.TotalLosses = file.ReadInt32();
            player.M44 = file.ReadInt32();
            player.CraftId = file.ReadInt32();
            player.WarheadType = file.ReadInt32();
            player.BeamType = file.ReadInt32();
            player.CounterMeasuresType = file.ReadInt32();
            player.CraftsCount = file.ReadInt32();
            player.WavesCount = file.ReadInt32();
            player.M60 = file.ReadInt32();
        }

        private static void ReadTeam(PilotTeam team, BinaryReader file)
        {
            team.MissionScore = file.ReadInt32();
            team.IsMissionCompleted = file.ReadInt32() != 0;
            team.M08 = file.ReadInt32();
            team.MissionTime = file.ReadInt32();
            team.Kills = file.ReadInt32();
            team.KillsShared = file.ReadInt32();
            team.KillsAssist = file.ReadInt32();
        }

        private static void ReadFaction(PilotFaction faction, BinaryReader file)
        {
            faction.TotalMissionsPlayedCount = file.ReadInt32();
            faction.Team = file.ReadInt32();
            faction.MissionDirectoryId = (PilotMissionDirectory)file.ReadInt32();
            ArrayHelpers.ReadInt(file, faction.MissionDescriptionIds);
            file.BaseStream.Seek(32, SeekOrigin.Current);
            faction.M0048 = file.ReadInt32();
            ArrayHelpers.ReadInt(file, faction.AwardsCount1);
            ArrayHelpers.ReadInt(file, faction.M0064);
            ArrayHelpers.ReadInt(file, faction.AwardsCount2);
            ArrayHelpers.ReadInt(file, faction.M0094);
            ArrayHelpers.ReadInt(file, faction.KalidorCrescentPoints);
            file.BaseStream.Seek(12, SeekOrigin.Current);
            faction.Score = file.ReadInt32();
            file.BaseStream.Seek(4, SeekOrigin.Current);
            faction.BonusScore = file.ReadInt32();
            faction.TotalScore = file.ReadInt32();
            ArrayHelpers.ReadInt(file, faction.TotalScorePerMissionType);
            ArrayHelpers.ReadInt(file, faction.TotalMissionsPlayedCountPerMissionType);
            ArrayHelpers.ReadInt(file, faction.TotalKillsPerMissionType);
            ArrayHelpers.ReadInt(file, faction.TotalFriendliesKilledPerMissionType);
            ArrayHelpers.ReadInt2(file, faction.KillsPerCraftPerMissionType);
            ArrayHelpers.ReadInt2(file, faction.KillsSharedPerCraftPerMissionType);
            ArrayHelpers.ReadInt2(file, faction.KillsAssistsPerCraftPerMissionType);
            ArrayHelpers.ReadInt2(file, faction.KillsFullOnPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, faction.KillsSharedOnPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, faction.KillsAssistOnPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, faction.KillsFullOnAIRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, faction.KillsSharedOnAIRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, faction.KillsAssistOnAIRatingPerMissionType);
            ArrayHelpers.ReadInt(file, faction.NumOfSpecialCraftInspectedPerMissionType);
            ArrayHelpers.ReadInt(file, faction.EnergyWeaponsHitsPerMissionType);
            ArrayHelpers.ReadInt(file, faction.EnergyWeaponsFiredPerMissionType);
            ArrayHelpers.ReadInt(file, faction.WarheadsHitsPerMissionType);
            ArrayHelpers.ReadInt(file, faction.WarheadsFiredPerMissionType);
            ArrayHelpers.ReadInt(file, faction.TotalCraftLossesPerMissionType);
            ArrayHelpers.ReadInt(file, faction.LossesByCollisionsPerMissionType);
            ArrayHelpers.ReadInt(file, faction.LossesByStarshipsPerMissionType);
            ArrayHelpers.ReadInt(file, faction.LossesByMinesPerMissionType);
            ArrayHelpers.ReadInt2(file, faction.KilledByPlayerRatingPerMissionType);
            ArrayHelpers.ReadInt2(file, faction.KilledByAIRatingPerMissionType);
        }

        public void Save(string? fileName)
        {
            if (fileName is null)
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            using var filestream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            Save(filestream);
        }

        public void Save(Stream? stream)
        {
            if (stream is null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            using var file = new BinaryWriter(stream, Encoding.ASCII, true);

            file.Write(StringHelpers.GetBytes(Name, NameMaxLength));
            file.Write(TotalScore);
            file.Write(new byte[8]);
            file.Write(1);
            file.Write(NumHumanPlayersLastMission);
            file.Write(M00022_ABD7B4);
            file.Write(Team);
            file.Write((int)MissionDirectoryId);
            ArrayHelpers.WriteInt(file, MissionDescriptionIds);
            file.Write(StringHelpers.GetBytes(MultiplayerGameName, MultiplayerGameNameMaxLength));
            file.Write(StringHelpers.GetBytes(MultiplayerHostName, MultiplayerHostNameMaxLength));
            file.Write(0);
            file.Write(CurrentRatingPromoPoints);
            file.Write(CurrentRatingWorsePromoPoints);
            file.Write(NewPromotion);
            file.Write(NextPromotionPercent);
            ArrayHelpers.WriteInt(file, TotalScorePerMissionType);
            ArrayHelpers.WriteInt(file, TotalMissionsPlayedCountPerMissionType);
            ArrayHelpers.WriteInt(file, TotalKillsPerMissionType);
            ArrayHelpers.WriteInt(file, TotalFriendliesKilledPerMissionType);
            ArrayHelpers.WriteInt2(file, KillsPerCraftPerMissionType);
            ArrayHelpers.WriteInt2(file, KillsSharedPerCraftPerMissionType);
            ArrayHelpers.WriteInt2(file, KillsAssistsPerCraftPerMissionType);
            ArrayHelpers.WriteInt2(file, KillsFullOnPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, KillsSharedOnPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, KillsAssistOnPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, KillsFullOnAIRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, KillsSharedOnAIRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, KillsAssistOnAIRatingPerMissionType);
            ArrayHelpers.WriteInt(file, NumOfSpecialCraftInspectedPerMissionType);
            ArrayHelpers.WriteInt(file, EnergyWeaponsHitsPerMissionType);
            ArrayHelpers.WriteInt(file, EnergyWeaponsFiredPerMissionType);
            ArrayHelpers.WriteInt(file, WarheadsHitsPerMissionType);
            ArrayHelpers.WriteInt(file, WarheadsFiredPerMissionType);
            ArrayHelpers.WriteInt(file, TotalCraftLossesPerMissionType);
            ArrayHelpers.WriteInt(file, LossesByCollisionsPerMissionType);
            ArrayHelpers.WriteInt(file, LossesByStarshipsPerMissionType);
            ArrayHelpers.WriteInt(file, LossesByMinesPerMissionType);
            ArrayHelpers.WriteInt2(file, KilledByPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, KilledByAIRatingPerMissionType);
            file.Write(MissionScore);
            ArrayHelpers.WriteInt(file, KillsFullOnPlayer);
            ArrayHelpers.WriteInt(file, KillsSharedOnPlayer);
            ArrayHelpers.WriteInt(file, KillsFullOnFlightGroup);
            ArrayHelpers.WriteInt(file, KillsSharedOnFlightGroup);
            ArrayHelpers.WriteInt(file, KillsFullFromPlayer);
            ArrayHelpers.WriteInt(file, KillsSharedFromPlayer);
            ArrayHelpers.WriteInt(file, KillsFullFromFlightGroup);
            ArrayHelpers.WriteInt(file, KillsSharedFromFlightGroup);
            ArrayHelpers.WriteEnum(file, FlightGroupRating);

            WriteObjectStats(ObjectStats, file);

            for (int i = 0; i < TourOfDutyMissionStatistics.Length; i++)
            {
                WriteMission(TourOfDutyMissionStatistics[i], file);
            }

            for (int i = 0; i < CombatChamberMissionStatistics.Length; i++)
            {
                WriteMission(CombatChamberMissionStatistics[i], file);
            }

            ArrayHelpers.WriteByte(file, CraftKnown);
            file.Write(NewCraftAddedToTechRoom);
            file.Write((int)PilotRating);
            file.Write((int)PilotRank);
            file.Write(KalidorCresent);
            file.Write(TotalMissionsPlayedCount);
            ArrayHelpers.WriteInt(file, TotalMissionsPlayedCountPerRating);
            file.Write(StringHelpers.GetBytes(PilotRatingName, PilotRatingNameMaxLength));
            file.Write(EmkayAnnounceNewAward);
            file.Write(EmkayAnnounceNewRank);
            file.Write(FamilyNewMedal);
            file.Write(TacOfficerAnnounceNewRank);

            for (int i = 0; i < NetworkPlayers.Length; i++)
            {
                WriteNetworkPlayer(NetworkPlayers[i], file);
            }

            for (int i = 0; i < TeamsStatistics.Length; i++)
            {
                WriteTeam(TeamsStatistics[i], file);
            }

            file.Write((int)CurrentFactionId);

            for (int i = 0; i < FactionStatistics.Length; i++)
            {
                WriteFaction(FactionStatistics[i], file);
            }

            ArrayHelpers.WriteByte(file, EmailsStatus);
            file.Write(EmailsSortCriterion);
            file.Write(CampaignMode);
            file.Write(SkipMissionsRemaining);
            file.Write(RegionsCount);
            file.Write(StringHelpers.GetBytes(MissionFileName, MissionFileNameMaxLength));
            ArrayHelpers.WriteByte(file, ProvingGroundsMissionPerPlayer);
            file.Write(MeleeMissionIndex);
            file.Write((byte)HangarType);
        }

        private static void WriteObjectStats(PilotObjectStats objectStats, BinaryWriter file)
        {
            ArrayHelpers.WriteInt(file, objectStats.TotalScorePerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.TotalMissionsPlayedCountPerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.TotalKillsPerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.TotalFriendliesKilledPerMissionType);
            ArrayHelpers.WriteInt2(file, objectStats.KillsPerCraftPerMissionType);
            ArrayHelpers.WriteInt2(file, objectStats.KillsSharedPerCraftPerMissionType);
            ArrayHelpers.WriteInt2(file, objectStats.KillsAssistsPerCraftPerMissionType);
            ArrayHelpers.WriteInt2(file, objectStats.KillsFullOnPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, objectStats.KillsSharedOnPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, objectStats.KillsAssistOnPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, objectStats.KillsFullOnAIRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, objectStats.KillsSharedOnAIRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, objectStats.KillsAssistOnAIRatingPerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.NumOfSpecialCraftInspectedPerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.EnergyWeaponsHitsPerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.EnergyWeaponsFiredPerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.WarheadsHitsPerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.WarheadsFiredPerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.TotalCraftLossesPerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.LossesByCollisionsPerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.LossesByStarshipsPerMissionType);
            ArrayHelpers.WriteInt(file, objectStats.LossesByMinesPerMissionType);
            ArrayHelpers.WriteInt2(file, objectStats.KilledByPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, objectStats.KilledByAIRatingPerMissionType);
        }

        private static void WriteMission(PilotMission mission, BinaryWriter file)
        {
            file.Write(mission.M00);
            file.Write(mission.NumberTimesFlown);
            file.Write(mission.M08);
            file.Write(mission.M0C);
            file.Write(mission.M10);
            file.Write(mission.M14);
            file.Write(mission.M18);
            file.Write(mission.BestScore);
            file.Write(mission.BestTime);
            file.Write(mission.M24);
            file.Write(mission.AwardId);
            file.Write(mission.BestBonus);
        }

        private static void WriteNetworkPlayer(PilotNetworkPlayer player, BinaryWriter file)
        {
            file.Write(StringHelpers.GetBytes(player.FormalName, PilotNetworkPlayer.FormalNameMaxLength));
            file.Write(StringHelpers.GetBytes(player.FriendlyName, PilotNetworkPlayer.FriendlyNameMaxLength));
            file.Write(player.FlightGroupId);
            file.Write(player.M20);
            file.Write(player.DirectPlayId);
            file.Write(player.Rating);
            file.Write(player.TotalScore);
            file.Write(player.Kills);
            file.Write(player.KillsShared);
            file.Write(player.M38);
            file.Write(player.KillsAssist);
            file.Write(player.TotalLosses);
            file.Write(player.M44);
            file.Write(player.CraftId);
            file.Write(player.WarheadType);
            file.Write(player.BeamType);
            file.Write(player.CounterMeasuresType);
            file.Write(player.CraftsCount);
            file.Write(player.WavesCount);
            file.Write(player.M60);
        }

        private static void WriteTeam(PilotTeam team, BinaryWriter file)
        {
            file.Write(team.MissionScore);
            file.Write(team.IsMissionCompleted ? 1 : 0);
            file.Write(team.M08);
            file.Write(team.MissionTime);
            file.Write(team.Kills);
            file.Write(team.KillsShared);
            file.Write(team.KillsAssist);
        }

        private static void WriteFaction(PilotFaction faction, BinaryWriter file)
        {
            file.Write(faction.TotalMissionsPlayedCount);
            file.Write(faction.Team);
            file.Write((int)faction.MissionDirectoryId);
            ArrayHelpers.WriteInt(file, faction.MissionDescriptionIds);
            file.Write(new byte[32]);
            file.Write(faction.M0048);
            ArrayHelpers.WriteInt(file, faction.AwardsCount1);
            ArrayHelpers.WriteInt(file, faction.M0064);
            ArrayHelpers.WriteInt(file, faction.AwardsCount2);
            ArrayHelpers.WriteInt(file, faction.M0094);
            ArrayHelpers.WriteInt(file, faction.KalidorCrescentPoints);
            file.Write(new byte[12]);
            file.Write(faction.Score);
            file.Write(new byte[4]);
            file.Write(faction.BonusScore);
            file.Write(faction.TotalScore);
            ArrayHelpers.WriteInt(file, faction.TotalScorePerMissionType);
            ArrayHelpers.WriteInt(file, faction.TotalMissionsPlayedCountPerMissionType);
            ArrayHelpers.WriteInt(file, faction.TotalKillsPerMissionType);
            ArrayHelpers.WriteInt(file, faction.TotalFriendliesKilledPerMissionType);
            ArrayHelpers.WriteInt2(file, faction.KillsPerCraftPerMissionType);
            ArrayHelpers.WriteInt2(file, faction.KillsSharedPerCraftPerMissionType);
            ArrayHelpers.WriteInt2(file, faction.KillsAssistsPerCraftPerMissionType);
            ArrayHelpers.WriteInt2(file, faction.KillsFullOnPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, faction.KillsSharedOnPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, faction.KillsAssistOnPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, faction.KillsFullOnAIRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, faction.KillsSharedOnAIRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, faction.KillsAssistOnAIRatingPerMissionType);
            ArrayHelpers.WriteInt(file, faction.NumOfSpecialCraftInspectedPerMissionType);
            ArrayHelpers.WriteInt(file, faction.EnergyWeaponsHitsPerMissionType);
            ArrayHelpers.WriteInt(file, faction.EnergyWeaponsFiredPerMissionType);
            ArrayHelpers.WriteInt(file, faction.WarheadsHitsPerMissionType);
            ArrayHelpers.WriteInt(file, faction.WarheadsFiredPerMissionType);
            ArrayHelpers.WriteInt(file, faction.TotalCraftLossesPerMissionType);
            ArrayHelpers.WriteInt(file, faction.LossesByCollisionsPerMissionType);
            ArrayHelpers.WriteInt(file, faction.LossesByStarshipsPerMissionType);
            ArrayHelpers.WriteInt(file, faction.LossesByMinesPerMissionType);
            ArrayHelpers.WriteInt2(file, faction.KilledByPlayerRatingPerMissionType);
            ArrayHelpers.WriteInt2(file, faction.KilledByAIRatingPerMissionType);
        }
    }
}
