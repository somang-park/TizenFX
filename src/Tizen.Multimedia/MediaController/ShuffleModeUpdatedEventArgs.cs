/*
* Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
*
* Licensed under the Apache License, Version 2.0 (the License);
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an AS IS BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


using System;

namespace Tizen.Multimedia.MediaController
{

    /// <summary>
    /// ShuffleModeUpdated event arguments
    /// </summary>
    /// <remarks>
    /// ShuffleModeUpdated event arguments
    /// </remarks>
    public class ShuffleModeUpdatedEventArgs : EventArgs
    {
        internal string _serverName;
        internal MediaControllerShuffleMode _mode;

        internal ShuffleModeUpdatedEventArgs (string name, MediaControllerShuffleMode mode)
        {
            _serverName = name;
            _mode = mode;
        }

        /// <summary>
        /// Get server name.
        /// </summary>
        public string ServerName
        {
            get
            {
                return _serverName;
            }
        }

        /// <summary>
        /// Get shuffle mode.
        /// </summary>
        public MediaControllerShuffleMode ShuffleMode
        {
            get
            {
                return _mode;
            }
        }
    }
}

