using System;

namespace StatInkClientDotNet.RawModels
{
    public class Agent
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public object GameVersion { get; set; }
        public object GameVersionDate { get; set; }
        public object Custom { get; set; }
        public Variables Variables { get; set; }
    }

    public class Brand
    {
        public string Key { get; set; }
        public Name Name { get; set; }
        public Strength Strength { get; set; }
        public Weakness Weakness { get; set; }
    }

    public class Category
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class BattleData
    {
        public int Id { get; set; }
        public int SplatnetNumber { get; set; }
        public string Url { get; set; }
        public User User { get; set; }
        public Lobby Lobby { get; set; }
        public Mode Mode { get; set; }
        public Rule Rule { get; set; }
        public Map Map { get; set; }
        public Weapon Weapon { get; set; }
        public Rank Rank { get; set; }
        public object RankExp { get; set; }
        public RankAfter RankAfter { get; set; }
        public object RankExpAfter { get; set; }
        public float? XPower { get; set; }
        public float? XPowerAfter { get; set; }
        public object EstimateXPower { get; set; }
        public int Level { get; set; }
        public int LevelAfter { get; set; }
        public int StarRank { get; set; }
        public string Result { get; set; }
        public bool? KnockOut { get; set; }
        public int RankInTeam { get; set; }
        public int Kill { get; set; }
        public int Death { get; set; }
        public int KillOrAssist { get; set; }
        public int Special { get; set; }
        public float? KillRatio { get; set; }
        public float? KillRate { get; set; }
        public object MaxKillCombo { get; set; }
        public object MaxKillStreak { get; set; }
        public object[] DeathReasons { get; set; }
        public int MyPoint { get; set; }
        public object EstimateGachiPower { get; set; }
        public string LeaguePoint { get; set; }
        public int? MyTeamEstimateLeaguePoint { get; set; }
        public int? HisTeamEstimateLeaguePoint { get; set; }
        public object MyTeamPoint { get; set; }
        public object HisTeamPoint { get; set; }
        public object MyTeamPercent { get; set; }
        public object HisTeamPercent { get; set; }
        public int? MyTeamCount { get; set; }
        public int? HisTeamCount { get; set; }
        public string MyTeamId { get; set; }
        public object HisTeamId { get; set; }
        public Species Species { get; set; }
        public Gender Gender { get; set; }
        public object FestTitle { get; set; }
        public object FestExp { get; set; }
        public object FestTitleAfter { get; set; }
        public object FestExpAfter { get; set; }
        public object FestPower { get; set; }
        public object MyTeamEstimateFestPower { get; set; }
        public object HisTeamMyTeamEstimateFestPower { get; set; }
        public object MyTeamFestTheme { get; set; }
        public object HisTeamFestTheme { get; set; }
        public object MyTeamNickname { get; set; }
        public object HisTeamNickname { get; set; }
        public object Clout { get; set; }
        public object TotalClout { get; set; }
        public object TotalCloutAfter { get; set; }
        public object MyTeamWinStreak { get; set; }
        public object HisTeamWinStreak { get; set; }
        public object SynergyBonus { get; set; }
        public object SpecialBattle { get; set; }
        public object ImageJudge { get; set; }
        public string ImageResult { get; set; }
        public string ImageGear { get; set; }
        public Gears Gears { get; set; }
        public int Period { get; set; }
        public string PeriodRange { get; set; }
        public Player[] Players { get; set; }
        public object Events { get; set; }
        public object SplatnetJson { get; set; }
        public Agent Agent { get; set; }
        public bool Automated { get; set; }
        public object Environment { get; set; }
        public object LinkUrl { get; set; }
        public object Note { get; set; }
        public string GameVersion { get; set; }
        public object NawabariBonus { get; set; }
        public StartAt StartAt { get; set; }
        public EndAt EndAt { get; set; }
        public RegisterAt RegisterAt { get; set; }
    }

    public class Clothing
    {
        public Gear Gear { get; set; }
        public PrimaryAbility PrimaryAbility { get; set; }
        public SecondaryAbilities[] SecondaryAbilities { get; set; }
    }

    public class EndAt
    {
        public int Time { get; set; }
        public DateTime Iso8601 { get; set; }
    }

    public class Gear
    {
        public string Key { get; set; }
        public GearType Type { get; set; }
        public Brand Brand { get; set; }
        public Name Name { get; set; }
        public PrimaryAbility PrimaryAbility { get; set; }
        public int Splatnet { get; set; }
    }

    public class Gears
    {
        public Headgear Headgear { get; set; }
        public Clothing Clothing { get; set; }
        public Shoes Shoes { get; set; }
    }

    public class Gender
    {
        public string Key { get; set; }
        public int Iso5218 { get; set; }
        public Name Name { get; set; }
    }

    public class Headgear
    {
        public Gear Gear { get; set; }
        public PrimaryAbility PrimaryAbility { get; set; }
        public SecondaryAbilities[] SecondaryAbilities { get; set; }
    }
    public class JoinAt
    {
        public int Time { get; set; }
        public DateTime Iso8601 { get; set; }
    }

    public class Lobby
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class Map
    {
        public string Key { get; set; }
        public int Splatnet { get; set; }
        public Name Name { get; set; }
        public ShortName ShortName { get; set; }
        public int? Area { get; set; }
        public ReleaseAt ReleaseAt { get; set; }
    }

    public class Mode
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class Name
    {
        public string JaJP { get; set; }
        public string EnUS { get; set; }
        public string EnGB { get; set; }
        public string EsES { get; set; }
        public string EsMX { get; set; }
        public string FrFR { get; set; }
        public string FrCA { get; set; }
        public string DeDE { get; set; }
        public string ItIT { get; set; }
        public string NlNL { get; set; }
        public string RuRU { get; set; }
    }

    public class Player
    {
        public string Team { get; set; }
        public bool IsMe { get; set; }
        public Weapon Weapon { get; set; }
        public int Level { get; set; }
        public Rank Rank { get; set; }
        public int StarRank { get; set; }
        public int RankInTeam { get; set; }
        public int Kill { get; set; }
        public int Death { get; set; }
        public int KillOrAssist { get; set; }
        public int Special { get; set; }
        public object MyKill { get; set; }
        public int Point { get; set; }
        public string Name { get; set; }
        public Species Species { get; set; }
        public Gender Gender { get; set; }
        public object FestTitle { get; set; }
        public string SplatnetId { get; set; }
        public bool Top500 { get; set; }
        public string Icon { get; set; }
    }

    public class PrimaryAbility
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class Profile
    {
        public object Nnid { get; set; }
        public object FriendCode { get; set; }
        public object Twitter { get; set; }
        public object Ikanakama { get; set; }
        public object Ikanakama2 { get; set; }
        public object Environment { get; set; }
    }

    public class Rank
    {
        public string Key { get; set; }
        public Zone Zone { get; set; }
        public Name Name { get; set; }
    }

    public class RankAfter
    {
        public string Key { get; set; }
        public Zone Zone { get; set; }
        public Name Name { get; set; }
    }

    public class RegisterAt
    {
        public int Time { get; set; }
        public DateTime Iso8601 { get; set; }
    }

    public class ReleaseAt
    {
        public int Time { get; set; }
        public DateTime Iso8601 { get; set; }
    }

    public class Rootobject
    {
        public BattleData[] Property1 { get; set; }
    }

    public class Rule
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class SecondaryAbilities
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class Shoes
    {
        public Gear Gear { get; set; }
        public PrimaryAbility PrimaryAbility { get; set; }
        public SecondaryAbilities[] SecondaryAbilities { get; set; }
    }

    public class ShortName
    {
        public string JaJP { get; set; }
        public string EnUS { get; set; }
        public string EnGB { get; set; }
        public string EsES { get; set; }
        public string EsMX { get; set; }
        public string FrFR { get; set; }
        public string FrCA { get; set; }
        public string DeDE { get; set; }
        public string ItIT { get; set; }
        public string NlNL { get; set; }
        public string RuRU { get; set; }
    }

    public class Special
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class Species
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class StartAt
    {
        public int Time { get; set; }
        public DateTime Iso8601 { get; set; }
    }

    public class Stats
    {
        public object V1 { get; set; }
        public object V2 { get; set; }
    }

    public class Strength
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class Sub
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class Type
    {
        public string Key { get; set; }
        public Name Name { get; set; }
        public Category Category { get; set; }
    }

    public class GearType
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ScreenName { get; set; }
        public string Url { get; set; }
        public JoinAt JoinAt { get; set; }
        public Profile Profile { get; set; }
        public object Stat { get; set; }
        public Stats Stats { get; set; }
    }

    public class Variables
    {
        public string UploadMode { get; set; }
    }

    public class Weakness
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }

    public class Weapon
    {
        public string Key { get; set; }
        public int Splatnet { get; set; }
        public Type Type { get; set; }
        public Name Name { get; set; }
        public Sub Sub { get; set; }
        public Special Special { get; set; }
        public object ReskinOf { get; set; }
        public string MainRef { get; set; }
    }

    public class Zone
    {
        public string Key { get; set; }
        public Name Name { get; set; }
    }
}
