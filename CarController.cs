using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 5f;            
    public float turnSpeed = 2f;       
    public float detectionDistance = 5f; 

    private void Update()
    {
    
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, detectionDistance))
        {
           
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

        
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
