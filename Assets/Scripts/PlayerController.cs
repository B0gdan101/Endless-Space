using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0f;
    [SerializeField] GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Move Right"))
        {
            gameObject.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        } else if (Input.GetButton("Move Left"))
        {
            gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            cam.transform.parent = null;
            gameObject.SetActive(false);
        } 
    }
}
