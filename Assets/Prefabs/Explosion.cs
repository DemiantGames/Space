using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	// Use this for initialization
	private FMOD.Studio.EventInstance explo;
	void Start () {
		explo = FMODUnity.RuntimeManager.CreateInstance ("event:/Planet Explosion");
	}
	


	void OnDestroy() {
		explo.start ();
	}
}
