using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    [SerializeField]
    BallScript machine;
    public int pointValue;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        SpawnedObject ball = other.attachedRigidbody?.GetComponent<SpawnedObject>();
        if (ball != null)
        {
            GameObject.Destroy(ball.gameObject);
            machine.sensorDetected(this);
        }
    }
}
