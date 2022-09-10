using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPower : MonoBehaviour
{
    [SerializeField] private float Angle;
    [SerializeField] private float power;
    
    private  void OnCollisionEnter(Collision other) 
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Angle,90,0) * power, ForceMode.Force);
        
    }









}
