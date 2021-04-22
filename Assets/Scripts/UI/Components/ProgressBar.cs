﻿using UnityEngine;
using UnityEngine.UI;

namespace ProjectWestern.UI.Components
{
    public class ProgressBar : MonoBehaviour
    {
        [SerializeField] protected Image mainProgressBar;

        public float FillAmount
        {
            set { mainProgressBar.fillAmount = value; }
            get { return mainProgressBar.fillAmount; }
        }
    }
}
