using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
    public Rigidbody rb;
    public float speed=1;
    public Text countext;
    public Text win;
    private int count = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        win.text = "";
        SetText();
    }
  /*  void Update()
    {
        if (Input.GetKeyDown("space"))
            print("space key was pressed");

    }*/
    // Update is called once per frame
    void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
        rb.AddForce(movement*speed);
    }
    void OnTriggerEnter(Collider other)
    {if (other.gameObject.CompareTag("pick"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetText();
        }
    }
    void SetText()
    {
        countext.text = "Count " + count.ToString();
        if (count == 15)
        {
            win.text = "You win!";
            countext.gameObject.SetActive(false);
        }
    }
}
