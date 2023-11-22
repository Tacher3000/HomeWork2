using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class XP : MonoBehaviour
{
    public float speed = 10f;

    public int k = 6;
    public Text textK;
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(UnityEngine.Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(UnityEngine.Vector3.down * 5 * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(UnityEngine.Vector3.back * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(UnityEngine.Vector3.up * 5 * speed * Time.deltaTime);


        if (k <= 0)
        {
            this.gameObject.SetActive(false);
            textK.text = "кубик умер:(";
        }
        else
        {
            textK.text = k.ToString();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        --k;
    }
    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }
}
