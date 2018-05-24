using UnityEngine;
using System.Collections;
using UnityEditor;

public class CreateAssetBundles : Editor 
{
    [MenuItem("Assets/Create Asset Bundle")]
    static void CreateBundle()
    {
        string bundlePath = "Assets/AssetBundle";
		Object[] selectedAssets = Selection.GetFiltered(typeof(Object), SelectionMode.Assets);
        BuildPipeline.BuildAssetBundle(Selection.activeObject, selectedAssets, bundlePath,BuildAssetBundleOptions.CollectDependencies | BuildAssetBundleOptions.CompleteAssets,BuildTarget.Android);
                                                                   
    }

//    [MenuItem("Assets/Clear Cache")]
    static void ClearCashe()
    {
    	Caching.ClearCache();
    }
}
