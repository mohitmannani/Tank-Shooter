using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
   
    public GameObject objectToThrow;
    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    public float throwUpwardForce =3f;
    public float throwCooldown =15f;
    private bool canThrow = true;
    public GameObject placetostart;




    void Start()
    {
       
    }

    void Update()
    {
        if (canThrow && Input.GetKeyDown(throwKey))
        {

            GameObject projectile = Instantiate(objectToThrow, placetostart.transform.position, placetostart.transform.rotation);
            Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
            Vector3 forceToAdd = -transform.forward * throwForce;


            projectileRb.AddForce(forceToAdd, ForceMode.Impulse);


            canThrow = false;


            StartCoroutine(ResetCooldown());
        }
        
    }

    IEnumerator ResetCooldown()
    {
        yield return new WaitForSeconds(throwCooldown);
        canThrow = true;
        
    }

}



