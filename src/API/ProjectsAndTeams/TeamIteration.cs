﻿namespace RestAPI.ProjectsAndTeams
{
    public class TeamIterations
    {
        public class TeamIteration
        {
            public string TeamName { get; set; }
            public List<string> Iterations { get; set; }
        }
        public class Map
        {
            public List<TeamIteration> TeamIterationMap { get; set; }
        }
    }
}
