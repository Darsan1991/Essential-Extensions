using System;
using UnityEngine;


namespace DGames.Essentials.Extensions
{
    public static class UnityExtensions
    {
        public static bool IsMonoBehavior(this Type type) => type.IsSubclassOf(typeof(MonoBehaviour));
        public static bool IsScriptable(this Type type) => type.IsSubclassOf(typeof(ScriptableObject));
    }
}