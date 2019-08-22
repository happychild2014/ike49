using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidButtonManager : MonoBehaviour {

 
    //★Androidアプリを戻るボタンで終了させるには

    void Update()
    {
        //プラットフォームがアンドロイドかチェック
        //if (Application.platform == RuntimePlatform.Android)

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //アプリケーション終了
            Application.Quit();
            return;
        }
    }
}
