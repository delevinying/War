﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierControl : MonoBehaviour {

    public float speed;

    private SoldierState _state;
    private Transform _tf;
    private Rigidbody _rd;
    private Animator _amt;
	// Use this for initialization
	void Start () {
        this._tf = this.gameObject.transform;
        this._rd = this.gameObject.GetComponent<Rigidbody>();
        this._amt = this.gameObject.GetComponentInChildren<Animator>();
        this._amt.SetBool("Run",true);
	}
	
	// Update is called once per frame
	void Update () {
        this._rd.MovePosition(this._tf.position + this._tf.forward* speed);
        //this._amt
	}
}

class SoldierState{
    public static string IDLE = "idle";
    public static string WALK = "walk";
    public static string RUN = "run";
}
