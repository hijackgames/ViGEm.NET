﻿using JetBrains.Annotations;
using Nefarius.ViGEm.Client.Targets.Xbox360;

namespace Nefarius.ViGEm.Client.Targets
{
    /// <summary>
    ///     Describes Xbox 360 pad-specific methods and properties.
    /// </summary>
    public interface IXbox360Controller
    {
        [UsedImplicitly]
        void SetButtonState(Xbox360Button button, bool pressed);

        [UsedImplicitly]
        void SetAxisValue(Xbox360Axis axis, short value);

        [UsedImplicitly]
        void SetSliderValue(Xbox360Slider slider, byte value);
    }
}