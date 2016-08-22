using UnityEngine;
using System.Collections;

public class MovimientoContinuo : MonoBehaviour {
    public float velocidadX;
    public float velocidadY;
    public float velocidadZ;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, velocidadZ* Time.deltaTime);
    }
}
