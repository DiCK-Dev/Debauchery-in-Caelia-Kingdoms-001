using UnityEngine;
using System.Collections;

public class DestroyGameObject : MonoBehaviour {

	public GameObject target;

	public void selfDestroy(){

		Destroy (target);

	}


}
