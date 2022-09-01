using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
//added code source - https://answers.unity.com/questions/554412/make-an-object-move-forward-on-its-own-c.html
{
    float orbitSpeed = .1f;
    int movespeed = 3;//added code
    Vector3 userDirection = Vector3.left; //added code
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3 (0, orbitSpeed, 0));
        transform.Translate(userDirection*movespeed*Time.deltaTime); //added code
    }
}
