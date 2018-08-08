using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;		
	}

	// LateUpdate is called once per frame after everything is done in Update
	void LateUpdate () {
		transform.position = player.transform.position + offset;
		
	}
}
