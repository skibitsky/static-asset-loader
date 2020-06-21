using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using Object = UnityEngine.Object;

namespace Skibitsky.Unity.Editor
{
    public static class StaticAssetLoader
    {
        /// <summary>
        /// Load first asset of specified type
        /// </summary>
        public static T LoadAsset<T>() where T : Object
        {
            var array = LoadAssetArray<T>().ToArray();
            return array.Length > 0 ? LoadAssetArray<T>().First() : null;
        }
        
        /// <summary>
        /// Load all assets of specified type
        /// </summary>
        public static IEnumerable<T> LoadAssetArray<T>() where T : Object
        {
            var assetCandidates = AssetDatabase.FindAssets($"t:{typeof(T)}");
            return assetCandidates
                .Select(AssetDatabase.GUIDToAssetPath)
                .Select(AssetDatabase.LoadAssetAtPath<T>);
        } 
    }
}

