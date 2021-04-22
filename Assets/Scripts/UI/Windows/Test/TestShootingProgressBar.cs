using ProjectWestern.UI.Components;

namespace ProjectWestern.UI.Windows.Test
{
    public class TestShootingProgressBar : ProgressBar
    {
        public void AddFillAmount(float _delta)
        {
            FillAmount += _delta;
        }
    }
}
