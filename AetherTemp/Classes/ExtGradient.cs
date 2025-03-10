using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(new Color(74f / 255f, 58f / 255f, 160f / 255f), 1f),
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
