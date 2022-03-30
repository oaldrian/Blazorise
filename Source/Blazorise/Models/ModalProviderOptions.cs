﻿#region Using directives
#endregion

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Blazorise
{
    /// <summary>
    /// Sets the options for Modal Provider
    /// </summary>
    public class ModalProviderOptions
    {

        /// <summary>
        /// Upon closing the modal, clears the content that has been previously rendered.
        /// Defaults to true.
        /// </summary>
        [Parameter] public bool ResetOnClose { get; set; } = true;

        /// <summary>
        /// Uses the modal standard structure, by setting this to true you are only in charge of providing the custom content.
        /// Defaults to true.
        /// </summary>
        public bool UseModalStructure { get; set; } = true;

        /// <summary>
        /// If true modal will scroll to top when opened.
        /// </summary>
        public bool ScrollToTop { get; set; } = true;

        /// <summary>
        /// Occurs before the modal is opened.
        /// </summary>
        public Func<ModalOpeningEventArgs, Task> Opening { get; set; }

        /// <summary>
        /// Occurs before the modal is closed.
        /// </summary>
        public Func<ModalClosingEventArgs, Task> Closing { get; set; }

        /// <summary>
        /// Occurs after the modal has opened.
        /// </summary>
        public EventCallback Opened { get; set; }

        /// <summary>
        /// Occurs after the modal has closed.
        /// </summary>
        public EventCallback Closed { get; set; }

        /// <summary>
        /// Specifies the backdrop needs to be rendered for this <see cref="Modal"/>.
        /// </summary>
        public bool ShowBackdrop { get; set; } = true;

        /// <summary>
        /// Gets or sets the animation duration.
        /// </summary>
        public bool Animated { get; set; } = true;

        /// <summary>
        /// Gets or sets whether the component has any animations.
        /// </summary>
        public int AnimationDuration { get; set; } = 150;

        /// <summary>
        /// Defines how the modal content will be rendered.
        /// </summary>
        public ModalRenderMode RenderMode { get; set; }

        /// <summary>
        /// Defines if the modal should keep the input focus at all times.
        /// </summary>
        public bool? FocusTrap { get; set; }

    }
}