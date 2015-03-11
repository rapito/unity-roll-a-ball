using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    public float speed = 3f;

	void Update () {


        Vector3 rotation = new Vector3(Random.Range(10, 30), Random.Range(10, 30), Random.Range(10, 30));
        GetComponent<Transform>().Rotate(rotation * speed * Time.deltaTime);
	}
}
