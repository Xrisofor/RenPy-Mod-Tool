﻿using System.Collections.Generic;

namespace ModTool
{
    public enum ModType
    {
        ModRenPy,
        ModeVisualScript,
        SnakeSkin,
        SnakeMode,
        FlappyBirdSkin,
        FlappyBirdMode
    }

    public class Project
    {
        public string Name { get; set; }

        public string Description { get; set; } = "My new modification. It's without a description, but I can always change it in the modification tool.";

        public uint SteamID { get; set; } = 0;

        public ModType Type { get; set; }

        public string Image {  get; set; } = string.Empty;

        public IList<string> Tags { get; set; } = new List<string>();

        public Project(string name, ModType type)
        {
            Name = name; Type = type;

            Description = Config.GetText("project_description");

            switch (Type)
            {
                case ModType.ModRenPy:
                    break;

                case ModType.SnakeSkin:
                    Tags.Add("New Snake Skin");
                    break;

                case ModType.FlappyBirdSkin:
                    Tags.Add("New Flappy Bird Skin");
                    break;

                case ModType.SnakeMode:
                    Tags.Add("New Snake Mode");
                    break;

                case ModType.FlappyBirdMode:
                    Tags.Add("New Flappy Bird Mode");
                    break;
            }
        }
    }
}
