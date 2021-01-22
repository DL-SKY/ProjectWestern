using ProjectWestern.Constants;
using ProjectWestern.Services;
using ProjectWestern.UI.WindowsManager;
using ProjectWestern.UI.Windows.Loading;
using ProjectWestern.UI.Windows.MainMenu;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectWestern.Scenes.MainMenu
{
    public class MainMenuSceneController : MonoBehaviour
    {
        private void Awake()
        {
            var windowsManager = ComponentLocator.Resolve<WindowsManager>();
            windowsManager.CreateWindow<MainMenuWindow>(MainMenuWindow.prefabPath, Enums.EnumWindowsLayer.Main);
        }
    }
}
