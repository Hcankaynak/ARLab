using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class CollisionDispenser : MonoBehaviour
{

    public float pH = 1.0f;
    private string[] chemicals = { "Amonyak", "Apple", "Cola", "DetergentWater", "HCl", "Listerin", "Soda", "SodyumHidroksit" };

    // Start is called before the first frame update

    IEnumerator waitForXSecond(float value)
    {
        yield return new WaitForSeconds(value);
    }

    

    IEnumerator OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (chemicals.Contains((collision.gameObject.tag)))
        {

            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            float height = collision.gameObject.GetComponent<MeshRenderer>().bounds.size.y;
            Vector3 v = gameObject.transform.position;
            v.y += height * 1.2f;
            gameObject.GetComponent<PositionLerper>().newPosition = v;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }

            Debug.Log("merhaba tarik");
            Vector3 y = collision.gameObject.transform.position;
            y.y = gameObject.transform.position.y;
            gameObject.GetComponent<PositionLerper>().newPosition = y;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }
            Vector3 z = gameObject.transform.position;
            z.y -= height;
            gameObject.GetComponent<PositionLerper>().newPosition = z;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }
            yield return new WaitForSeconds(0.5f);
            gameObject.GetComponent<PositionLerper>().newPosition = y;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }

            gameObject.GetComponent<PositionLerper>().newPosition = v;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }

            v.y -= height * 1.2f;
            v.x += (v.x - y.x);
            v.z += (v.z - y.z);
            gameObject.GetComponent<PositionLerper>().newPosition = v;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }

            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;

            if (collision.gameObject.tag == "Amonyak")
            {
                pH = 11.0f;
            }
            else if (collision.gameObject.tag == "Apple")
            {
                pH = 3.0f;
            }
            else if (collision.gameObject.tag == "Cola")
            {
                pH = 2.6f;
            }
            else if (collision.gameObject.tag == "DetergentWater")
            {
                pH = 9.7f;
            }
            else if (collision.gameObject.tag == "HCl")
            {
                pH = 1.0f;
            }
            else if (collision.gameObject.tag == "Listerin")
            {
                pH = 5.45f;
            }
            else if (collision.gameObject.tag == "Soda")
            {
                pH = 8.3f;
            }
            else if (collision.gameObject.tag == "SodyumHidroksit")
            {
                pH = 13.5f;
            }
        }

        else if (collision.gameObject.tag == "LitmusPaper")
        {
            Debug.Log("Litmus paper work");
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            float height = collision.gameObject.GetComponent<MeshRenderer>().bounds.size.y;
            Vector3 v = gameObject.transform.position;
            v.y += 0.12f;
            gameObject.GetComponent<PositionLerper>().newPosition = v;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }

            Vector3 y = collision.gameObject.transform.position;
            y.y = gameObject.transform.position.y;
            gameObject.GetComponent<PositionLerper>().newPosition = y;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }

            Vector3 z = gameObject.transform.position;
            z.y -= 0.12f - height;
            gameObject.GetComponent<PositionLerper>().newPosition = z;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }

            if (pH <= 2.0f)
            {
                collision.gameObject.GetComponent<ColorLerper>().newColor = new Color32(255, 109, 109, 0);
                collision.gameObject.GetComponent<ColorLerper>().activation = true;
            }
            else if (pH <= 4.0f)
            {
                collision.gameObject.GetComponent<ColorLerper>().newColor = new Color32(255, 153, 154, 0);
                collision.gameObject.GetComponent<ColorLerper>().activation = true;
            }
            else if (pH <= 7.0f)
            {
                collision.gameObject.GetComponent<ColorLerper>().newColor = new Color32(255, 197, 196, 0);
                collision.gameObject.GetComponent<ColorLerper>().activation = true;
            }
            else if (pH <= 9.0f)
            {
                collision.gameObject.GetComponent<ColorLerper>().newColor = new Color32(200, 199, 255, 0);
                collision.gameObject.GetComponent<ColorLerper>().activation = true;
            }
            else if (pH <= 12.0f)
            {
                collision.gameObject.GetComponent<ColorLerper>().newColor = new Color32(120, 119, 255, 0);
                collision.gameObject.GetComponent<ColorLerper>().activation = true;
            }
            else
            {
                collision.gameObject.GetComponent<ColorLerper>().newColor = new Color32(41, 40, 255, 0);
                collision.gameObject.GetComponent<ColorLerper>().activation = true;
            }

            yield return new WaitForSeconds(0.5f);
            gameObject.GetComponent<PositionLerper>().newPosition = y;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }

            gameObject.GetComponent<PositionLerper>().newPosition = v;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }
            v.y -= 0.12f;
            v.x += (v.x - y.x);
            v.z += (v.z - y.z);
            gameObject.GetComponent<PositionLerper>().newPosition = v;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
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
