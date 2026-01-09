using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class GamingTournamentRegistrationSystem
    {
        public static List<GamingTournamentRegistrationSystem> AllPlayers = new();
        public string UserName { get; set; }
        public int Level { get; set; }
        public string Game { get; set; }
        public string TeamID { get; set; }
        public string GameAssignment { get; set; }
        public double EntryFee { get; set; }
        public string Warning { get; set; }
        public static double TotalRevenue = 0;
        public GamingTournamentRegistrationSystem(string userName) {
            UserName = userName;
            Level = 1;
            Game = "General";
            AssignGameCategory(1);
            calculateEntryFee();
            TeamID = "Solo";
            Register();
        }

        public GamingTournamentRegistrationSystem(string userName, int level) {
            UserName = userName;
            Level = level;
            Game = "General";
            calculateEntryFee();
            AssignGameCategory(level);
            if (Level > 50)
                skillBonus();
            TeamID = "Solo";
            Register();
        }

        public GamingTournamentRegistrationSystem(string userName, int level, string game) : this(userName, level)
        {
            Game = game;
            GameSpecificBonuses(Game);
        }

        public GamingTournamentRegistrationSystem(string userName, int level, string game, string teamID):this(userName, level, game)
        {
            TeamID = teamID;
        }
        public void calculateEntryFee()
        {
            EntryFee = Level * 50 + 200;
        }

        public void skillBonus()
        {
            EntryFee = EntryFee - EntryFee * 0.2;
        }

        public void GameSpecificBonuses(string Game)
        {
            if (Game == "CS")
                EntryFee += 100;
            else if (Game == "FIFA")
                EntryFee += 50;
        }

        public void Register()
        {
            TotalRevenue += EntryFee;
            AllPlayers.Add(this);
        }

        public void AssignGameCategory(int level)
        {
            if (level < 1 || level > 100)
            {
                Warning = "Level must be between 1 and 100";
                level = 20;
            }
            Level = level;
            if (level >= 1 && level <= 25)
                GameAssignment = "Beginner";
            else if (level > 25 && level <= 75)
                GameAssignment = "Intermediate";
            else if (level >= 76 && level <= 100)
                GameAssignment = "Expert";
        }
    }
}
