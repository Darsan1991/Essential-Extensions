using System.Linq;
using UnityEngine;

namespace DGames.Essentials.Extensions
{
    public static class AnimationCurveExtensions
    {
        public static float GetValueForNormalized(this AnimationCurve curve, float n)
        {
            var maxTime = curve.keys.Max(k => k.time);
            var minTime = curve.keys.Min(k => k.time);
            return curve.Evaluate(minTime + (maxTime - minTime) * n);
        }
    }
}