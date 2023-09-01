using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereController : MonoBehaviour
{
    public float speed = 1f;

    [SerializeField]
    private Rigidbody rb;

    public float maximumAngularVelocity;

    bool isRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        if(isRigidbody = TryGetComponent<Rigidbody>(out rb))
        {
            rb.maxAngularVelocity = maximumAngularVelocity;           
        }
    }

    // Update is called once per frame
    void Update()
    {
        float Hdirection;
        float Vdirection;
        float respawn = -10;

        if(isRigidbody && (Hdirection = Input.GetAxis("Horizontal")) != 0)
        {
            rb.AddTorque(0, 0, -Hdirection * Time.deltaTime * speed);
        }

        if (isRigidbody && (Vdirection = Input.GetAxis("Vertical")) != 0)
        {
            rb.AddTorque(Vdirection * Time.deltaTime * speed, 0 , 0);
        }

        if(transform.position.y <= respawn)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
