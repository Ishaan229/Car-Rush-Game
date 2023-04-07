 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float scrollSpeed = 2f;
    Vector3 initPos;

    // Start is called before the first frame update
    private void Start()
    {
        initPos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > (initPos + new Vector3(0, -20, 0)).y)
            transform.position += Vector3.down * scrollSpeed * Time.deltaTime;
        else
            transform.position = initPos;
    }
}
