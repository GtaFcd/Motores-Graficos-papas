using UnityEngine;

public class linterna : MonoBehaviour
{
        void Start()
    {
        
    }

    void Update()
    {
        if (Physics.Raycast(transform.position,transform.forward,out RaycastHit hit,10f))
        {
            Debug.Log("Detecte" + hit.collider.name);
        }
    }
}
