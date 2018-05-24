using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colorchange : MonoBehaviour {

    public GameObject tile_1,tile_2,tile_3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TileClick(){

        print("test");

        Invoke("tile_Change_color_Red", 1);

    }
    void tile_Change_color_Red(){

        tile_1.GetComponent<Image>().color = Color.red;
        Invoke("tile_Change_color_Green", 1);
    }

    void tile_Change_color_Green()
    {

        tile_2.GetComponent<Image>().color = Color.green;
        Invoke("tile_Change_color_Black", 1);

    }

    void tile_Change_color_Black()
    {

        tile_3.GetComponent<Image>().color = Color.black;
        Invoke("Loadscene", 1);

    }

    void Loadscene(){
        Application.LoadLevel(1);

    }


}
