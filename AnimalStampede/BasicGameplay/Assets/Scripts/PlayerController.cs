using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizantalInput;
    public float speed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        horizantalInput = Input.GetAxis("horizantalInput");
        transform.Translate(Vector3.right * horizantalInput * Time.deltaTime * speed);
    }
}
