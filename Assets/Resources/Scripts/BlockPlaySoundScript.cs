using UnityEngine;
using System.Collections;

public class BlockPlaySoundScript : MonoBehaviour {
	
	bool m_hasBeenHit = false;

	void OnCollisionEnter(Collision c) {
		if (m_hasBeenHit) return;
		m_hasBeenHit = true;
		// play a sound when collision occurs
		audio.Play ();
	}
	
	void Update() {
	}
	
	void OnCollisionExit(Collision collisionInfo) {
		m_hasBeenHit = false;
	}


}
