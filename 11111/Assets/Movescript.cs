using UnityEngine;

public class Movescript : MonoBehaviour
{
    public GameObject targetSphere; 
    public Vector3 selfobject;
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(0, 0, moveSpeed * Time.deltaTime);

        transform.position = Vector3.Lerp(selfobject, targetSphere.transform.position,moveSpeed * Time.deltaTime );
    }
}
