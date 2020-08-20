﻿namespace UndergroundSecrets
{
    public class ModConfig
    {
        public bool EnableMod { get; set; } = true;
        public float TilePuzzleBaseChance { get; set; } = 0.001f;
        public float LightPuzzleBaseChance { get; set; } = 0.001f;
        public float OfferingPuzzleBaseChance { get; set; } = 0.001f;
        public float AltarBaseChance { get; set; } = 0.001f;
        public float RiddlesBaseChance { get; set; } = 0.001f;
        public float CollapsedBaseFloorMaxPortion { get; set; } = 0.0001f;
        public float TrapsBaseMaxPortion { get; set; } = 0.0001f;
        public float MushroomTreesMaxPortion { get; set; } = 0.005f;
        public float DisarmTrapsBaseChanceModifier { get; set; } = 1f;
        public bool ShowTrapNotifications { get; set; } = true;
        public float AltarBuffMult { get; set; } = 0.5f;
        public bool OverrideTreasureRooms { get; set; } = true;
        public float TrapDamageMult { get; set; } = 2f;
    }
}
