using UnityEngine;

namespace DGames.Essentials.Extensions
{
    

    public static class ComponentExtensions
    {
        public static bool GetComponent<T>(this Component component, out T output) where T : Component
        {
            output = component.GetComponent<T>();
            return output;
        }

        public static bool GetComponent<T>(this GameObject go, out T output) where T : Component
        {
            return go.transform.GetComponent(out output);
        }
    }
}