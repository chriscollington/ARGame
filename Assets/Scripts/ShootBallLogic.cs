using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR;

public class ShootBallLogic : MonoBehaviour
{

    private Camera maincam;


    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float ballForwardForce = 500f;

 
    void Start()
    {
        maincam = FindObjectOfType<Camera>();
        UIButtonHandler.OnUIShootButtonClicked += ShootBallOnButton;
    }

    private void ShootBallOnButton()
    {
        Vector3 spawnPosition = maincam.transform.position + maincam.transform.forward * 0.1f;
        Quaternion spawnRotation = maincam.transform.rotation;


        GameObject spawnedBall = Instantiate(ballPrefab, spawnPosition, spawnRotation);
        Rigidbody rb = spawnedBall.GetComponent<Rigidbody>();

        if (rb != null)     
        { 
        
        rb.AddForce(maincam.transform.forward * ballForwardForce);
        
        
        }

        Destroy(spawnedBall, t: 5f);


    }

}
