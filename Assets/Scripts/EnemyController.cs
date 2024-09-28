using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float delayStart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("ForwardEnemy", delayStart);
    }

    void ForwardEnemy()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
