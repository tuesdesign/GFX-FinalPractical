using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public bool doMove = true;
    public float moveAmount = 1.0f;
    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Mathf.Sin(transform.position.x + Time.time * moveAmount * moveSpeed),transform.position.y,transform.position.z);
    }
}
