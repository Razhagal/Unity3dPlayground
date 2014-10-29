using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public Transform target;
    public float speed;
    private const float DistanceToBeKept = 5f;

	private void Update ()
    {
        this.gameObject.transform.LookAt(target);

        if (Vector3.Distance(transform.position, target.position) > DistanceToBeKept)
        {
            transform.Translate(0f, 0f, this.speed * Time.deltaTime);            
        }
	}
}
