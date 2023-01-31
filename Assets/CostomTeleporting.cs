using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CostomTeleporting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray raycast = new Ray(transform.position, transform.forward);
RaycastHit hit;

bool bHit = Physics.Raycast(raycast, out hit);
if (bHit)
{
  print(hit.point);
}


        if(SteamVR_Input.GetStateDown("offroadteleport", SteamVR_Input_Sources.LeftHand))
{
  print("Fire out the teleport line");
}

if (SteamVR_Input.GetStateUp("offroadteleport", SteamVR_Input_Sources.LeftHand))
{
  print("Teleport to the intersection point");
}
    }
}
