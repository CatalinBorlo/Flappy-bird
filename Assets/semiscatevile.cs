using UnityEngine;

public class semiscatevile : MonoBehaviour
{
    public float viteza = 5;
    public float deadZone = -100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * viteza) * Time.deltaTime;
        if(transform.position.x < deadZone )
        {
            Debug.Log("PipeDeleted");
            Destroy(gameObject);
        }
    }
}
