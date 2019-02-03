using System;

namespace StatInkClientDotNet.RawModels
{

    public class Agent
    {
        public string name { get; set; }
        public string version { get; set; }
        public object game_version { get; set; }
        public object game_version_date { get; set; }
        public object custom { get; set; }
        public Variables variables { get; set; }
    }
    public class Brand
    {
        public string key { get; set; }
        public Name name { get; set; }
        public Strength strength { get; set; }
        public Weakness weakness { get; set; }
    }
    public class Category
    {
        public string key { get; set; }
        public Name name { get; set; }
    }

    public class BattleData
    {
        public int id { get; set; }
        public int splatnet_number { get; set; }
        public string url { get; set; }
        public User user { get; set; }
        public Lobby lobby { get; set; }
        public Mode mode { get; set; }
        public Rule rule { get; set; }
        public Map map { get; set; }
        public Weapon weapon { get; set; }
        public Rank rank { get; set; }
        public object rank_exp { get; set; }
        public Rank_After rank_after { get; set; }
        public object rank_exp_after { get; set; }
        public float? x_power { get; set; }
        public float? x_power_after { get; set; }
        public object estimate_x_power { get; set; }
        public int level { get; set; }
        public int level_after { get; set; }
        public int star_rank { get; set; }
        public string result { get; set; }
        public bool? knock_out { get; set; }
        public int rank_in_team { get; set; }
        public int kill { get; set; }
        public int death { get; set; }
        public int kill_or_assist { get; set; }
        public int special { get; set; }
        public float? kill_ratio { get; set; }
        public float? kill_rate { get; set; }
        public object max_kill_combo { get; set; }
        public object max_kill_streak { get; set; }
        public object[] death_reasons { get; set; }
        public int my_point { get; set; }
        public object estimate_gachi_power { get; set; }
        public string league_point { get; set; }
        public int? my_team_estimate_league_point { get; set; }
        public int? his_team_estimate_league_point { get; set; }
        public object my_team_point { get; set; }
        public object his_team_point { get; set; }
        public object my_team_percent { get; set; }
        public object his_team_percent { get; set; }
        public int? my_team_count { get; set; }
        public int? his_team_count { get; set; }
        public string my_team_id { get; set; }
        public object his_team_id { get; set; }
        public Species species { get; set; }
        public Gender gender { get; set; }
        public object fest_title { get; set; }
        public object fest_exp { get; set; }
        public object fest_title_after { get; set; }
        public object fest_exp_after { get; set; }
        public object fest_power { get; set; }
        public object my_team_estimate_fest_power { get; set; }
        public object his_team_my_team_estimate_fest_power { get; set; }
        public object my_team_fest_theme { get; set; }
        public object his_team_fest_theme { get; set; }
        public object my_team_nickname { get; set; }
        public object his_team_nickname { get; set; }
        public object clout { get; set; }
        public object total_clout { get; set; }
        public object total_clout_after { get; set; }
        public object my_team_win_streak { get; set; }
        public object his_team_win_streak { get; set; }
        public object synergy_bonus { get; set; }
        public object special_battle { get; set; }
        public object image_judge { get; set; }
        public string image_result { get; set; }
        public string image_gear { get; set; }
        public Gears gears { get; set; }
        public int period { get; set; }
        public string period_range { get; set; }
        public Player[] players { get; set; }
        public object events { get; set; }
        public object splatnet_json { get; set; }
        public Agent agent { get; set; }
        public bool automated { get; set; }
        public object environment { get; set; }
        public object link_url { get; set; }
        public object note { get; set; }
        public string game_version { get; set; }
        public object nawabari_bonus { get; set; }
        public Start_At start_at { get; set; }
        public End_At end_at { get; set; }
        public Register_At register_at { get; set; }
    }
    public class Clothing
    {
        public Gear gear { get; set; }
        public Primary_Ability primary_ability { get; set; }
        public Secondary_Abilities[] secondary_abilities { get; set; }
    }
    public class End_At
    {
        public int time { get; set; }
        public DateTime iso8601 { get; set; }
    }

    public class Gear
    {
        public string key { get; set; }
        public GearType type { get; set; }
        public Brand brand { get; set; }
        public Name name { get; set; }
        public Primary_Ability primary_ability { get; set; }
        public int splatnet { get; set; }
    }
    public class Gears
    {
        public Headgear headgear { get; set; }
        public Clothing clothing { get; set; }
        public Shoes shoes { get; set; }
    }
    public class Gender
    {
        public string key { get; set; }
        public int iso5218 { get; set; }
        public Name name { get; set; }
    }

    public class Headgear
    {
        public Gear gear { get; set; }
        public Primary_Ability primary_ability { get; set; }
        public Secondary_Abilities[] secondary_abilities { get; set; }
    }
    public class Join_At
    {
        public int time { get; set; }
        public DateTime iso8601 { get; set; }
    }
    public class Lobby
    {
        public string key { get; set; }
        public Name name { get; set; }
    }
    public class Map
    {
        public string key { get; set; }
        public int splatnet { get; set; }
        public Name name { get; set; }
        public Short_Name short_name { get; set; }
        public int? area { get; set; }
        public Release_At release_at { get; set; }
    }
    public class Mode
    {
        public string key { get; set; }
        public Name name { get; set; }
    }
    public class Name
    {
        public string ja_JP { get; set; }
        public string en_US { get; set; }
        public string en_GB { get; set; }
        public string es_ES { get; set; }
        public string es_MX { get; set; }
        public string fr_FR { get; set; }
        public string fr_CA { get; set; }
        public string de_DE { get; set; }
        public string it_IT { get; set; }
        public string nl_NL { get; set; }
        public string ru_RU { get; set; }
    }
    public class Player
    {
        public string team { get; set; }
        public bool is_me { get; set; }
        public Weapon weapon { get; set; }
        public int level { get; set; }
        public Rank rank { get; set; }
        public int star_rank { get; set; }
        public int rank_in_team { get; set; }
        public int kill { get; set; }
        public int death { get; set; }
        public int kill_or_assist { get; set; }
        public int special { get; set; }
        public object my_kill { get; set; }
        public int point { get; set; }
        public string name { get; set; }
        public Species species { get; set; }
        public Gender gender { get; set; }
        public object fest_title { get; set; }
        public string splatnet_id { get; set; }
        public bool top_500 { get; set; }
        public string icon { get; set; }
    }
    public class Primary_Ability
    {
        public string key { get; set; }
        public Name name { get; set; }
    }

    public class Profile
    {
        public object nnid { get; set; }
        public object friend_code { get; set; }
        public object twitter { get; set; }
        public object ikanakama { get; set; }
        public object ikanakama2 { get; set; }
        public object environment { get; set; }
    }
    public class Rank
    {
        public string key { get; set; }
        public Zone zone { get; set; }
        public Name name { get; set; }
    }
    public class Rank_After
    {
        public string key { get; set; }
        public Zone zone { get; set; }
        public Name name { get; set; }
    }

    public class Register_At
    {
        public int time { get; set; }
        public DateTime iso8601 { get; set; }
    }
    public class Release_At
    {
        public int time { get; set; }
        public DateTime iso8601 { get; set; }
    }
    public class Rootobject
    {
        public BattleData[] Property1 { get; set; }
    }
    public class Rule
    {
        public string key { get; set; }
        public Name name { get; set; }
    }
    public class Secondary_Abilities
    {
        public string key { get; set; }
        public Name name { get; set; }
    }
    public class Shoes
    {
        public Gear gear { get; set; }
        public Primary_Ability primary_ability { get; set; }
        public Secondary_Abilities[] secondary_abilities { get; set; }
    }
    public class Short_Name
    {
        public string ja_JP { get; set; }
        public string en_US { get; set; }
        public string en_GB { get; set; }
        public string es_ES { get; set; }
        public string es_MX { get; set; }
        public string fr_FR { get; set; }
        public string fr_CA { get; set; }
        public string de_DE { get; set; }
        public string it_IT { get; set; }
        public string nl_NL { get; set; }
        public string ru_RU { get; set; }
    }
    public class Special
    {
        public string key { get; set; }
        public Name name { get; set; }
    }
    public class Species
    {
        public string key { get; set; }
        public Name name { get; set; }
    }
    public class Start_At
    {
        public int time { get; set; }
        public DateTime iso8601 { get; set; }
    }
    public class Stats
    {
        public object v1 { get; set; }
        public object v2 { get; set; }
    }
    public class Strength
    {
        public string key { get; set; }
        public Name name { get; set; }
    }
    public class Sub
    {
        public string key { get; set; }
        public Name name { get; set; }
    }
    public class Type
    {
        public string key { get; set; }
        public Name name { get; set; }
        public Category category { get; set; }
    }
    public class GearType
    {
        public string key { get; set; }
        public Name name { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public string url { get; set; }
        public Join_At join_at { get; set; }
        public Profile profile { get; set; }
        public object stat { get; set; }
        public Stats stats { get; set; }
    }
    public class Variables
    {
        public string upload_mode { get; set; }
    }
    public class Weakness
    {
        public string key { get; set; }
        public Name name { get; set; }
    }
    public class Weapon
    {
        public string key { get; set; }
        public int splatnet { get; set; }
        public Type type { get; set; }
        public Name name { get; set; }
        public Sub sub { get; set; }
        public Special special { get; set; }
        public object reskin_of { get; set; }
        public string main_ref { get; set; }
    }
    public class Zone
    {
        public string key { get; set; }
        public Name name { get; set; }
    }
}
