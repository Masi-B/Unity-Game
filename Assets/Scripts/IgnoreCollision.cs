using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Collider2D other;
    void Awake()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), other, true);
    }


}
