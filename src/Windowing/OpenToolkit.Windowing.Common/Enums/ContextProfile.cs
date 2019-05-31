//
// ContextProfile.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Selects the profile for the context's graphics API.
    /// </summary>
    public enum ContextProfile
    {
        /// <summary>
        /// Allow the profile to be chosen by the implementation.
        /// </summary>
        DontCare,

        /// <summary>
        /// Selects compatability profile. You should only use this if maintaining legacy code.
        /// </summary>
        Compatability,

        /// <summary>
        /// Selects core profile. All new projects should use this unless they have a good reason not to.
        /// </summary>
        Core,
    }
}
