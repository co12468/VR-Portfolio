using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VelUtils.VRInteraction;

public class HideHand : MonoBehaviour
{
    [SerializeField]
    VRGrabbableHand hand;
    [SerializeField]
    GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        hand.OnGrab += (grabbable) =>
        {
            sphere.GetComponent<Renderer>().enabled = false;
        };
        hand.OnRelease += (grabbable) =>
        {
            sphere.GetComponent<Renderer>().enabled = true;
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
