using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JukeboxTransform : MonoBehaviour
{
    public Vector3 TransformPostition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += TransformPostition;
    }
}
