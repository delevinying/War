using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControl : MonoBehaviour {

    public GameObject tag;
    private LineRenderer line;
	// Use this for initialization
	void Start () {
        this.line = this.gameObject.GetComponent<LineRenderer>();
        this.line.SetColors(Color.yellow, Color.yellow);
        this.line.SetWidth(0.3f, 0.2f);
        this.line.SetPosition(0, this.gameObject.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
        this.line.SetPosition(1, tag.transform.position);
        //this.line.line
	}
}
