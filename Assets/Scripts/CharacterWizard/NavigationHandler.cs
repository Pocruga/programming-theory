using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pocruga.OOPT.CharacterWizard
{
    public class NavigationHandler : MonoBehaviour
    {
        public void LoadAbilityScore()
        {
            SceneManager.LoadScene(2);
        }

        public void LoadSummary()
        {
            SceneManager.LoadScene(3);
        }

        public void ExitEditor()
        {
            SceneManager.LoadScene(0);
        }
    }
}