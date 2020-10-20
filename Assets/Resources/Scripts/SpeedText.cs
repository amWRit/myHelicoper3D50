using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Text))]
public class SpeedText : MonoBehaviour {

	public GameObject helicopter;
	private Text text;
	public float speed;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		if (helicopter != null) {
			speed = SkyscraperSpawner.speed;
		}
		text.text = "Speed: " + speed;
	}
}
