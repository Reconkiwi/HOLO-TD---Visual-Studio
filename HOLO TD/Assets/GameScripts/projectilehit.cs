using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilehit : MonoBehaviour
{
    public void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.tag == "Enemy")
        {
            {

                Destroy(col.gameObject);
                Debug.Log("ENEMY HIT");

            }

            //do stuff
        }

    }
}
