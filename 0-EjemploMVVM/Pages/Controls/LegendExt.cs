using Syncfusion.Maui.Toolkit.Charts;

namespace _0_EjemploMVVM.Pages.Controls
{
    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.5;
        }
    }
}
