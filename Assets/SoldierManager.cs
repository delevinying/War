using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierManager : MonoBehaviour
{
    //士兵数量
    public int s_num = 20;
    public int max_num = 6;//在场数量
    public GameObject startGameObject;
    private int _num = 0;
    private Transform startPostionT;
    public static SoldierManager instance;
    private GameObject _gameObject;
    public SoldierManager(){
        
    }
    // Use this for initialization
    void Start()
    {
        this._gameObject = GameObject.Find("soldier");
        this.startPostionT = startGameObject.transform;
    }

    // Update is called once per frame
    private float _t = 2;
    void Update()
    {
        _t += Time.deltaTime;
        if (_t < 2) { return; }else{
            _t = 0;
        }
        if(this._num < this.s_num){
            GameObject.Instantiate(this._gameObject,startPostionT);
            this._num++;
        }
    }

    //public getInstance():SoldierManager{
    //    if(SoldierManager.instance == null){
    //        SoldierManager.instance = new SoldierManager();
    //    }
    //    return SoldierManager.instance;
    //}
}
