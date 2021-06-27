using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleShield : MonoBehaviour
{
    public GameObject shield;

    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log(other.gameObject.name);

        if(other.gameObject.layer == 6)
        {
            DeployShield();
        }
        
    }

    void DeployShield()
    {
        //this.gameObject.GetComponent<Rigidbody>().Sleep();
        Instantiate(shield, this.gameObject.transform.position, new Quaternion(0.0f,0.0f,0.0f,0.0f));
        //Destroy(this.gameObject);
    }
}
