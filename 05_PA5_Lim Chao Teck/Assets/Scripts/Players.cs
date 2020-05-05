using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Players : MonoBehaviour
{
    public float speed;
    Rigidbody PlayerRigidbody;
    private int Keys = 4;

    public Text Txt_Keys;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        PlayerRigidbody.AddForce(movement * speed * Time.deltaTime);

        if(Keys == 0)
        {
            Destroy(GameObject.FindWithTag("Door"));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            SceneManager.LoadScene("GameLose");
        }

        if(collision.gameObject.tag == "Boss")
        {
            SceneManager.LoadScene("GameWin");
        }

        if (collision.gameObject.tag == "Keys")
        {
            Keys--;
            Txt_Keys.text = "Keys : " + Keys;
            Destroy(collision.gameObject);
        }
    }
}
