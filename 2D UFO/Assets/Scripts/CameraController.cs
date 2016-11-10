using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	internal void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	internal void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
