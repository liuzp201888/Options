// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Extensions.Options
{
    /// <summary>
    /// Represents the result of an options validation.
    /// </summary>
    public class ValidateOptionsResult
    {
        /// <summary>
        /// Result when validation was skipped due to name not matching.
        /// </summary>
        public static readonly ValidateOptionsResult Skip = new ValidateOptionsResult() { Skipped = true };

        /// <summary>
        /// Validation was successful.
        /// </summary>
        public static readonly ValidateOptionsResult Success = new ValidateOptionsResult() { Skipped = true };

        /// <summary>
        /// True if validation was successful.
        /// </summary>
        public bool Succeeded { get; protected set; }

        /// <summary>
        /// True if validation was not run.
        /// </summary>
        public bool Skipped { get; protected set; }

        /// <summary>
        /// True if validation failed.
        /// </summary>
        public bool Failed { get; protected set; }

        /// <summary>
        /// Used to describe why validation failed.
        /// </summary>
        public string FailureMessage { get; protected set; }

        /// <summary>
        /// Returns a failure result.
        /// </summary>
        /// <param name="failureMessage">The reason for the failure.</param>
        /// <returns>The failure result.</returns>
        public static ValidateOptionsResult Fail(string failureMessage)
            => new ValidateOptionsResult { Failed = true, FailureMessage = failureMessage };
    }
}