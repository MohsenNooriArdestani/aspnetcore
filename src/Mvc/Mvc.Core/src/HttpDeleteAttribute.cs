// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Mvc.Routing;

namespace Microsoft.AspNetCore.Mvc;

/// <summary>
/// Identifies an action that supports the HTTP DELETE method.
/// </summary>
public class HttpDeleteAttribute : HttpMethodAttribute
{
    private static readonly IEnumerable<string> _supportedMethods = new[] { "DELETE" };

    /// <summary>
    /// Creates a new <see cref="HttpDeleteAttribute"/>.
    /// </summary>
    public HttpDeleteAttribute()
        : base(_supportedMethods)
    {
    }

    /// <summary>
    /// Creates a new <see cref="HttpDeleteAttribute"/> with the given route template.
    /// </summary>
    /// <param name="template">The route template. May not be null.</param>
    public HttpDeleteAttribute(string template)
        : base(_supportedMethods, template)
    {
        if (template == null)
        {
            throw new ArgumentNullException(nameof(template));
        }
    }
}
