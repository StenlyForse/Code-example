using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerExit(Collider other)  // боундарька которая уничтожает объекты, когда они выходят из неё, нужна для подчистки мусора
    {
        Destroy(other.gameObject);
    }
}
