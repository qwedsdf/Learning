using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class y_cross : MonoBehaviour {

    public Vector3 vec0;
    public Vector3 vec1;
    public Vector3 cross;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cross = Vector3.Cross(vec0,vec1);

        Debug.DrawLine(Vector3.zero, vec0, Color.red);
        Debug.DrawLine(Vector3.zero, vec1, Color.green);
        Debug.DrawLine(Vector3.zero, cross, Color.blue);

        cross = Vector3.Cross(vec1, cross);
        Debug.DrawLine(Vector3.zero, cross, Color.grey);
    }
}
