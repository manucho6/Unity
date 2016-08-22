using UnityEngine;
using System.Collections;

public class RotacionContinua : MonoBehaviour {
    public float velocidadX;
    public float velocidadY;
    public float velocidadZ;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, velocidadZ * Time.deltaTime);
    }
}
