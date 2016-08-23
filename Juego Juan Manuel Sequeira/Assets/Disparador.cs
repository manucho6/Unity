using UnityEngine;
using System.Collections;

public class Disparador : MonoBehaviour {

    public GameObject prefab;
    public string nombreAccion;

    void Update () {
	
        if (Input.GetButtonDown(nombreAccion)){
            Instantiate(prefab, this.transform.position + new Vector3(0,0,1),this.transform.rotation);
            
        }

    }
}
