using UnityEngine.SceneManagement;
using UnityEngine;
public class SceneLoadButton : BaseButtonScript
{
    [SerializeField] int sceneToLoadIndex;
    protected override void OnButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneToLoadIndex);
    }

    
}
