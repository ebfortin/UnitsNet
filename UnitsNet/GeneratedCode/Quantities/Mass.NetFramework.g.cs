﻿//------------------------------------------------------------------------------
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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     In physics, mass (from Greek μᾶζα "barley cake, lump [of dough]") is a property of a physical system or body, giving rise to the phenomena of the body's resistance to being accelerated by a force and the strength of its mutual gravitational attraction with other bodies. Instruments such as mass balances or scales use those phenomena to measure mass. The SI unit of mass is the kilogram (kg).
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Mass : IComparable, IComparable<Mass>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Mass from nullable Centigrams.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromCentigrams(QuantityValue? centigrams)
        {
            return centigrams.HasValue ? FromCentigrams(centigrams.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Decagrams.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromDecagrams(QuantityValue? decagrams)
        {
            return decagrams.HasValue ? FromDecagrams(decagrams.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Decigrams.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromDecigrams(QuantityValue? decigrams)
        {
            return decigrams.HasValue ? FromDecigrams(decigrams.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Grams.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromGrams(QuantityValue? grams)
        {
            return grams.HasValue ? FromGrams(grams.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Hectograms.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromHectograms(QuantityValue? hectograms)
        {
            return hectograms.HasValue ? FromHectograms(hectograms.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Kilograms.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromKilograms(QuantityValue? kilograms)
        {
            return kilograms.HasValue ? FromKilograms(kilograms.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Kilopounds.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromKilopounds(QuantityValue? kilopounds)
        {
            return kilopounds.HasValue ? FromKilopounds(kilopounds.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Kilotonnes.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromKilotonnes(QuantityValue? kilotonnes)
        {
            return kilotonnes.HasValue ? FromKilotonnes(kilotonnes.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable LongHundredweight.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromLongHundredweight(QuantityValue? longhundredweight)
        {
            return longhundredweight.HasValue ? FromLongHundredweight(longhundredweight.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable LongTons.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromLongTons(QuantityValue? longtons)
        {
            return longtons.HasValue ? FromLongTons(longtons.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Megapounds.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromMegapounds(QuantityValue? megapounds)
        {
            return megapounds.HasValue ? FromMegapounds(megapounds.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Megatonnes.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromMegatonnes(QuantityValue? megatonnes)
        {
            return megatonnes.HasValue ? FromMegatonnes(megatonnes.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Micrograms.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromMicrograms(QuantityValue? micrograms)
        {
            return micrograms.HasValue ? FromMicrograms(micrograms.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Milligrams.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromMilligrams(QuantityValue? milligrams)
        {
            return milligrams.HasValue ? FromMilligrams(milligrams.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Nanograms.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromNanograms(QuantityValue? nanograms)
        {
            return nanograms.HasValue ? FromNanograms(nanograms.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Ounces.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromOunces(QuantityValue? ounces)
        {
            return ounces.HasValue ? FromOunces(ounces.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Pounds.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromPounds(QuantityValue? pounds)
        {
            return pounds.HasValue ? FromPounds(pounds.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable ShortHundredweight.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromShortHundredweight(QuantityValue? shorthundredweight)
        {
            return shorthundredweight.HasValue ? FromShortHundredweight(shorthundredweight.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable ShortTons.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromShortTons(QuantityValue? shorttons)
        {
            return shorttons.HasValue ? FromShortTons(shorttons.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Slugs.
        /// </summary>
        public static Mass? FromSlugs(QuantityValue? slugs)
        {
            return slugs.HasValue ? FromSlugs(slugs.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Stone.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromStone(QuantityValue? stone)
        {
            return stone.HasValue ? FromStone(stone.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Tonnes.
        /// </summary>
        [Obsolete("Nullable type support is obsolete and will be removed in a future release.")]
        public static Mass? FromTonnes(QuantityValue? tonnes)
        {
            return tonnes.HasValue ? FromTonnes(tonnes.Value) : default(Mass?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MassUnit" /> to <see cref="Mass" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Mass unit value.</returns>
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Mass? From(QuantityValue? value, MassUnit fromUnit)
        {
            return value.HasValue ? new Mass((double)value.Value, fromUnit) : default(Mass?);
        }

        #endregion

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MassUnit unit, [CanBeNull] IFormatProvider provider)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            return UnitSystem.GetCached(provider).GetDefaultAbbreviation(unit);
        }

        #region Arithmetic Operators

        public static Mass operator -(Mass right)
        {
            return new Mass(-right.Value, right.Unit);
        }

        public static Mass operator +(Mass left, Mass right)
        {
            return new Mass(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Mass operator -(Mass left, Mass right)
        {
            return new Mass(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Mass operator *(double left, Mass right)
        {
            return new Mass(left * right.Value, right.Unit);
        }

        public static Mass operator *(Mass left, double right)
        {
            return new Mass(left.Value * right, left.Unit);
        }

        public static Mass operator /(Mass left, double right)
        {
            return new Mass(left.Value / right, left.Unit);
        }

        public static double operator /(Mass left, Mass right)
        {
            return left.Kilograms / right.Kilograms;
        }

        #endregion

        public static bool operator <=(Mass left, Mass right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Mass left, Mass right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Mass left, Mass right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Mass left, Mass right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Mass left, Mass right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Mass left, Mass right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Mass Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            provider = provider ?? UnitSystem.DefaultCulture;

            return QuantityParser.Parse<Mass, MassUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    MassUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromKilograms(x.Kilograms + y.Kilograms));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out Mass result)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            try
            {
                result = Parse(str, provider);
                return true;
            }
            catch
            {
                result = default(Mass);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        [Obsolete("Use overload that takes IFormatProvider instead of culture name. This method was only added to support WindowsRuntimeComponent and will be removed from .NET Framework targets.")]
        public static MassUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static MassUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<MassUnit>(str.Trim());

            if (unit == MassUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized MassUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>String representation.</returns>
        public string ToString(MassUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return ToString(unit, provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(MassUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(MassUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? UnitSystem.DefaultCulture;

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion
    }
}
