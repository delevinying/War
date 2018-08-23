using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopView : MonoBehaviour {

    public Camera camera;
    private TextMesh tm;
    // Use this for initialization
    void Start()
    {
        tm = this.gameObject.GetComponentInChildren<TextMesh>();

    }

    // Update is called once per frame
    void Update()
    {
        tm.gameObject.transform.position = this.gameObject.transform.position + new Vector3(0, 2f, 0);
        tm.gameObject.transform.forward = new Vector3(tm.gameObject.transform.position.x - camera.transform.position.x,
            tm.gameObject.transform.position.y - camera.gameObject.transform.position.y, tm.transform.position.z - camera.transform.position.z);
    }
}
