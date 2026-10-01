using UnityEngine;

public class MoveMaze : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // A rotation 30 degrees around the y-axis
        //Quaternion rotation = Quaternion.Euler(0, 30, 0);
        // apply the rotation to this object
        // transform.SetLocalPositionAndRotation(transform.localPosition, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        //transform.Translate(0, 0, translation);
        
        transform.Rotate(rotation, 0, translation);
    }
}


//transform.rotation = Quaternion.Euler(xRotation, yRotation, zRotation);