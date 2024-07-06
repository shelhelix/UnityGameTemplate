using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace GameJamEntry.Scripts.Utils
{
    public static class ScopeUtils {
        public static ComponentRegistrationBuilder RegisterComponentFromResources<T>(this IContainerBuilder builder, string path, Lifetime lifetime) where T : Component {
            var prefab = Resources.Load<T>(path);
            return builder.RegisterComponentInNewPrefab(prefab, lifetime);
        } 
        
    }
}