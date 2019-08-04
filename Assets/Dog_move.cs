using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_move : MonoBehaviour {

    bool bWalk = false;
	// Use this for initialization
	void Start () {
		
	}
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //ここにAキーが押された時の処理
            GetComponent<Animator>().SetTrigger("waitTrigger");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //ここにAキーが押された時の処理
            GetComponent<Animator>().SetTrigger("walkTrigger");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //ここにAキーが押された時の処理
            GetComponent<Animator>().SetTrigger("fallTrigger");
        }

        /*
        // マウスがクリックされた場合
        if (Input.GetMouseButtonDown(0))
        {
            if( bWalk)
            {
                bWalk = false;
                GetComponent<Animator>().SetTrigger("waitTrigger");
            }
            else
            {
                bWalk = true;
                GetComponent<Animator>().SetTrigger("walkTrigger");
            }
            // Animatorコンポーネントを取得し、"jumpTrigger"をtrueにする
            //GetComponent<Animator>().SetTrigger("walkTrigger");
        }
        */
    }
}
