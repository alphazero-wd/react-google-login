using UnityEngine;

public class Timer : MonoBehaviour
{
    int timeToPress;
    float roundStartTime;
    int roundStartDelayTime = 3;
    bool isPlaying;
    void Start() {
        print("Press the Space key when you think it's time to press.");
        Invoke("GenerateRandomTime", roundStartDelayTime);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && isPlaying) {
            float playerPressTime = Time.time - roundStartTime;
            float difference = Mathf.Abs(playerPressTime - timeToPress);
            print($"You pressed at {playerPressTime}. That's {difference} seconds late. {GenerateMessage(difference)}!");
            isPlaying = false;
            Invoke("GenerateRandomTime", roundStartDelayTime);
        }
    }

    string GenerateMessage(float difference) {
        if (difference <= .15) return "Superhuman";
        else if (difference <= .5) return "Superb";
        else if (difference <= .75) return "Excellent";
        else if (difference <= 1) return "Good";
        else return "Bad";
    }

    void GenerateRandomTime() {
        timeToPress = Random.Range(3, 11);
        roundStartTime = Time.time;
        isPlaying = true;
        print($"Press Space at {timeToPress} seconds.");
    }
}
