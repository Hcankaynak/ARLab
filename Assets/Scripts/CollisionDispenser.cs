using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDispenser : MonoBehaviour
{

    public int pH = 1;


    // Start is called before the first frame update

    IEnumerator OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.tag == "Tube" || collision.gameObject.tag == "Base")
        {

            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            Vector3 v = gameObject.transform.position;
            v.y += 0.12f;
            while (Vector3.Distance(gameObject.transform.position, v) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, v, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }
            Vector3 y = collision.gameObject.transform.position;
            y.y = gameObject.transform.position.y;
            while (Vector3.Distance(gameObject.transform.position, y) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, y, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }
            Vector3 z = gameObject.transform.position;
            z.y -= 0.4f; 
            while (Vector3.Distance(gameObject.transform.position, z) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, z, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }
            while (Vector3.Distance(gameObject.transform.position, y) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, y, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }
            while (Vector3.Distance(gameObject.transform.position, v) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, v, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }
            v.y -= 0.12f;
            v.x += (v.x - y.x);
            v.z += (v.z - y.z);
            while (Vector3.Distance(gameObject.transform.position, v) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, v, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;

            if(collision.gameObject.tag == "Tube")
            {
                pH = 1;
            }
            else
            {
                pH = 2;
            }

            /*
            yield return new WaitForSeconds(3.0f);
            v = gameObject.transform.position;
            v.x += 0.8f;*/
            //gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, v, Time.deltaTime * 1.5f);
        }
        else if(collision.gameObject.tag == "LitmusPaper")
        {
            Debug.Log("Litmus paper work");
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            Vector3 v = gameObject.transform.position;
            v.y += 0.12f;
            while (Vector3.Distance(gameObject.transform.position, v) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, v, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }
            Vector3 y = collision.gameObject.transform.position;
            y.y = gameObject.transform.position.y;
            while (Vector3.Distance(gameObject.transform.position, y) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, y, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }
            Vector3 z = gameObject.transform.position;
            z.y -= 0.105f;
            while (Vector3.Distance(gameObject.transform.position, z) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, z, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }

            if (pH == 1)
            {
                collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                collision.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }

            while (Vector3.Distance(gameObject.transform.position, y) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, y, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }
            while (Vector3.Distance(gameObject.transform.position, v) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, v, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }
            v.y -= 0.12f;
            v.x += (v.x - y.x);
            v.z += (v.z - y.z);
            while (Vector3.Distance(gameObject.transform.position, v) > 0.001f)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, v, 0.03f);
                yield return new WaitForSeconds(0.00005f);
            }
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            


        }


    }

}

/*
 void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log(collision);
        Debug.Log(collision.gameObject.tag);
        Debug.Log("Mehmet was here");

        if (collision.gameObject.tag == "Tube")
        {
            
            pH = 1;

        }
        else if (collision.gameObject.tag == "Base")
        {
            
            pH = 2;
        }
    }*/
