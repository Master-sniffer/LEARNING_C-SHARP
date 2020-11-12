using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeCubes : MonoBehaviour
{

    public GameObject RestartButton;
    private bool _collisionSet;

    public float force = 70f;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag =="Cube" && !_collisionSet)
        {
            for (int i= collision.transform.childCount-1; i>=0; i--)
            {
                Transform child = collision.transform.GetChild(i);
                child.gameObject.AddComponent<Rigidbody>();
                child.gameObject.GetComponent<Rigidbody>().AddExplosionForce(force, Vector3.up, 5f);
                child.SetParent(null);
            }
            RestartButton.SetActive(true);
            Camera.main.transform.position -= new Vector3(0, 0, 3f);
            Destroy(collision.gameObject);
            _collisionSet = true;
        }
    }
}
