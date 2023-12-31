using System;
using UnityEngine;
using Unity.Netcode;

public class NetworkTransformTest : NetworkBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (!IsServer) return;
        var theta = Time.frameCount / 10.0f;
        transform.position = new Vector3((float)Math.Cos(theta), 0.0f, (float)Math.Sin(theta));
    }
}
