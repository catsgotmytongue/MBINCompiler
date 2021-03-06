﻿namespace MBINCompiler.Models.Structs
{
    public class GcPlayerNearbyEvent : NMSTemplate
    {
        public int RequirePlayerAction;
        public string[] RequirePlayerActionValues()
        {
            return new[] { "None", "Fire", "InShip", "OnFoot", "OnFootOutside", "Upload" };
        }
        public float Distance;
        public float Angle;
        public bool AnglePlayerRelative;
        public float AngleOffset;
        public bool AngleReflected;
        public float AngleMinDistance;
        public int DistanceCheckType;
        public string[] DistanceCheckTypeValues()
        {
            return new[] { "Radius", "BoundingBox" };
        }
        public bool Inverse;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding21;
    }
}
