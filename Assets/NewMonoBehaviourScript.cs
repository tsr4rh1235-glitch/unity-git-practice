using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int a;
    void Start()
    {
        a = 1;
        Debug.Log(a);
        // Debug.Log("hello World");

        //bool a = true;
        //bool b = false;
        //gameObject.SetActive(a || b);
        //Vector2 newPos = transform.position;
        newPos.x = newPos.x + 5;
        transform
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0,1,0);
        }
    }
}
