#region license
// Copyright (c) HatTrick Labs, LLC.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// The latest version of this file can be found at https://github.com/HatTrickLabs/db-ex
#endregion

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatTrick.DbEx.Tools.Service
{
    public class FeedbackService
    {
        #region internals
        private Action<To, string> _receivers = new((t,s) => { });
        #endregion

        #region register
        public void Register(To to, Action<string> receiver)
        {
            Action<To, string> wrap = (t, m) =>
            {
                if (t == to)
                {
                    receiver(m);
                };
            };
            _receivers += wrap;
        }
        #endregion

        #region push
        public void Push(To to, string msg)
        {
            _receivers?.Invoke(to, msg);
        }

        public void PushException(ExceptionFeedback exfeedback)
        {
            _receivers?.Invoke(To.Fatal, exfeedback.ToJsonString());
        }
        #endregion
    }

    public enum To
    {
        ConsoleOnly = -1,
        Trace = 0,
        Debug = 1,
        Info = 2,
        Warn = 3,
        Error = 4,
        Fatal = 5
    }
}
