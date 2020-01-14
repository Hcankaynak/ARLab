using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CollisionDispenser : MonoBehaviour
{

    private string[] chemicals = { "Amonyak", "Apple", "Cola", "DetergentWater", "HCl", "Listerin", "Soda", "SodyumHidroksit" };
    float pH = 7;
    float[,] phColors = { { 192, 8, 63, 0 }, { 208, 1, 27, 0 }, { 218, 6, 3, 0 }, { 239, 41, 2, 0 },
        { 250, 75, 4, 0 }, { 248, 147, 4, 0 }, { 233, 208, 3, 0 }, { 111, 204, 1, 0 }, { 9, 199, 14, 0 },
        { 47, 130, 116, 0 }, { 71, 70, 200, 0 }, { 33, 32, 170, 0 }, { 3, 0, 149, 0 }, { 2, 10, 120, 0 }, { 6, 18, 111, 0 } };

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

            switch (collision.gameObject.tag)
            {
                case "Amonyak":
                    pH = 11.0f;
                    break;
                case "Apple":
                    pH = 3.0f;
                    break;
                case "Cola":
                    pH = 2.6f;
                    break;
                case "DetergentWater":
                    pH = 9.7f;
                    break;
                case "HCl":
                    pH = 1.0f;
                    break;
                case "Listerin":
                    pH = 5.45f;
                    break;
                case "Soda":
                    pH = 8.3f;
                    break;
                case "SodyumHidroksit":
                    pH = 13.5f;
                    break;
            }

        }

        else if (collision.gameObject.tag == "LitmusPaper")
        {
            Debug.Log("Litmus paper work");
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
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
            z.y -= 0.105f;
            gameObject.GetComponent<PositionLerper>().newPosition = z;
            gameObject.GetComponent<PositionLerper>().activation = true;
            while (gameObject.GetComponent<PositionLerper>().activation || gameObject.GetComponent<PositionLerper>().active)
            {
                yield return new WaitForSeconds(0.1f);
            }

            float decimalPart = pH % 1;
            int nonDecimalPart = (int)pH;
            int low = nonDecimalPart;
            int high = nonDecimalPart + 1;
            float redValue = phColors[low, 0] + ((phColors[low, 0] - phColors[high, 0]) * decimalPart);
            float greenValue = phColors[low, 1] + ((phColors[low, 1] - phColors[high, 1]) * decimalPart);
            float blueValue = phColors[low, 2] + ((phColors[low, 2] - phColors[high, 2]) * decimalPart);
            collision.gameObject.GetComponent<ColorLerper>().newColor = new Color(redValue / 255, greenValue / 255, blueValue / 255, 0);
            collision.gameObject.GetComponent<ColorLerper>().activation = true;

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