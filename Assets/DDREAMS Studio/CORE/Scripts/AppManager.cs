using UnityEngine;
using UnityEditor;

namespace DDREAMS.CORE
{
    public class AppManager : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("By default the cursor is visible during runtime. Check the checkbox if you want to disable the cursor.")]
        private bool _IsCursorVisible = true;

        private void Start()
        {
            // By default the cursor is visible
            Cursor.visible = _IsCursorVisible;
        }

        public static void QuitApplication()
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
        }
    }
}
