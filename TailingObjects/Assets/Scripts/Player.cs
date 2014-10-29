using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private GameObject player;
    public float speed = 10f;

	void Start ()
    {
        this.player = GameObject.Find("Player");
	}
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.Translate(0f, 0f, this.speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.Translate(0f, 0f, -this.speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Translate(-this.speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Translate(this.speed * Time.deltaTime, 0f, 0f);
        }
	}
}
