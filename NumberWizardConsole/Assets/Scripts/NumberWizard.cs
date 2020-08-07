using UnityEngine;

namespace NumberWizard
{
    public class NumberWizard : MonoBehaviour
    {
        private int _min;
        private int _max;
        private int _guess;

        // Start is called before the first frame update
        private void Start()
        {
            StartGame();
        }

        private void StartGame()
        {
            _max = 1000;
            _min = 1;
            _guess = 500;

            Debug.Log("Welcome to Number Wizard!");
            Debug.Log("Pick a number, don't tell me what it is...");
            Debug.Log("The highest number you can pick is: " + _max);
            Debug.Log("The lowest number you can pick is: " + _min);
            Debug.Log("Tell me if your number is higher or lower than " + _guess);
            Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");

            _max++;
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("I am a genius!");
                StartGame();
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _min = _guess;
                NextGuess();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _max = _guess;
                NextGuess();
            }
        }

        private void NextGuess()
        {
            _guess = (_max + _min) / 2;
            Debug.Log("Is it higher or lower than " + _guess);
        }
    }
}
