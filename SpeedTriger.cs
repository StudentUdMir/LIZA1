using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
    
{
  public float speedFactor = 2.5f;


    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMoment>().runSpeed *= speedFactor; 

    }
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMoment>().runSpeed /= speedFactor;
    }