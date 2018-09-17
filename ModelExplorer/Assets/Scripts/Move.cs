using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public GameObject myPrefab;
    private bool moving = false;

    // Use this for initialization
    void Start () {
		
	}
    // Update is called once per frame

    public void Hi()
    {
        moving = true;
    }
    void Update()
        {
        if (moving == true) {
            myPrefab.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }

    }
}
