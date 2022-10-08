using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetoColisao : MonoBehaviour
{
    public ContactFilter2D filtro;
    private BoxCollider2D box;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        box = GetComponent<BoxCollider2D>();
    }
    protected virtual void Update()
    {
        box.OverlapCollider(filtro, hits);

        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
                continue;

            Debug.Log(hits[i].name);

            hits[i] = null;
        }
    }
}