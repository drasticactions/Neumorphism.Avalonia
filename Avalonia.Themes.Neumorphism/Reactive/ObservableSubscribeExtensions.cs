using System;
using Avalonia.Reactive;

namespace Avalonia.Themes.Neumorphism
{
    internal static class ObservableSubscribeExtensions
    {
        public static IDisposable Subscribe<T>(this IObservable<T> source, Action<T> onNext)
            => source.Subscribe(new AnonymousObserver<T>(onNext));
    }
}
