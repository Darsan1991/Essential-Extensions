// /*
// Created by Darsan
// */

using UnityEngine;

namespace DGames.Essentials.Extensions
{
    

    public static class ColorExtensions
    {
        public static Color WithAlpha(this Color color, float a)
        {
            color.a = a;
            return color;
        }
    }
}