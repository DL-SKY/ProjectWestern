using UnityEngine;

namespace ProjectWestern.Tools.Components
{
    public class DontDestroyObject : MonoBehaviour
    {
        protected virtual void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
