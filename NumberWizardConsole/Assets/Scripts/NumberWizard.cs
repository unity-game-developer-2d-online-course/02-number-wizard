using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        const int min = 1;
        const int max = 1000;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}
