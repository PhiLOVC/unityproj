﻿
using UnityEngine;
using System.Collections;

public class Enemy_AI : MonoBehaviour {

	Transform tr_Player;
	float f_RotSpeed=100000000000.0f,f_MoveSpeed = 100000000000.0f;

	// Use this for initialization
	void Start () {

		tr_Player = GameObject.FindGameObjectWithTag ("ThirdPersonCharacter").transform; }

	// Update is called once per frame
	void Update () {
		/* Look at Player*/
		transform.rotation = Quaternion.Slerp (transform.rotation , Quaternion.LookRotation (tr_Player.position - transform.position) , f_RotSpeed * Time.deltaTime);

		/* Move at Player*/
		transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
	}
}