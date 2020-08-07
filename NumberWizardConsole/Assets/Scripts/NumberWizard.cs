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
            Debug.Log("Tell me if your number is higher or lower than " + guess);
            Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");

            max++;
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("I am a genius!");
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = guess;
                guess = (max + min) / 2;
                Debug.Log("Is it higher or lower than " + guess);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = guess;
                guess = (max + min) / 2;
                Debug.Log("Is it higher or lower than " + guess);
            }
        }
    }
}
