﻿using System;
using System.Threading.Tasks;

namespace Template10.Core
{
    using Windows.UI.Core;

    public interface IDispatcherEx : IDispatch
    {
        bool HasThreadAccess();
    }

    public interface IDispatch
    {
        void Dispatch(Action action, int delayms = 0, CoreDispatcherPriority priority = CoreDispatcherPriority.Normal);
        T Dispatch<T>(Func<T> action, int delayms = 0, CoreDispatcherPriority priority = CoreDispatcherPriority.Normal);
        Task DispatchAsync(Func<Task> func, int delayms = 0, CoreDispatcherPriority priority = CoreDispatcherPriority.Normal);
        Task<T> DispatchAsync<T>(Func<Task<T>> func, int delayms = 0, CoreDispatcherPriority priority = CoreDispatcherPriority.Normal);
        Task DispatchAsync(Action action, int delayms = 0, CoreDispatcherPriority priority = CoreDispatcherPriority.Normal);
        Task<T> DispatchAsync<T>(Func<T> func, int delayms = 0, CoreDispatcherPriority priority = CoreDispatcherPriority.Normal);
    }

    public interface IDispatchIdle
    {
        void DispatchIdle(Action action, int delayms = 0);
        T DispatchIdle<T>(Func<T> action, int delayms = 0) where T : class;
        Task DispatchIdleAsync(Func<Task> func, int delayms = 0);
        Task DispatchIdleAsync(Action action, int delayms = 0);
        Task<T> DispatchIdleAsync<T>(Func<T> func, int delayms = 0);
    }
}