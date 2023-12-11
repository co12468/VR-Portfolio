using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VelUtils.VRInteraction;


public class Flashlight : MonoBehaviour
{
    [SerializeField]
    VRMoveable flashlight;
    [SerializeField]
    Light lightSwitch;
    // Start is called before the first frame update
    void Start()
    {
        flashlight.Grabbed += () =>
        {
            lightSwitch.enabled = true;
        };
        flashlight.Released += () =>
        {
            lightSwitch.enabled = false;
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
