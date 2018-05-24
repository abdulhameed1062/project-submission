using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Counter : MonoBehaviour {
    public static Counter m_agent;
    public  int count;
    public AssetDownloader assetDownloader;
	// Use this for initialization

	private void Awake()
	{
        m_agent = this;
	}
	void Start () {
		
	}
	
    public void CheckCount(){

        if(count == 4){

            assetDownloader.load_asset_call();
        }
    }
}
