using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            Destroy(gameObject); // ลบ gem ทิ้งเมื่อโดนผู้เล่นชน
        }
    }
}

