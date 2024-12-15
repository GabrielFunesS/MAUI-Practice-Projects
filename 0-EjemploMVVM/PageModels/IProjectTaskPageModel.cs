using _0_EjemploMVVM.Models;
using CommunityToolkit.Mvvm.Input;

namespace _0_EjemploMVVM.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}