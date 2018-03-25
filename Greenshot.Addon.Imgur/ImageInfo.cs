﻿#region Greenshot GNU General Public License

// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2018 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: http://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

#endregion

#region Usings

using System;
using System.Drawing;
using System.Windows.Media;
using System.Xml;
using Dapplo.Log;

#endregion

namespace Greenshot.Addon.Imgur
{
    /// <summary>
    ///     Description of ImageInfo.
    /// </summary>
    public class ImageInfo : IDisposable
    {
        private Image _image;

        public string DeleteHash { get; set; }

        public string Id { get; set; }

        public ImageSource Image { get; set; }

        public Uri Original { get; set; }

        public Uri Page { get; set; }

        public Uri SmallSquare { get; set; }

        public DateTimeOffset Timestamp { get; set; }

        public string Title { get; set; }

        /// <summary>
        ///     The public accessible Dispose
        ///     Will call the GarbageCollector to SuppressFinalize, preventing being cleaned twice
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        ///     This Dispose is called from the Dispose and the Destructor.
        ///     When disposing==true all non-managed resources should be freed too!
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _image?.Dispose();
            }
            _image = null;
        }
    }
}