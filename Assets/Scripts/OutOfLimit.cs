using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfLimit : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag(TagConsts.PLATFORM)){
            Destroy(other.gameObject);
        }
    }
}
