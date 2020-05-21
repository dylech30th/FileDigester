#region Copyright (C) 2019-2020 Dylech30th. All rights reserved.
// Pixeval - A Strong, Fast and Flexible Pixiv Client
// Copyright (C) 2019-2020 Dylech30th
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;

namespace FileDigester
{
    public static class Files
    {
        /// <summary>
        /// Walk through a directory tree start with a root file, and performs <see cref="IFileVisitor.Visit"/> on each walked file
        /// </summary>
        /// <param name="fileSystemInfo">the root file</param>
        /// <param name="visitor">a visitor pattern</param>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="SecurityException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        public static void WalkFileTree(this FileSystemInfo fileSystemInfo, IFileVisitor visitor)
        {
            switch (fileSystemInfo)
            {
                case FileInfo file:
                    visitor.Visit(file);
                    return;
                case DirectoryInfo directoryInfo:
                {
                    // walk thru directories
                    var dirRemains = new Stack<DirectoryInfo>();
                    if (!directoryInfo.Exists)
                    {
                        throw new DirectoryNotFoundException(directoryInfo.FullName);
                    }
                    dirRemains.Push(directoryInfo);
                    while (dirRemains.Any())
                    {
                        var toWalk = dirRemains.Pop();
                        foreach (var fileInfo in toWalk.GetFiles())
                        {
                            visitor.Visit(fileInfo);
                        }

                        foreach (var subDirectory in toWalk.GetDirectories())
                        {
                            dirRemains.Push(subDirectory);
                        }
                    }

                    return;
                }
                default:
                    throw new ArgumentException($"parameter {nameof(fileSystemInfo)} must be one of {{{nameof(FileInfo)}, {nameof(DirectoryInfo)}}}");
            }
        }
    }
}