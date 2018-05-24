using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    private Animator charcteranim;
	
	void Start () {

        charcteranim = GetComponent<Animator>();
        DontDestroyOnLoad(this);
	}
	
    void OnMouseDown()
    {
        int randomselction;
        randomselction = Random.Range(0,3);

        switch(randomselction){

            case 0:
                charcteranim.SetTrigger("Hit");
                break;
            case 1:
                charcteranim.SetTrigger("Attack1");
                break;
            case 2:
                charcteranim.SetTrigger("jump");
                break;

        }

    }
}
