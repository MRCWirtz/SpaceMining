using UnityEngine;

public class UserInteraction : MonoBehaviour {

    public bool[] keys = new bool[222];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetKeyDown(KeyCode.Space));
        Debug.Log(Input.mousePosition);
    }
}
