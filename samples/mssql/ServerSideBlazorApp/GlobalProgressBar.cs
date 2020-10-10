﻿using System;
using System.Threading.Tasks;

namespace ServerSideBlazorApp
{
    public class GlobalProgressBar
    {
        public async Task Show()
        {
            if (ShowProgress is object)
            {
                await ShowProgress.Invoke();
            }
        }

        public async Task Hide()
        {
            if (HideProgress is object)
            {
                await HideProgress.Invoke();
            }
        }

        public event Func<Task> ShowProgress;
        public event Func<Task> HideProgress;
    }
}