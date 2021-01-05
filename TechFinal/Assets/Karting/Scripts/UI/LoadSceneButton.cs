using UnityEngine;
using UnityEngine.SceneManagement;

namespace KartGame.UI
{
    public class LoadSceneButton : MonoBehaviour
    {
        [Tooltip("What is the name of the scene we want to load when clicking the button?")]
        public string SceneName;

        public void LoadTargetScene() 
        {
            
            switch(PlayerPrefs.GetInt("Level"))
            {
                case 1:
                    SceneName = "LevelTwoScene";
                    break;
                case 2:
                    SceneName = "LevelThreeScene";
                    break;
                case 3:
                    SceneName = "IntroMenu";
                    break;

            }

            SceneManager.LoadSceneAsync(SceneName);
        }

        public void IntoSelect()
        {
            SceneManager.LoadSceneAsync(SceneName);
        }
        public void ExitGame()
        {
            
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;        
        #else
            Application.Quit();
        #endif
        }
    }
}
