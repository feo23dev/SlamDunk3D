using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPower : MonoBehaviour
{
    [SerializeField] private float Angles;
    [SerializeField] private float powers;
    
    private  void OnCollisionEnter(Collision other) 
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Angles,90,0) * powers, ForceMode.Force);
    }









}
