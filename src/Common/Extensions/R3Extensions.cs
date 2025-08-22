using System;
using Sentinel.ViewModels;

namespace Sentinel.Common.Extensions;

public static class R3Extensions
{
    public static IDisposable AddTo<TVIewModel>(this IDisposable disposable, TVIewModel viewModel)
        where TVIewModel : ViewModel
    {
        viewModel.OnDispose(disposable.Dispose);
        return disposable;
    }
}
