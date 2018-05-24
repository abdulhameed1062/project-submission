using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AssetDownloader : MonoBehaviour
{
    public string url;
    GameObject Sktech;
    public GameObject mycanvas;
    public Transform spawnPos;
    public Text loading;
    private string str = "Test_loader";

    public void Start(){
       
    }

    IEnumerator LoadBundle(string str)
    {
        while (!Caching.ready)
        {
            yield return null;
        }

        WWW www = WWW.LoadFromCacheOrDownload(url, 0);
        yield return www;

        AssetBundle bundle = www.assetBundle;

        AssetBundleRequest bundleRequest = bundle.LoadAssetAsync(str, typeof(GameObject));
        yield return bundleRequest;

        GameObject obj = bundleRequest.asset as GameObject;

        Sktech = Instantiate(obj, spawnPos.position, Quaternion.identity) as GameObject;
        Sktech.transform.parent = mycanvas.transform;
        loading.text = "";

        bundle.Unload(false);
        www.Dispose();
    }


	public void load_asset_call()
	{
        StartCoroutine(LoadBundle(str));
        loading.text = "Loading...";
	}


}
