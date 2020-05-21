#region Copyright (C) 2019-2020 Dylech30th. All rights reserved.
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
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileDigester
{
    public enum ChecksumAlgorithm
    {
        SHA256,
        MD5,
        SHA1
    }

    public class Digester
    {

        public static async Task<IReadOnlyDictionary<string, string>> DigestDirectory(string root, ChecksumAlgorithm checksumAlgorithm)
        {
            var composeVisitor = new ComposeFileVisitor();
            if (Directory.Exists(root))
            {
                var dir = new DirectoryInfo(root);
                dir.WalkFileTree(composeVisitor);
            }

            var dic = new Dictionary<string, string>();
            foreach (var fileInfo in composeVisitor.Walked)
            {
                await using var stream = fileInfo.OpenRead();
                dic.Add(Path.GetRelativePath(root, fileInfo.FullName), checksumAlgorithm switch
                {
                    ChecksumAlgorithm.SHA256 => Checksum<SHA256CryptoServiceProvider>(stream),
                    ChecksumAlgorithm.MD5    => Checksum<MD5CryptoServiceProvider>(stream),
                    ChecksumAlgorithm.SHA1   => Checksum<SHA1CryptoServiceProvider>(stream),
                    _                        => throw new ArgumentException(nameof(checksumAlgorithm))
                });
            }

            return dic;
        }

        public static async Task<string> GetJsonData(string root, ChecksumAlgorithm checksumAlgorithm)
        {
            return JsonSerializer.Serialize(await DigestDirectory(root, checksumAlgorithm), new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }

        private static string Checksum<T>(Stream stream) where T : HashAlgorithm, new()
        {
            using var crypt = new T();
            var hashBytes = crypt.ComputeHash(stream);
            stream.Position = 0L;
            return hashBytes.Select(b => b.ToString("x2")).Aggregate((s1, s2) => s1 + s2);
        }

        public static async Task Main(string[] args)
        {
            var input = args[0];
            var output = args[1];
            var checksum = args[2];
            await File.WriteAllTextAsync(
                output, await GetJsonData(input, Enum.Parse<ChecksumAlgorithm>(checksum, true)), Encoding.UTF8);
        }
    }
}
