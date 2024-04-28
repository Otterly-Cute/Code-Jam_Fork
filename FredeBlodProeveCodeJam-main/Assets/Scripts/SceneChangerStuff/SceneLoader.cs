using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// https://www.youtube.com/watch?v=YMj2qPq9CP8

public class SceneLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;

    public void LoadScene(string sceneName)
    {
        Debug.Log("Loading scene: " + sceneName);
        StartCoroutine(LoadAsynchronously(sceneName));
    }

    IEnumerator LoadAsynchronously(string sceneName)
    {
        loadingScreen.SetActive(true); // vi kan bruge samme koncept her til en transitionary skærm
        yield return new WaitForSeconds(1);
        
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        // vi skal nok også sætte noget op som deaktiverer den, men det burde være ret lige til når det er

        while (!operation.isDone) {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress; // behøves ikke medmindre vi vil have en progress bar
            
            yield return null;
        }
    }
}
