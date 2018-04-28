// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;

namespace Microsoft.Docs.Build
{
    /// <summary>
    /// A docset is a collection of documents in the folder identified by `docfx.yml`.
    /// </summary>
    internal class Docset
    {
        /// <summary>
        /// Gets the absolute path to folder containing `docfx.yml`, it is not necessarily the path to git repository.
        /// </summary>
        public string DocsetPath { get; }

        /// <summary>
        /// Gets the config associated with this docset, loaded from `docfx.yml`.
        /// </summary>
        public Config Config { get; }

        /// <summary>
        /// Gets the owning repostiroy if this docset is managed by git, otherwise returns null.
        /// </summary>
        public Repository Repository { get; }

        public Docset(string docsetPath, CommandLineOptions options)
            : this(docsetPath, Config.Load(docsetPath, options))
        {
        }

        public Docset(string docsetPath, Config config)
        {
            DocsetPath = Path.GetFullPath(docsetPath);
            Config = config;
        }
    }
}
