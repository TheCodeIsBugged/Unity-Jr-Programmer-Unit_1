using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Vector3 offset;

    [SerializeField]
    private GameObject mainCamera;
    [SerializeField]
    private GameObject targetCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeCamera();
    }

    private void LateUpdate()
    {
        if (mainCamera.activeInHierarchy)
        {
            transform.position = player.position + offset;
        }
    }

    private void ChangeCamera()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(false);
            targetCamera.SetActive(true);
        }
    }
}
