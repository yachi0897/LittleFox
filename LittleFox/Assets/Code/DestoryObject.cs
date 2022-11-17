﻿using UnityEngine;



namespace Fox
{
    ///<summary>
    ///刪除物件
    /// <summary>
    public class DestoryObject : MonoBehaviour
    {
        [SerializeField, Header("刪除時間"), Range(0, 3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            //gameObject 此腳本的遊戲建物件
            //刪除(物件,刪除時間)
            Destroy(gameObject, destroyTime); 
        }
        //可見事件:當渲染元件(Randerer)出現在Scene 或Game 時 執行一次
        private void OnBecameVisible()
        {

        }
        //不可見事件:當渲染元件(Randerer)消失在Scene 或Game 時 執行一次
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }





    }
}

