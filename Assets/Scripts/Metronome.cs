using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metronome : MonoBehaviour {

	private Beat.Clock clock;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		clock = Beat.Clock.Instance;
		source = GetComponent<AudioSource>();
		clock.Beat += Tick;
	}

	void Tick(Beat.Clock.BeatArgs args) {
		source.Play();
	}

	void OnDestroy() {
		clock.Beat -= Tick;
	}
}
