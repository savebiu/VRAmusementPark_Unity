using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class hands : MonoBehaviour
{
    public Hand lefthand;
    public Hand righthand;
    public SteamVR_Action_Boolean SteamVR_Action_Boolean_Source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Action_Boolean_Source.GetState(lefthand.handType))
        {
            print("1111111111111");
        }
    }
}
