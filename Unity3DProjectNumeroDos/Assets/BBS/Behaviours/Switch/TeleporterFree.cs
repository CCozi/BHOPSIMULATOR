/*
 * Copyright (C) 2015 Bun Bun Studios.
 *
 * This software is distributed to you as-is without any guarantees or warranties of any kind. You agree 
 * to use this software at your own risk. Bun Bun Studios is not liable for anything directly or indirectly. You 
 * are not allowed to copy, distribute, redistribute, sell, resell, reproduce or transfer this software or 
 * derivations of this software.
 * 
 */

using UnityEngine;
using System.Collections;

[AddComponentMenu("Bun Bun Studios/Switch/Teleporter Free")]
public class TeleporterFree : MonoBehaviour
{
	public GameObject destination;
	public GameObject action;
	public float activateTime = 0.2F;
	
	void OnTriggerEnter(Collider other)
	{
		StartCoroutine(OnTeleport(other));
	}
	
	IEnumerator OnTeleport(Collider other)
	{
		GameObject.Instantiate(action, transform.position, transform.rotation);
		
		yield return new WaitForSeconds(activateTime);
		
		other.gameObject.transform.position = destination.transform.position+new Vector3(0, other.bounds.size.y, 0);
		other.gameObject.transform.rotation = destination.transform.rotation;
	}
}
