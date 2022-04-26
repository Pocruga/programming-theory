#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pocruga.OOPT
{
    public class MenuHandler : MonoBehaviour
    {
        public void StartCharacterCreation()
        {
            SceneManager.LoadScene(1);
        }

        public void Exit()
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
        }
    }
}
