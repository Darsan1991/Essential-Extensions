using UnityEngine;

namespace DGames.Essentials.Extensions
{
    public static class PrimitiveExtensions
    {
        public static int FloorTo(this int value, int digit)
        {
            var pow = (int)Mathf.Pow(10, digit);
            return (value / pow) * pow;
        }
    }
}