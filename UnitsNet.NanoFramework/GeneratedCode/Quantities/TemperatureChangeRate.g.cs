//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Temperature change rate is the ratio of the temperature change to the time during which the change occurred (value of temperature changes per unit time).
    /// </summary>
    public struct  TemperatureChangeRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TemperatureChangeRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public TemperatureChangeRateUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public TemperatureChangeRate(double value, TemperatureChangeRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static TemperatureChangeRateUnit BaseUnit { get; } = TemperatureChangeRateUnit.DegreeCelsiusPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static TemperatureChangeRate MaxValue { get; } = new TemperatureChangeRate(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static TemperatureChangeRate MinValue { get; } = new TemperatureChangeRate(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static TemperatureChangeRate Zero { get; } = new TemperatureChangeRate(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get TemperatureChangeRate in CentidegreesCelsiusPerSecond.
        /// </summary>
        public double CentidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in DecadegreesCelsiusPerSecond.
        /// </summary>
        public double DecadegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in DecidegreesCelsiusPerSecond.
        /// </summary>
        public double DecidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in DegreesCelsiusPerMinute.
        /// </summary>
        public double DegreesCelsiusPerMinute => As(TemperatureChangeRateUnit.DegreeCelsiusPerMinute);

        /// <summary>
        ///     Get TemperatureChangeRate in DegreesCelsiusPerSecond.
        /// </summary>
        public double DegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in HectodegreesCelsiusPerSecond.
        /// </summary>
        public double HectodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in KilodegreesCelsiusPerSecond.
        /// </summary>
        public double KilodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in MicrodegreesCelsiusPerSecond.
        /// </summary>
        public double MicrodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in MillidegreesCelsiusPerSecond.
        /// </summary>
        public double MillidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate in NanodegreesCelsiusPerSecond.
        /// </summary>
        public double NanodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get TemperatureChangeRate from CentidegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromCentidegreesCelsiusPerSecond(double centidegreescelsiuspersecond) => new TemperatureChangeRate(centidegreescelsiuspersecond, TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate from DecadegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDecadegreesCelsiusPerSecond(double decadegreescelsiuspersecond) => new TemperatureChangeRate(decadegreescelsiuspersecond, TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate from DecidegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDecidegreesCelsiusPerSecond(double decidegreescelsiuspersecond) => new TemperatureChangeRate(decidegreescelsiuspersecond, TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate from DegreesCelsiusPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDegreesCelsiusPerMinute(double degreescelsiusperminute) => new TemperatureChangeRate(degreescelsiusperminute, TemperatureChangeRateUnit.DegreeCelsiusPerMinute);

        /// <summary>
        ///     Get TemperatureChangeRate from DegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDegreesCelsiusPerSecond(double degreescelsiuspersecond) => new TemperatureChangeRate(degreescelsiuspersecond, TemperatureChangeRateUnit.DegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate from HectodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromHectodegreesCelsiusPerSecond(double hectodegreescelsiuspersecond) => new TemperatureChangeRate(hectodegreescelsiuspersecond, TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate from KilodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromKilodegreesCelsiusPerSecond(double kilodegreescelsiuspersecond) => new TemperatureChangeRate(kilodegreescelsiuspersecond, TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate from MicrodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromMicrodegreesCelsiusPerSecond(double microdegreescelsiuspersecond) => new TemperatureChangeRate(microdegreescelsiuspersecond, TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate from MillidegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromMillidegreesCelsiusPerSecond(double millidegreescelsiuspersecond) => new TemperatureChangeRate(millidegreescelsiuspersecond, TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);

        /// <summary>
        ///     Get TemperatureChangeRate from NanodegreesCelsiusPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromNanodegreesCelsiusPerSecond(double nanodegreescelsiuspersecond) => new TemperatureChangeRate(nanodegreescelsiuspersecond, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TemperatureChangeRateUnit" /> to <see cref="TemperatureChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>TemperatureChangeRate unit value.</returns>
        public static TemperatureChangeRate From(double value, TemperatureChangeRateUnit fromUnit)
        {
            return new TemperatureChangeRate(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(TemperatureChangeRateUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public TemperatureChangeRate ToUnit(TemperatureChangeRateUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new TemperatureChangeRate(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond: return (_value) * 1e-2d;
                case TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond: return (_value) * 1e1d;
                case TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond: return (_value) * 1e-1d;
                case TemperatureChangeRateUnit.DegreeCelsiusPerMinute: return _value/60;
                case TemperatureChangeRateUnit.DegreeCelsiusPerSecond: return _value;
                case TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond: return (_value) * 1e2d;
                case TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond: return (_value) * 1e3d;
                case TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond: return (_value) * 1e-6d;
                case TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond: return (_value) * 1e-3d;
                case TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond: return (_value) * 1e-9d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(TemperatureChangeRateUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond: return (baseUnitValue) / 1e-2d;
                case TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond: return (baseUnitValue) / 1e1d;
                case TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond: return (baseUnitValue) / 1e-1d;
                case TemperatureChangeRateUnit.DegreeCelsiusPerMinute: return baseUnitValue*60;
                case TemperatureChangeRateUnit.DegreeCelsiusPerSecond: return baseUnitValue;
                case TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond: return (baseUnitValue) / 1e2d;
                case TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond: return (baseUnitValue) / 1e3d;
                case TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond: return (baseUnitValue) / 1e-6d;
                case TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond: return (baseUnitValue) / 1e-3d;
                case TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond: return (baseUnitValue) / 1e-9d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

