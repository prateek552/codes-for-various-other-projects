using UnityEngine;
using System.Collections;

public class CamControl : MonoBehaviour {

    // Use this for initialization
    public GameObject Player;
    private Vector3 offset;
	void Start () {
        offset = transform.position - Player.transform.position;
        
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = offset + Player.transform.position;
	
	}
}
