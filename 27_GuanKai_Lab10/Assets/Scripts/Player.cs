using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private float PosY;
    private float xMin = -3.96f, xMax = 3.96f;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float PosY = this.transform.position.y;
        float verticalInput = Input.GetAxis("Vertical");
        this.transform.position =new Vector3(transform.position.x, Mathf.Clamp(PosY, xMin, xMax));
        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

      

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
