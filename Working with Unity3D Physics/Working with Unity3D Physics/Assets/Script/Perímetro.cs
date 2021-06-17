using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perímetro : MonoBehaviour
{
    void OnTriggerExit(Collider other) {
        Destroy(other.gameObject);
    }

}
