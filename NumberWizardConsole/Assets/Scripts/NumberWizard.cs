using UnityEngine;

namespace NumberWizard
{
    public class NumberWizard : MonoBehaviour
    {
        private int min = 1;
        private int max = 1000;
        private int guess = 500;

        // Start is called before the first frame update
        private void Start()
        {
            Debug.Log("Welcome to Number Wizard!");
            Debug.Log("Pick a number, don't tell me what it is...");
            Debug.Log("The highest number you can pick is: " + max);
            Debug.Log("The lowest number you can pick is: " + min);
            Debug.Log("Tell me if your number is higher or lower than 500");
            Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("Enter key was pressed");
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("Up Arrow key was pressed");
                min = guess;
                Debug.Log(guess);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("Down Arrow key was pressed");
                max = guess;
                Debug.Log(guess);
            }
        }
    }
}
