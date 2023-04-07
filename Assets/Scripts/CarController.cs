using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    public float carSpeed;
    Vector3 carPosition;
    public float maxLeft;
    public float maxRight;

    // Start is called before the first frame update
    void Start()
    {
        carPosition = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        carPosition.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        carPosition.x = Mathf.Clamp(carPosition.x, maxLeft, maxRight);
        transform.position = carPosition;
        carPosition.y += Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;
        carPosition.y = Mathf.Clamp(carPosition.y, -8.5f, 8.2f);
        transform.position = carPosition;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
