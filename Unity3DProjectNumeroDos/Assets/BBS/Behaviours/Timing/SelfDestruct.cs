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

[AddComponentMenu("Bun Bun Studios/Timing/Self Destruct")]
public class SelfDestruct : MonoBehaviour
{
	public float duration;
	
	IEnumerator Start()
	{
		yield return new WaitForSeconds(duration);
		
		Destroy(gameObject);
	}
}
