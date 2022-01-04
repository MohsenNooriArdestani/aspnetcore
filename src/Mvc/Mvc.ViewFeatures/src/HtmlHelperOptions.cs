// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Mvc.Rendering;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures;

/// <summary>
/// Provides programmatic configuration for the HTML helpers and <see cref="ViewContext"/>.
/// </summary>
public class HtmlHelperOptions
{
    private string _idAttributeDotReplacement = "_";

    /// <summary>
    /// Gets or sets the <see cref="Html5DateRenderingMode.Html5DateRenderingMode"/> value.
    /// </summary>
    /// <remarks>
    /// Set this property to <see cref="Html5DateRenderingMode.CurrentCulture" /> to have templated helpers such as
    /// <see cref="IHtmlHelper.Editor" /> and <see cref="IHtmlHelper{TModel}.EditorFor" /> render date and time
    /// values using the current culture. By default, these helpers render dates and times as RFC 3339 compliant strings.
    /// </remarks>
    public Html5DateRenderingMode Html5DateRenderingMode { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="string"/> that replaces periods in the ID attribute of an element.
    /// </summary>
    public string IdAttributeDotReplacement
    {
        get => _idAttributeDotReplacement;
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _idAttributeDotReplacement = value;
        }
    }

    /// <summary>
    /// Gets or sets a value that indicates whether client-side validation is enabled.
    /// </summary>
    public bool ClientValidationEnabled { get; set; } = true;

    /// <summary>
    /// Gets or sets the element name used to wrap a top-level message generated by
    /// <see cref="IHtmlHelper.ValidationMessage"/> and other overloads.
    /// </summary>
    public string ValidationMessageElement { get; set; } = "span";

    /// <summary>
    /// Gets or sets the element name used to wrap a top-level message generated by
    /// <see cref="IHtmlHelper.ValidationSummary"/> and other overloads.
    /// </summary>
    public string ValidationSummaryMessageElement { get; set; } = "span";

    /// <summary>
    /// Gets or sets the way hidden inputs are rendered for checkbox tag helpers and html helpers.
    /// </summary>
    public CheckBoxHiddenInputRenderMode CheckBoxHiddenInputRenderMode { get; set; } = CheckBoxHiddenInputRenderMode.EndOfForm;
}
