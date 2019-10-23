
using UnityEngine;
using UnityEngine.SceneManagement;
[CreateAssetMenu]
public class SceneChange : ScriptableObject
{

    public void LoadScene(Object sceneName)
    {
        var newName = sceneName.name;
        SceneManager.LoadScene(newName);
    }
}
