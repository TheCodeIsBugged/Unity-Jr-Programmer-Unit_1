using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float turnSpeed;

    [SerializeField]
    private GameObject player;
    
    private float verticalInput;
    private float horizontalInput;
    private string axisInput;

    // Start is called before the first frame update
    void Start()
    {
        if (player.name == "Player1")
        {
            axisInput = "Arrow";
        }
        else if (player.name == "Player2")
        {
            axisInput = "WASD";
        }
    }

    // Update is called once per frame
    void Update()
    {
        DriveVehicle();
    }

    void DriveVehicle()
    {
        // Move the vehicle forward, left, and right
        verticalInput = Input.GetAxis("Vertical" + axisInput);
        horizontalInput = Input.GetAxis("Horizontal" + axisInput);
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
}
