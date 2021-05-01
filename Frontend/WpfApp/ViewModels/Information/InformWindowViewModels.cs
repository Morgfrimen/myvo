﻿using System;
using System.Threading;

namespace WpfApp.ViewModels.Information
{
    public sealed class InformWindowViewModels : ViewModelsBase
    {
        public CancellationTokenSource CancellationTokenSource { get; }

        public InformWindowViewModels(CancellationTokenSource cancellationTokenSource)
        {
            CancellationTokenSource = cancellationTokenSource;
        }

        public event Action ExitAppEvent;

        internal void OnExitAppEvent()
        {
            this.ExitAppEvent?.Invoke();
        }
    }
}