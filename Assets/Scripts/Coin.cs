using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Coin : MonoBehaviour
{
    public UnityEvent events;

    public void Start()
    {
        events.AddListener(GameObject.FindGameObjectWithTag("Collector").GetComponent<CollectionController>().AddScore);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        events.Invoke();
    }
}
