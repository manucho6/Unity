using UnityEngine;
using System.Collections;

public class DisparadorAutomatico : MonoBehaviour {

    public GameObject prefab;
    public GameObject target_prefab;

    void Start () {
        Transform target = target_prefab.transform;
        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        Instantiate(prefab, transform.position + new Vector3(0,0,1),rotation);
        
    }
    

}
